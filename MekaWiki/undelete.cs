using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class undeleteResult
    {
        public string title { get; private set; }
        public int revisions { get; private set; }
        public int filerevisions { get; private set; }
        public string reason { get; private set; }

        private undeleteResult()
        {
        }

        public static undeleteResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new undeleteResult();
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var revisionsValue = element.Attribute("revisions");
            if (revisionsValue != null && revisionsValue.Value != "")
                result.revisions = ValueParser.ParseInt32(revisionsValue.Value);
            var filerevisionsValue = element.Attribute("filerevisions");
            if (filerevisionsValue != null && filerevisionsValue.Value != "")
                result.filerevisions = ValueParser.ParseInt32(filerevisionsValue.Value);
            var reasonValue = element.Attribute("reason");
            if (reasonValue != null)
                result.reason = ValueParser.ParseString(reasonValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("title: {0}; revisions: {1}; filerevisions: {2}; reason: {3}", title, revisions, filerevisions, reason);
        }
    }
}