using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class allcategoriesSelect
    {
        public string value { get; private set; }
        public int size { get; private set; }
        public int pages { get; private set; }
        public int files { get; private set; }
        public int subcats { get; private set; }
        public bool hidden { get; private set; }

        private allcategoriesSelect()
        {
        }

        public static allcategoriesSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new allcategoriesSelect();
            var valueValue = element;
            result.value = ValueParser.ParseString(valueValue.Value);
            var sizeValue = element.Attribute("size");
            if (sizeValue != null && sizeValue.Value != "")
                result.size = ValueParser.ParseInt32(sizeValue.Value);
            var pagesValue = element.Attribute("pages");
            if (pagesValue != null && pagesValue.Value != "")
                result.pages = ValueParser.ParseInt32(pagesValue.Value);
            var filesValue = element.Attribute("files");
            if (filesValue != null && filesValue.Value != "")
                result.files = ValueParser.ParseInt32(filesValue.Value);
            var subcatsValue = element.Attribute("subcats");
            if (subcatsValue != null && subcatsValue.Value != "")
                result.subcats = ValueParser.ParseInt32(subcatsValue.Value);
            var hiddenValue = element.Attribute("hidden");
            if (hiddenValue != null)
                result.hidden = ValueParser.ParseBoolean(hiddenValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("value: {0}; size: {1}; pages: {2}; files: {3}; subcats: {4}; hidden: {5}", value, size, pages, files, subcats, hidden);
        }
    }

    public sealed class allcategoriesWhere
    {
        ///<summary>
        ///The category to start enumerating from
        ///</summary>
        public string from { get; private set; }

        ///<summary>
        ///The category to stop enumerating at
        ///</summary>
        public string to { get; private set; }

        ///<summary>
        ///Search for all category titles that begin with this value
        ///</summary>
        public string prefix { get; private set; }

        ///<summary>
        ///Minimum number of category members
        ///</summary>
        public int min { get; private set; }

        ///<summary>
        ///Maximum number of category members
        ///</summary>
        public int max { get; private set; }

        private allcategoriesWhere()
        {
        }
    }

    public sealed class allcategoriesOrderBy
    {
        private allcategoriesOrderBy()
        {
        }
    }
}