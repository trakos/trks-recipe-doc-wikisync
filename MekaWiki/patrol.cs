using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class patrolResult
    {
        public long rcid { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }

        private patrolResult()
        {
        }

        public static patrolResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new patrolResult();
            var rcidValue = element.Attribute("rcid");
            if (rcidValue != null && rcidValue.Value != "")
                result.rcid = ValueParser.ParseInt64(rcidValue.Value);
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
            return string.Format("rcid: {0}; ns: {1}; title: {2}", rcid, ns, title);
        }
    }
}