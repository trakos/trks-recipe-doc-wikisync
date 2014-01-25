using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class langlinksSelect
    {
        public string lang { get; private set; }
        public string url { get; private set; }
        public string value { get; private set; }

        private langlinksSelect()
        {
        }

        public static langlinksSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new langlinksSelect();
            var langValue = element.Attribute("lang");
            if (langValue != null)
                result.lang = ValueParser.ParseString(langValue.Value);
            var urlValue = element.Attribute("url");
            if (urlValue != null)
                result.url = ValueParser.ParseString(urlValue.Value);
            var valueValue = element;
            result.value = ValueParser.ParseString(valueValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("lang: {0}; url: {1}; value: {2}", lang, url, value);
        }
    }

    public sealed class langlinksWhere
    {
        ///<summary>
        ///Whether to get the full URL
        ///</summary>
        public bool url { get; private set; }

        ///<summary>
        ///Language code
        ///</summary>
        public string lang { get; private set; }

        ///<summary>
        ///Link to search for. Must be used with lllang
        ///</summary>
        public string title { get; private set; }

        private langlinksWhere()
        {
        }
    }

    public sealed class langlinksOrderBy
    {
        private langlinksOrderBy()
        {
        }
    }
}