using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class logeventsSelect
    {
        public long logid { get; private set; }
        public long pageid { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public logeventstype type { get; private set; }
        public string action { get; private set; }
        public bool actionhidden { get; private set; }
        public bool userhidden { get; private set; }
        public string user { get; private set; }
        public bool anon { get; private set; }
        public long? userid { get; private set; }
        public DateTime timestamp { get; private set; }
        public bool commenthidden { get; private set; }
        public string comment { get; private set; }
        public string parsedcomment { get; private set; }

        private logeventsSelect()
        {
        }

        public static logeventsSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new logeventsSelect();
            var logidValue = element.Attribute("logid");
            if (logidValue != null && logidValue.Value != "")
                result.logid = ValueParser.ParseInt64(logidValue.Value);
            var pageidValue = element.Attribute("pageid");
            if (pageidValue != null && pageidValue.Value != "")
                result.pageid = ValueParser.ParseInt64(pageidValue.Value);
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var typeValue = element.Attribute("type");
            if (typeValue != null && typeValue.Value != "")
                result.type = new logeventstype(typeValue.Value);
            var actionValue = element.Attribute("action");
            if (actionValue != null)
                result.action = ValueParser.ParseString(actionValue.Value);
            var actionhiddenValue = element.Attribute("actionhidden");
            if (actionhiddenValue != null)
                result.actionhidden = ValueParser.ParseBoolean(actionhiddenValue.Value);
            var userhiddenValue = element.Attribute("userhidden");
            if (userhiddenValue != null)
                result.userhidden = ValueParser.ParseBoolean(userhiddenValue.Value);
            var userValue = element.Attribute("user");
            if (userValue != null)
                result.user = ValueParser.ParseString(userValue.Value);
            var anonValue = element.Attribute("anon");
            if (anonValue != null)
                result.anon = ValueParser.ParseBoolean(anonValue.Value);
            var useridValue = element.Attribute("userid");
            if (useridValue != null && useridValue.Value != "")
                result.userid = ValueParser.ParseInt64(useridValue.Value);
            var timestampValue = element.Attribute("timestamp");
            if (timestampValue != null && timestampValue.Value != "")
                result.timestamp = ValueParser.ParseDateTime(timestampValue.Value);
            var commenthiddenValue = element.Attribute("commenthidden");
            if (commenthiddenValue != null)
                result.commenthidden = ValueParser.ParseBoolean(commenthiddenValue.Value);
            var commentValue = element.Attribute("comment");
            if (commentValue != null)
                result.comment = ValueParser.ParseString(commentValue.Value);
            var parsedcommentValue = element.Attribute("parsedcomment");
            if (parsedcommentValue != null)
                result.parsedcomment = ValueParser.ParseString(parsedcommentValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("logid: {0}; pageid: {1}; ns: {2}; title: {3}; type: {4}; action: {5}; actionhidden: {6}; userhidden: {7}; user: {8}; anon: {9}; userid: {10}; timestamp: {11}; commenthidden: {12}; comment: {13}; parsedcomment: {14}", logid, pageid, ns, title, type, action, actionhidden, userhidden, user, anon, userid, timestamp, commenthidden, comment, parsedcomment);
        }
    }

    public sealed class logeventsWhere
    {
        ///<summary>
        ///Filter log entries to only this type
        ///</summary>
        public logeventstype type { get; private set; }

        ///<summary>
        ///Filter log actions to only this type. Overrides letype
        ///</summary>
        public logeventsaction action { get; private set; }

        ///<summary>
        ///The timestamp to start enumerating from
        ///</summary>
        public DateTime start { get; private set; }

        ///<summary>
        ///The timestamp to end enumerating
        ///</summary>
        public DateTime end { get; private set; }

        ///<summary>
        ///Filter entries to those made by the given user
        ///</summary>
        public string user { get; private set; }

        ///<summary>
        ///Filter entries to those related to a page
        ///</summary>
        public string title { get; private set; }

        ///<summary>
        ///Filter entries that start with this prefix. Disabled in Miser Mode
        ///</summary>
        public string prefix { get; private set; }

        ///<summary>
        ///Only list event entries tagged with this tag
        ///</summary>
        public string tag { get; private set; }

        private logeventsWhere()
        {
        }
    }

    public sealed class logeventsOrderBy
    {
        private logeventsOrderBy()
        {
        }
    }
}