using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class expandtemplatesResult
    {
        public string value { get; private set; }

        private expandtemplatesResult()
        {
        }

        public static expandtemplatesResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new expandtemplatesResult();
            var valueValue = element;
            result.value = ValueParser.ParseString(valueValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("value: {0}", value);
        }
    }
}