using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class importResult
    {
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public int revisions { get; private set; }

        private importResult()
        {
        }

        public static importResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new importResult();
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var revisionsValue = element.Attribute("revisions");
            if (revisionsValue != null && revisionsValue.Value != "")
                result.revisions = ValueParser.ParseInt32(revisionsValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("ns: {0}; title: {1}; revisions: {2}", ns, title, revisions);
        }
    }
}