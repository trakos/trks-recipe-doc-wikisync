using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using LinqToWiki.Internals;
using TrksRecipeDoc.Recipes;

namespace TrksRecipeDoc.MekaWiki
{
    internal class MekaWikiItemTextGenerator
    {
        protected RecipesProxy _recipesProxy;
        private readonly Dictionary<string, Dictionary<string, rootItemsItem>> _itemsById;
        private readonly Dictionary<string, Dictionary<string, List<rootRecipesRecipe>>> _recipesById;
        private readonly IEnumerable<rootItemsItem> _visibleItems;

        protected Regex _beginProtectRegex = new Regex("<protect>");
        protected Regex _endProtectRegex = new Regex("</protect>");

        public MekaWikiItemTextGenerator(RecipesProxy recipesProxy)
        {
            this._recipesProxy = recipesProxy;
            this._itemsById = recipesProxy.items.GroupBy(p => p.id).ToDictionary(p => p.Key, p => p.GroupBy(r => r.damage).ToDictionary(r => r.Key, r => r.Last()));
            this._recipesById = new Dictionary<string, Dictionary<string, List<rootRecipesRecipe>>>();
            this._visibleItems = recipesProxy.items.Where(p => int.Parse(p.damage) >= 0 && p.showOnList == "1").GroupBy(p => p.name).Select(p => p.Last());
            foreach (var recipe in _recipesProxy.recipes)
            {
                foreach (var item in recipe.ingredient.SelectMany(p => p.option).GroupBy(p => new { p.id, p.damage }).Select(p => p.Key))
                {
                    if (!_recipesById.ContainsKey(item.id))
                    {
                        _recipesById[item.id] = new Dictionary<string, List<rootRecipesRecipe>>();
                    }
                    if (!_recipesById[item.id].ContainsKey(item.damage))
                    {
                        _recipesById[item.id][item.damage] = new List<rootRecipesRecipe>();
                    }
                    _recipesById[item.id][item.damage].Add(recipe);
                }
            }
        }

        public string createNewItemPageText(rootItemsItem item)
        {
            String text = "";
            text += "\n\n";
            text += _printItemFirstProtectedContent(item);
            text += "\n\n";
            text += _printItemSecondProtectedContent(item);
            return text;
        }


        public string editItemPageText(string currentText, rootItemsItem item)
        {
            string text = "";
            var parts = _beginProtectRegex.Split(currentText);
            if (parts.Count() != 3)
            {
                throw new Exception("Found " + (parts.Count() - 1) + " <protected> tags for item " + item.name + ", giving up!");
            }
            text += parts[0];

            var innerParts = _endProtectRegex.Split(parts[1]);
            if (innerParts.Count() != 2)
            {
                throw new Exception("Found " + (innerParts.Count() - 1) + " </protected> tags for first <protected> in " + item.name + ", giving up!");
            }
            text += _printItemFirstProtectedContent(item);
            text += innerParts[1];

            innerParts = _endProtectRegex.Split(parts[2]);
            if (innerParts.Count() != 2)
            {
                throw new Exception("Found " + (innerParts.Count() - 1) + " </protected> tags for second <protected> in " + item.name + ", giving up!");
            }
            text += _printItemSecondProtectedContent(item);
            text += innerParts[1];

            return text;
        }

        protected string _printItemFirstProtectedContent(rootItemsItem item)
        {
            String text = "";
            text += "<protect>";
            text += String.Format("{{{{infobox|title={0}|imagearea={1}|description={2}",
                item.name,
                getItemIconName(item),
                item.description);
            if (item.attribute != null)
            {
                text = item.attribute.Aggregate(text, (current, itemAttribute) => current + String.Format("|attr_{0} = {1}", itemAttribute.key, itemAttribute.value));
            }
            text += "}}";
            foreach (rootRecipeTypesRecipeType recipeType in _recipesProxy.recipeTypes.Where(p => p.machine != null && p.machine.Any(r => r.id == item.id && r.damage == item.damage)))
            {
                text += String.Format("{0}CraftingMachine|{1}{2}", "{{", recipeType.name, "}}");
            }
            text += String.Format("[[Category:{0}]]", "items" + "/" + (item.mod == "Minecraft" ? "vanilla" : item.mod) + "/" + item.category);
            text += "</protect>";
            return text;
        }

