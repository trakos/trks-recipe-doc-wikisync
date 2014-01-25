using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using LinqToWiki;
using TrksRecipeDoc.MekaWiki;
using TrksRecipeDoc.Properties;
using TrksRecipeDoc.Recipes;

namespace TrksRecipeDoc
{
    class Program
    {
        private const bool TRKS_DEBUG = true;
        private const bool TRKS_ADD_ICONS_B = false;
        private const bool TRKS_ADD_HANDLERS_B = false;
        private const bool TRKS_ADD_ITEM_PAGE_B = true;
        private const bool TRKS_ADD_MOD_TEMPLATES_B = true;

        private const String DUMP_DIR = "C:/test";

        static String _readPasswordFromConsole()
        {
            String password = "";
            ConsoleKeyInfo key;
            while ((key = Console.ReadKey(true)).Key != ConsoleKey.Enter)
            {
                if (key.Key != ConsoleKey.Backspace)
                {
                    password += key.KeyChar;
                    Console.Write("*");
                }
                else
                {
                    password = password.Substring(0, (password.Length - 1));
                    Console.Write("\b \b");
                }
            }
            
            Console.WriteLine();
            return password;
        }

        static void _promptForCredentials(out String username, out String password, out String wikiSpaceName)
        {
            username = null;
            password = null;
            wikiSpaceName = null;
            // ReSharper disable ConditionIsAlwaysTrueOrFalse
            if (!TRKS_DEBUG)
            {
                Console.Write("Username: ");
                Console.WriteLine("(press enter to use '" + Settings.Default.UserLogin + "')");
                username = Console.ReadLine();
            }
            if (string.IsNullOrEmpty(username))
            {
                username = Settings.Default.UserLogin;
            }
            if (!TRKS_DEBUG)
            {
                Console.Write("Password: ");
                Console.WriteLine("(press enter to use previous password)");
                password = _readPasswordFromConsole();
            }
            if (string.IsNullOrEmpty(password))
            {
                password = Settings.Default.UserPassword;
            }
            if (!TRKS_DEBUG)
            {
                Console.Write("Wikispace name: ");
                Console.WriteLine("(press enter to use '" + Settings.Default.WikiSpaceName + "')");
                wikiSpaceName = Console.ReadLine();
            }
            if (string.IsNullOrEmpty(wikiSpaceName))
            {
                wikiSpaceName = Settings.Default.WikiSpaceName;
            }
            // ReSharper restore ConditionIsAlwaysTrueOrFalse

            Settings.Default.UserLogin = username;
            Settings.Default.UserPassword = password;
            Settings.Default.WikiSpaceName = wikiSpaceName;
            Settings.Default.Save();
        }

        static void Main(string[] args)
        {
            String login, password, wikispaceName;
            _promptForCredentials(out login, out password, out wikispaceName);
            var recipes = _readRecipes();
            _doMekaWikiStuff(recipes, login, password, wikispaceName);
            //Console.ReadKey();
        }

        static RecipesProxy _readRecipes()
        {
            XmlSerializer ser = new XmlSerializer(typeof(TrksRecipeDoc.Recipes.root));
            RecipesProxy recipesProxy;
            using (XmlReader reader = XmlReader.Create(DUMP_DIR + "/recipes.xml"))
            {
                recipesProxy = new RecipesProxy((Recipes.root)ser.Deserialize(reader));
            }
            return recipesProxy;
        }

        static void _doMekaWikiStuff(RecipesProxy recipes, string login, string password, string wikiAddress)
        {
            var wikiAccess = new MekaWikiAccess(login, password, wikiAddress, recipes);
            Console.Out.WriteLine("initialization complete");
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            if (TRKS_ADD_MOD_TEMPLATES_B)
            {
                foreach (var mod in recipes.mods)
                {
                    String title = "Template:" + mod;
                    String newPageText = wikiAccess.itemTextGenerator.generateItemsList(mod);
                    String pageText = wikiAccess.page(mod);
                    if (pageText == null)
                    {
                        wikiAccess.savePage(title, newPageText, "create template");
                    }
                    else
                    {
                        if (pageText != newPageText)
                        {
                            wikiAccess.editPage(title, newPageText, "create template");
                        }
                    }

                }
            }
            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            if (TRKS_ADD_ITEM_PAGE_B || TRKS_ADD_ICONS_B)
            {
                int k = 0;
                foreach (var item in recipes.items.Where(p => int.Parse(p.damage) >= 0 && p.showOnList == "1").GroupBy(p => p.name).Select(p => p.Last()))
                {
                    bool done = false;
                    while (!done)
                    {
                        try
                        {
                            Console.Out.WriteLine("{0} / {1}", k++, recipes.items.Count());
                            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                            if (TRKS_ADD_ICONS_B)
                            {
                                if (wikiAccess.imageChanged(item))
                                {
                                    wikiAccess.itemImageAdd(item);
                                }
                            }

                            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
                            if (TRKS_ADD_ITEM_PAGE_B)
                            {
                                String pageText = wikiAccess.page(item.name);
                                if (pageText == null)
                                {
                                    wikiAccess.savePage(item.name, wikiAccess.itemTextGenerator.createNewItemPageText(item), "create from item: " + item.id + "_" + item.damage);
                                }
                                else
                                {
                                    string newPageText = wikiAccess.itemTextGenerator.editItemPageText(pageText, item);
                                    if (pageText != newPageText)
                                    {
                                        wikiAccess.editPage(item.name, newPageText, "create from item: " + item.id + "_" + item.damage);
                                    }
                                }
                            }
                            done = true;
                        }
                        catch (Exception e)
                        {
                            System.Console.Error.WriteLine(e);
                            Thread.Sleep(5000);
                        }
                    }
                }

            }


            // ReSharper disable once ConditionIsAlwaysTrueOrFalse
            if (TRKS_ADD_HANDLERS_B)
            {
                String imageName = "Recipebg.png";
                String path = Path.Combine(MekaWikiAccess.GENERATED_DATA_DIRECTORY_S, "recipebg.png");
                if (wikiAccess.imageChanged("File:" + imageName, path))
                {
                    wikiAccess.uploadImage(imageName, path);
                }
                foreach (rootRecipeTypesRecipeType recipeHandler in recipes.recipeTypes)
                {
                    if (wikiAccess.handlerImageChanged(recipeHandler))
                    {
                        wikiAccess.handlerImageAdd(recipeHandler);
                    }
                    //string text = ;
                    String pageText = wikiAccess.page(recipeHandler.name);
                    if (pageText == null)
                    {
                        wikiAccess.savePage(recipeHandler.name, wikiAccess.itemTextGenerator.createNewHandlerPageText(recipeHandler), "create for recipes: " + recipeHandler.name);
                    }
                    else
                    {
                        string newPageText = wikiAccess.itemTextGenerator.editHandlerPageText(pageText, recipeHandler);
                        if (pageText != newPageText)
                        {
                            wikiAccess.editPage(recipeHandler.name, newPageText, "create for recipes: " + recipeHandler.name);
                        }
                    }
                }
            }


            wikiAccess.wiki.logout();
        }
    }
}
