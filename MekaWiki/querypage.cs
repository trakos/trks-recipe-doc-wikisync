using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class querypageSelect
    {
        public string value { get; private set; }
        public DateTime? timestamp { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }

        private querypageSelect()
        {
        }

        public static querypageSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new querypageSelect();
            var valueValue = element.Attribute("value");
            if (valueValue != null)
                result.value = ValueParser.ParseString(valueValue.Value);
            var timestampValue = element.Attribute("timestamp");
            if (timestampValue != null && timestampValue.Value != "")
                result.timestamp = ValueParser.ParseDateTime(timestampValue.Value);
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("value: {0}; timestamp: {1}; ns: {2}; title: {3}", value, timestamp, ns, title);
        }
    }

    public sealed class querypageWhere
    {
        private querypageWhere()
        {
        }
    }
}