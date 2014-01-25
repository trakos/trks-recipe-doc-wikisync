using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using LinqToWiki;
using TrksRecipeDoc.MekaWiki.Entities;
using TrksRecipeDoc.Recipes;

namespace TrksRecipeDoc.MekaWiki
{
    internal class MekaWikiAccess
    {
        public const string GENERATED_DATA_DIRECTORY_S = "C:/test";

        protected tokensResult _tokens;
        protected Wiki _wiki;
        protected MekaWikiItemTextGenerator _mekaWikiItemTextGenerator;
        private readonly Dictionary<string, string> _pages;
        private readonly Dictionary<string, string> _images;

        public MekaWikiItemTextGenerator itemTextGenerator
        {
            get
            {
                return _mekaWikiItemTextGenerator;
            }
        }

        public MekaWikiAccess(String login, String password, String wikiAddress, RecipesProxy recipesProxy)
        {
            _wiki = new Wiki("TrksRecipeDocBot/1.0 (http://trakos.pl, recipedoc@trakos.pl)", wikiAddress);
            _mekaWikiItemTextGenerator = new MekaWikiItemTextGenerator(recipesProxy);
            loginResult session = _wiki.login(login, password);
            _wiki.login(login, password, token: session.token);
            _tokens =
                _wiki.tokens(new[]
                {
                    tokenstype.block,
                    tokenstype.delete,
                    tokenstype.edit,
                    tokenstype.email,
                    tokenstype.import,
                    tokenstype.move,
                    tokenstype.options,
                    tokenstype.patrol,
                    tokenstype.patrol,
                    tokenstype.protect,
                    tokenstype.unblock,
                    tokenstype.watch
                });
            _pages = _wiki.Query.allpages()
                .Pages.Select(p => new Tuple<String, String>(p.info.title, p.revisions().Select(r => r.value).FirstOrDefault()))
                .ToList()
                .ToDictionary(p => p.Item1, p => p.Item2);
            _images = _wiki.Query.allimages().Pages
                .Select(p => new Tuple<String, String>(p.info.title, p.imageinfo().Select(r => r.sha1).ToList().FirstOrDefault()))
                .ToList()
                .ToDictionary(p => p.Item1, p => p.Item2);
        }

        public Wiki wiki { get { return _wiki; } }
        public tokensResult tokens { get { return _tokens; } }

        public string page(String title)
        {
            /*Tuple<string, string> firstOrDefault = _wiki.CreateTitlesSource(title)
                .Select(p => new Tuple<String, String>(p.info.title, p.revisions().Select(r => r.value).FirstOrDefault()))
                .ToEnumerable()
                .FirstOrDefault();
            return firstOrDefault;*/
            return _pages.ContainsKey(title) ? _pages[title] : null;
        }

        public string imageInfo(String title)
        {
            /*Tuple<string, string> firstOrDefault = _wiki.CreateTitlesSource(title)
                .Select(p => new Tuple<String, String>(p.info.title, p.imageinfo().Select(r => r.sha1).ToList().FirstOrDefault()))
                .ToEnumerable()
                .FirstOrDefault();
            return firstOrDefault;*/
            return _images.ContainsKey(title) ? _images[title] : null;
        }

        public bool pageExists(String title)
        {
            return page(title) != null;
        }

        protected SHA1Managed _sha1 = new SHA1Managed();

        protected string _calculateImageSha1(String pathToImage)
        {
            using (FileStream fs = new FileStream(pathToImage, FileMode.Open))
            {
                byte[] hash = _sha1.ComputeHash(fs);
                StringBuilder formatted = new StringBuilder(2 * hash.Length);
                foreach (byte b in hash)
                {
                    formatted.AppendFormat("{0:X2}", b);
                }
                return formatted.ToString();
            }
        }

        public bool imageChanged(rootItemsItem item)
        {
            string path = Path.Combine(GENERATED_DATA_DIRECTORY_S, "icons", item.icon);
            return imageChanged("File:" + _mekaWikiItemTextGenerator.getItemIconName(item), path);
        }

        public bool imageChanged(String title, String pathToImage)
        {
            var info = imageInfo(title.Replace('_', ' '));
            if (info == null) return true;
            string sha1a = info;
            string sha1b = _calculateImageSha1(pathToImage);
            return !String.Equals(sha1a, sha1b, StringComparison.InvariantCultureIgnoreCase);
        }

        public bool itemImageExists(rootItemsItem item)
        {
            return int.Parse(item.damage) >= 0 && pageExists("File:" + _mekaWikiItemTextGenerator.getItemIconName(item));
        }

        public void itemImageAdd(rootItemsItem item)
        {
            if (int.Parse(item.damage) < 0) return;
            string path = Path.Combine(GENERATED_DATA_DIRECTORY_S, "icons", item.icon);
            uploadImage(_mekaWikiItemTextGenerator.getItemIconName(item), path);
        }

        public bool handlerImageExists(rootRecipeTypesRecipeType recipeHandler)
        {
            return pageExists("File:" + _mekaWikiItemTextGenerator.getHandlerImageName(recipeHandler));
        }

        public bool handlerImageChanged(rootRecipeTypesRecipeType recipeHandler)
        {
            string path = Path.Combine(GENERATED_DATA_DIRECTORY_S, "gui_backgrounds", recipeHandler.image);
            return imageChanged("File:" + _mekaWikiItemTextGenerator.getHandlerImageName(recipeHandler), path);
        }

        public void handlerImageAdd(rootRecipeTypesRecipeType recipeHandler)
        {
            string path = Path.Combine(GENERATED_DATA_DIRECTORY_S, "gui_backgrounds", recipeHandler.image);
            uploadImage(_mekaWikiItemTextGenerator.getHandlerImageName(recipeHandler), path);
        }

        public void uploadImage(String nameInWiki, String pathToImage)
        {
            using (FileStream fileStream = File.Open(pathToImage, FileMode.Open))
            {
                uploadResult result = wiki.upload(
                    token: tokens.edittoken,
                    filename: nameInWiki,
                    file: fileStream,
                    ignorewarnings: true,
                    comment: nameInWiki
                );
            }
        }

        public void savePage(string title, string text, string summary)
        {
            var result = wiki.edit(
                token: tokens.edittoken,
                title: title,
                pageid: null,
                text: text,
                bot: true,
                summary: summary
                );
            result = wiki.edit(
                token: tokens.edittoken,
                title: title,
                pageid: null,
                text: text,
                bot: true,
                summary: "reload protect"
                );
        }

        public void editPage(string title, string text, string summary)
        {
            var result = wiki.edit(
                token: tokens.edittoken,
                title: title,
                pageid: null,
                text: text,
                bot: true,
                summary: summary
                );
        }
    }
}