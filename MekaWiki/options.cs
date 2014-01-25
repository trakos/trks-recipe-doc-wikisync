using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class optionsResult
    {
        public optionsvalue value { get; private set; }

        private optionsResult()
        {
        }

        public static optionsResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new optionsResult();
            var valueValue = element;
            result.value = new optionsvalue(valueValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("value: {0}", value);
        }
    }
}