        protected string _printItemSecondProtectedContent(rootItemsItem item)
        {
            StringBuilder text = new StringBuilder();
            text.Append("<protect>");
            text.Append("\n== Recipes ==\n");
            text.Append("{{auto}}");
            text.AppendFormat("\n=== crafting {0} ===\n", item.name);
            _printRecipesForItemByType(item, RecipesProxy.RECIPE_ITEM_TYPE_RESULT, text);
            text.AppendFormat("\n=== using {0} ===\n", item.name);
            _printRecipesForItemByType(item, RecipesProxy.RECIPE_ITEM_TYPE_INGREDIENT, text);
            text.AppendFormat("\n=== with {0} ===\n", item.name);
            _printRecipesForItemByType(item, RecipesProxy.RECIPE_ITEM_TYPE_OTHER, text);
            text.Append("<p style=\"clear:both;\"></p>");
            text.Append("{{" + item.mod + "}}");
            text.Append("</protect>");
            return text.ToString();
        }

        protected void _printRecipesForItemByType(rootItemsItem item, string type, StringBuilder stringBuilder)
        {
            foreach (var recipe in _getRecipesForItemByType(item, type))
            {
                _createRecipeText(recipe, stringBuilder);
            }
        }

        protected List<rootRecipesRecipe> _getRecipesForItem(rootItemsItem item)
        {
            Dictionary<string, List<rootRecipesRecipe>> value;
            List<rootRecipesRecipe> recipes;
            return _recipesById.TryGetValue(item.id, out value) && value.TryGetValue(item.damage, out recipes) ? recipes : new List<rootRecipesRecipe>();
        }

        protected IEnumerable<rootRecipesRecipe> _getRecipesForItemByType(rootItemsItem item, string type)
        {
            return _getRecipesForItem(item)
                .Where(p =>
                       p.visible == "1"
                       && p.ingredient.Any(r => r.type == type && r.option.Any(s => s.id == item.id && s.damage == item.damage)));
            /*return _recipesProxy.recipes
                .Where(p =>
                    p.visible == "1"
                    && p.ingredient.Any(r => r.type == type && r.option.Any(s => s.id == item.id && s.damage == item.damage))
                )
            ;*/
        }

        protected rootItemsItem _getItem(string id, string damage)
        {
            Dictionary<string, rootItemsItem> value;
            rootItemsItem item;
            return _itemsById.TryGetValue(id, out value) && value.TryGetValue(damage, out item) ? item : null;
        }

        protected void _createRecipeText(rootRecipesRecipe recipe, StringBuilder stringBuilder)
        {
            var handler = _recipesProxy.recipeTypes.First(p => p.id == recipe.handlerName);
            stringBuilder.AppendFormat("{{{{Recipe|handler={0}|handlerbg={1}", handler.name, getHandlerImageName(handler));
            int index = 0;
            foreach (rootRecipesRecipeIngredient recipeIngredient in recipe.ingredient)
            {
                foreach (rootRecipesRecipeIngredientOption recipeIngredientOption in recipeIngredient.option)
                {
                    var item = _getItem(recipeIngredientOption.id, recipeIngredientOption.damage);
                    double x = Double.Parse(recipeIngredient.x) * 2.9 + 18;
                    double y = Double.Parse(recipeIngredient.y) * 2.9 + 55;
                    stringBuilder.AppendFormat("|ing{0}={1}@{2}@{3}@{4}@{5}",
                        index++,
                        getItemIconName(item),
                        item != null ? item.name : "unknown",
                        recipeIngredient.amount != "1" || recipeIngredient.type == RecipesProxy.RECIPE_ITEM_TYPE_RESULT ? recipeIngredient.amount : "",
                        x.ToString(CultureInfo.InvariantCulture),
                        y.ToString(CultureInfo.InvariantCulture));
                }
            }
            stringBuilder.Append("}}");
        }

        public string getHandlerImageName(rootRecipeTypesRecipeType recipeHandler)
        {
            return recipeHandler.id + ".png";
        }

