using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class protectResult
    {
        public string title { get; private set; }
        public string reason { get; private set; }
        public bool cascade { get; private set; }

        private protectResult()
        {
        }

        public static protectResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new protectResult();
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var reasonValue = element.Attribute("reason");
            if (reasonValue != null)
                result.reason = ValueParser.ParseString(reasonValue.Value);
            var cascadeValue = element.Attribute("cascade");
            if (cascadeValue != null)
                result.cascade = ValueParser.ParseBoolean(cascadeValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("title: {0}; reason: {1}; cascade: {2}", title, reason, cascade);
        }
    }
}