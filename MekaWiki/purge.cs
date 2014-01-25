using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class purgeResult
    {
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public long? pageid { get; private set; }
        public long? revid { get; private set; }
        public bool invalid { get; private set; }
        public bool special { get; private set; }
        public bool missing { get; private set; }
        public bool purged { get; private set; }
        public bool linkupdate { get; private set; }
        public string iw { get; private set; }

        private purgeResult()
        {
        }

        public static purgeResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new purgeResult();
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var pageidValue = element.Attribute("pageid");
            if (pageidValue != null && pageidValue.Value != "")
                result.pageid = ValueParser.ParseInt64(pageidValue.Value);
            var revidValue = element.Attribute("revid");
            if (revidValue != null && revidValue.Value != "")
                result.revid = ValueParser.ParseInt64(revidValue.Value);
            var invalidValue = element.Attribute("invalid");
            if (invalidValue != null)
                result.invalid = ValueParser.ParseBoolean(invalidValue.Value);
            var specialValue = element.Attribute("special");
            if (specialValue != null)
                result.special = ValueParser.ParseBoolean(specialValue.Value);
            var missingValue = element.Attribute("missing");
            if (missingValue != null)
                result.missing = ValueParser.ParseBoolean(missingValue.Value);
            var purgedValue = element.Attribute("purged");
            if (purgedValue != null)
                result.purged = ValueParser.ParseBoolean(purgedValue.Value);
            var linkupdateValue = element.Attribute("linkupdate");
            if (linkupdateValue != null)
                result.linkupdate = ValueParser.ParseBoolean(linkupdateValue.Value);
            var iwValue = element.Attribute("iw");
            if (iwValue != null)
                result.iw = ValueParser.ParseString(iwValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("ns: {0}; title: {1}; pageid: {2}; revid: {3}; invalid: {4}; special: {5}; missing: {6}; purged: {7}; linkupdate: {8}; iw: {9}", ns, title, pageid, revid, invalid, special, missing, purged, linkupdate, iw);
        }
    }
}