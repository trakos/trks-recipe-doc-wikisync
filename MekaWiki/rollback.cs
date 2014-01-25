using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class rollbackResult
    {
        public string title { get; private set; }
        public long pageid { get; private set; }
        public string summary { get; private set; }
        public long revid { get; private set; }
        public long old_revid { get; private set; }
        public long last_revid { get; private set; }

        private rollbackResult()
        {
        }

        public static rollbackResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new rollbackResult();
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var pageidValue = element.Attribute("pageid");
            if (pageidValue != null && pageidValue.Value != "")
                result.pageid = ValueParser.ParseInt64(pageidValue.Value);
            var summaryValue = element.Attribute("summary");
            if (summaryValue != null)
                result.summary = ValueParser.ParseString(summaryValue.Value);
            var revidValue = element.Attribute("revid");
            if (revidValue != null && revidValue.Value != "")
                result.revid = ValueParser.ParseInt64(revidValue.Value);
            var old_revidValue = element.Attribute("old_revid");
            if (old_revidValue != null && old_revidValue.Value != "")
                result.old_revid = ValueParser.ParseInt64(old_revidValue.Value);
            var last_revidValue = element.Attribute("last_revid");
            if (last_revidValue != null && last_revidValue.Value != "")
                result.last_revid = ValueParser.ParseInt64(last_revidValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("title: {0}; pageid: {1}; summary: {2}; revid: {3}; old_revid: {4}; last_revid: {5}", title, pageid, summary, revid, old_revid, last_revid);
        }
    }
}