using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class deleteResult
    {
        public string title { get; private set; }
        public string reason { get; private set; }
        public long logid { get; private set; }

        private deleteResult()
        {
        }

        public static deleteResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new deleteResult();
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var reasonValue = element.Attribute("reason");
            if (reasonValue != null)
                result.reason = ValueParser.ParseString(reasonValue.Value);
            var logidValue = element.Attribute("logid");
            if (logidValue != null && logidValue.Value != "")
                result.logid = ValueParser.ParseInt64(logidValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("title: {0}; reason: {1}; logid: {2}", title, reason, logid);
        }
    }
}