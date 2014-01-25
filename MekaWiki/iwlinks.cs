using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class iwlinksSelect
    {
        public string prefix { get; private set; }
        public string url { get; private set; }
        public string value { get; private set; }

        private iwlinksSelect()
        {
        }

        public static iwlinksSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new iwlinksSelect();
            var prefixValue = element.Attribute("prefix");
            if (prefixValue != null)
                result.prefix = ValueParser.ParseString(prefixValue.Value);
            var urlValue = element.Attribute("url");
            if (urlValue != null)
                result.url = ValueParser.ParseString(urlValue.Value);
            var valueValue = element;
            result.value = ValueParser.ParseString(valueValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("prefix: {0}; url: {1}; value: {2}", prefix, url, value);
        }
    }

    public sealed class iwlinksWhere
    {
        ///<summary>
        ///Whether to get the full URL
        ///</summary>
        public bool url { get; private set; }

        ///<summary>
        ///Prefix for the interwiki
        ///</summary>
        public string prefix { get; private set; }

        ///<summary>
        ///Interwiki link to search for. Must be used with iwprefix
        ///</summary>
        public string title { get; private set; }

        private iwlinksWhere()
        {
        }
    }

    public sealed class iwlinksOrderBy
    {
        private iwlinksOrderBy()
        {
        }
    }
}