using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class watchlistSelect
    {
        public watchlisttype type { get; private set; }
        public long pageid { get; private set; }
        public long revid { get; private set; }
        public long old_revid { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public string user { get; private set; }
        public bool anon { get; private set; }
        public long userid { get; private set; }
        public bool @new { get; private set; }
        public bool minor { get; private set; }
        public bool bot { get; private set; }
        public bool patrolled { get; private set; }
        public DateTime timestamp { get; private set; }
        public int oldlen { get; private set; }
        public int newlen { get; private set; }
        public DateTime? notificationtimestamp { get; private set; }
        public string comment { get; private set; }
        public string parsedcomment { get; private set; }
        public long? logid { get; private set; }
        public watchlistlogtype logtype { get; private set; }
        public string logaction { get; private set; }

        private watchlistSelect()
        {
        }

        public static watchlistSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new watchlistSelect();
            var typeValue = element.Attribute("type");
            if (typeValue != null && typeValue.Value != "")
                result.type = new watchlisttype(typeValue.Value);
            var pageidValue = element.Attribute("pageid");
            if (pageidValue != null && pageidValue.Value != "")
                result.pageid = ValueParser.ParseInt64(pageidValue.Value);
            var revidValue = element.Attribute("revid");
            if (revidValue != null && revidValue.Value != "")
                result.revid = ValueParser.ParseInt64(revidValue.Value);
            var old_revidValue = element.Attribute("old_revid");
            if (old_revidValue != null && old_revidValue.Value != "")
                result.old_revid = ValueParser.ParseInt64(old_revidValue.Value);
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var userValue = element.Attribute("user");
            if (userValue != null)
                result.user = ValueParser.ParseString(userValue.Value);
            var anonValue = element.Attribute("anon");
            if (anonValue != null)
                result.anon = ValueParser.ParseBoolean(anonValue.Value);
            var useridValue = element.Attribute("userid");
            if (useridValue != null && useridValue.Value != "")
                result.userid = ValueParser.ParseInt64(useridValue.Value);
            var newValue = element.Attribute("new");
            if (newValue != null)
                result.@new = ValueParser.ParseBoolean(newValue.Value);
            var minorValue = element.Attribute("minor");
            if (minorValue != null)
                result.minor = ValueParser.ParseBoolean(minorValue.Value);
            var botValue = element.Attribute("bot");
            if (botValue != null)
                result.bot = ValueParser.ParseBoolean(botValue.Value);
            var patrolledValue = element.Attribute("patrolled");
            if (patrolledValue != null)
                result.patrolled = ValueParser.ParseBoolean(patrolledValue.Value);
            var timestampValue = element.Attribute("timestamp");
            if (timestampValue != null && timestampValue.Value != "")
                result.timestamp = ValueParser.ParseDateTime(timestampValue.Value);
            var oldlenValue = element.Attribute("oldlen");
            if (oldlenValue != null && oldlenValue.Value != "")
                result.oldlen = ValueParser.ParseInt32(oldlenValue.Value);
            var newlenValue = element.Attribute("newlen");
            if (newlenValue != null && newlenValue.Value != "")
                result.newlen = ValueParser.ParseInt32(newlenValue.Value);
            var notificationtimestampValue = element.Attribute("notificationtimestamp");
            if (notificationtimestampValue != null && notificationtimestampValue.Value != "")
                result.notificationtimestamp = ValueParser.ParseDateTime(notificationtimestampValue.Value);
            var commentValue = element.Attribute("comment");
            if (commentValue != null)
                result.comment = ValueParser.ParseString(commentValue.Value);
            var parsedcommentValue = element.Attribute("parsedcomment");
            if (parsedcommentValue != null)
                result.parsedcomment = ValueParser.ParseString(parsedcommentValue.Value);
            var logidValue = element.Attribute("logid");
            if (logidValue != null && logidValue.Value != "")
                result.logid = ValueParser.ParseInt64(logidValue.Value);
            var logtypeValue = element.Attribute("logtype");
            if (logtypeValue != null && logtypeValue.Value != "")
                result.logtype = new watchlistlogtype(logtypeValue.Value);
            var logactionValue = element.Attribute("logaction");
            if (logactionValue != null)
                result.logaction = ValueParser.ParseString(logactionValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("type: {0}; pageid: {1}; revid: {2}; old_revid: {3}; ns: {4}; title: {5}; user: {6}; anon: {7}; userid: {8}; new: {9}; minor: {10}; bot: {11}; patrolled: {12}; timestamp: {13}; oldlen: {14}; newlen: {15}; notificationtimestamp: {16}; comment: {17}; parsedcomment: {18}; logid: {19}; logtype: {20}; logaction: {21}", type, pageid, revid, old_revid, ns, title, user, anon, userid, @new, minor, bot, patrolled, timestamp, oldlen, newlen, notificationtimestamp, comment, parsedcomment, logid, logtype, logaction);
        }
    }

    public sealed class watchlistWhere
    {
        ///<summary>
        ///Include multiple revisions of the same page within given timeframe
        ///</summary>
        public bool allrev { get; private set; }

        ///<summary>
        ///The timestamp to start enumerating from
        ///</summary>
        public DateTime start { get; private set; }

        ///<summary>
        ///The timestamp to end enumerating
        ///</summary>
        public DateTime end { get; private set; }

        ///<summary>
        ///Filter changes to only the given namespace(s)
        ///</summary>
        public ItemOrCollection<Namespace> ns { get; private set; }

        ///<summary>
        ///Only list changes by this user
        ///</summary>
        public string user { get; private set; }

        ///<summary>
        ///Don't list changes by this user
        ///</summary>
        public string excludeuser { get; private set; }

        ///<summary>
        ///Show only items that meet this criteria.
        ///For example, to see only minor edits done by logged-in users, set wlshow=minor|!anon
        ///</summary>
        public ItemOrCollection<watchlistshow> show { get; private set; }

        ///<summary>
        ///Which types of changes to show
        /// edit           - Regular page edits
        /// external       - External changes
        /// new            - Page creations
        /// log            - Log entries
        ///</summary>
        public ItemOrCollection<watchlisttype2> type { get; private set; }

        ///<summary>
        ///The name of the user whose watchlist you'd like to access
        ///</summary>
        public string owner { get; private set; }

        ///<summary>
        ///Give a security token (settable in preferences) to allow access to another user's watchlist
        ///</summary>
        public string token { get; private set; }

        private watchlistWhere()
        {
        }
    }

    public sealed class watchlistOrderBy
    {
        private watchlistOrderBy()
        {
        }
    }
}