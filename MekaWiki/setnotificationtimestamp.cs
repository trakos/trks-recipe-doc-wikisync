using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class setnotificationtimestampResult
    {
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public long? pageid { get; private set; }
        public long? revid { get; private set; }
        public bool invalid { get; private set; }
        public bool missing { get; private set; }
        public bool notwatched { get; private set; }
        public DateTime? notificationtimestamp { get; private set; }

        private setnotificationtimestampResult()
        {
        }

        public static setnotificationtimestampResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new setnotificationtimestampResult();
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
            var missingValue = element.Attribute("missing");
            if (missingValue != null)
                result.missing = ValueParser.ParseBoolean(missingValue.Value);
            var notwatchedValue = element.Attribute("notwatched");
            if (notwatchedValue != null)
                result.notwatched = ValueParser.ParseBoolean(notwatchedValue.Value);
            var notificationtimestampValue = element.Attribute("notificationtimestamp");
            if (notificationtimestampValue != null && notificationtimestampValue.Value != "")
                result.notificationtimestamp = ValueParser.ParseDateTime(notificationtimestampValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("ns: {0}; title: {1}; pageid: {2}; revid: {3}; invalid: {4}; missing: {5}; notwatched: {6}; notificationtimestamp: {7}", ns, title, pageid, revid, invalid, missing, notwatched, notificationtimestamp);
        }
    }
}