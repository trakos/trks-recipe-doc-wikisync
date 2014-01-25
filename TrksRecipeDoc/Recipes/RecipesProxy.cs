using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace TrksRecipeDoc.Recipes
{
    class RecipesProxy
    {
        public const String RECIPE_ITEM_TYPE_INGREDIENT = "ingredient";
        public const String RECIPE_ITEM_TYPE_OTHER = "other";
        public const String RECIPE_ITEM_TYPE_RESULT = "result";

        protected Recipes.root _recipesRoot;
        protected IEnumerable<string> _mods;
        public IEnumerable<string> mods { get { return _mods; } }

        public RecipesProxy(Recipes.root recipesRoot)
        {
            this._recipesRoot = recipesRoot;
            this._mods = this.items.GroupBy(p => p.mod).Select(p => p.Key);
        }

        public T getField<T>()
        {
            foreach (var element in _recipesRoot.Items)
            {
                if (element is T)
                {
                    return (T)element;
                }
            }
            throw new InstanceNotFoundException();
        }

        public rootItemCategoriesCategory[] itemCategories
        {
            get
            {
                return getField<rootItemCategories>().category;
            }
        }

        public rootItemsItem[] items
        {
            get
            {
                return getField<rootItems>().item;
            }
        }

        public rootRecipeTypesRecipeType[] recipeTypes
        {
            get
            {
                return getField<rootRecipeTypes>().recipeType;
            }
        }

        public rootRecipesRecipe[] recipes
        {
            get
            {
                return getField<rootRecipes>().recipe;
            }
        }
    }
}