        public string getItemIconName(rootItemsItem item)
        {
            if (item == null)
            {
                return "no_picture.png";
            }
            return item.id + "_" + item.damage + ".png";
        }

        public string editHandlerPageText(string currentText, rootRecipeTypesRecipeType recipeHandler)
        {
            StringBuilder text = new StringBuilder();
            var parts = _beginProtectRegex.Split(currentText);
            if (parts.Count() != 3)
            {
                throw new Exception("Found " + (parts.Count() - 1) + " <protected> tags for item " + recipeHandler.name + ", giving up!");
            }
            text.Append(parts[0]);

            var innerParts = _endProtectRegex.Split(parts[1]);
            if (innerParts.Count() != 2)
            {
                throw new Exception("Found " + (innerParts.Count() - 1) + " </protected> tags for first <protected> in " + recipeHandler.name + ", giving up!");
            }
            _printRecipeFirstProtectedContent(text, recipeHandler);
            text.Append(innerParts[1]);

            innerParts = _endProtectRegex.Split(parts[2]);
            if (innerParts.Count() != 2)
            {
                throw new Exception("Found " + (innerParts.Count() - 1) + " </protected> tags for second <protected> in " + recipeHandler.name + ", giving up!");
            }
            _printRecipeSecondProtectedContent(text, recipeHandler);
            text.Append(innerParts[1]);

            return text.ToString();
        }

        public string createNewHandlerPageText(rootRecipeTypesRecipeType recipeHandler)
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine();
            _printRecipeFirstProtectedContent(text, recipeHandler);
            text.AppendLine();
            _printRecipeSecondProtectedContent(text, recipeHandler);
            text.AppendLine();
            return text.ToString();
        }

        protected void _printRecipeFirstProtectedContent(StringBuilder stringBuilder, rootRecipeTypesRecipeType recipeHandler)
        {
            stringBuilder.Append("<protect>");
            stringBuilder.Append("\n== Machines ==\n");
            stringBuilder.Append("{{auto}}");
            if (recipeHandler.machine != null)
            {
                foreach (var machine in recipeHandler.machine)
                {
                    var item = _getItem(machine.id, machine.damage);
                    stringBuilder.AppendFormat("{{{{infobox|title={0}|link={0}|imagearea={1}|description={2}|left=1",
                        item.name,
                        getItemIconName(item),
                        item.description);
                    if (item.attribute != null)
                    {
                        foreach (var itemAttribute in item.attribute)
                        {
                            stringBuilder.AppendFormat("|attr_{0} = {1}", itemAttribute.key, itemAttribute.value);
                        }
                    }
                    stringBuilder.Append("}}");
                }
            }
            stringBuilder.Append("</protect>");
        }

        protected void _printRecipeSecondProtectedContent(StringBuilder stringBuilder, rootRecipeTypesRecipeType recipeHandler)
        {
            stringBuilder.Append("<protect>");
            stringBuilder.Append("\n== Recipes ==\n");
            stringBuilder.Append("{{auto}}");
            foreach (var recipe in _recipesProxy.recipes.Where(p => p.handlerName == recipeHandler.id))
            {
                _createRecipeText(recipe, stringBuilder);
            }
            stringBuilder.Append("[[Category:recipe type]]");
            stringBuilder.Append("<p style=\"clear:both;\"></p></protect>");
        }

        public string generateItemsList(string modName)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("{{Navbox|listclass=hlist");
            stringBuilder.AppendFormat("|name={0}", modName);
            stringBuilder.AppendFormat("|title={0}", modName);
            var items = _visibleItems.Where(p => p.mod == modName);
            foreach (var result in _recipesProxy.itemCategories.Select(p => new {p.name, items = items.Where(r => r.category == p.name)}).Where(p => p.items.Any()))
            {
                stringBuilder.AppendFormat("|list_{0}=\n", result.name);
                foreach (var item in result.items)
                {
                    stringBuilder.AppendFormat("* {0}NavLink|{1}|{2}{3}\n", "{{", getItemIconName(item), item.name, "}}");
                }
            }
            stringBuilder.Append("}}");
            return stringBuilder.ToString();
        }
    }
}