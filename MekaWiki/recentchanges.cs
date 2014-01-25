using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class recentchangesSelect
    {
        public recentchangestype type { get; private set; }
        public string patroltoken { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public Namespace new_ns { get; private set; }
        public string new_title { get; private set; }
        public long rcid { get; private set; }
        public long pageid { get; private set; }
        public long revid { get; private set; }
        public long old_revid { get; private set; }
        public string user { get; private set; }
        public bool anon { get; private set; }
        public long userid { get; private set; }
        public bool bot { get; private set; }
        public bool @new { get; private set; }
        public bool minor { get; private set; }
        public int oldlen { get; private set; }
        public int newlen { get; private set; }
        public DateTime timestamp { get; private set; }
        public string comment { get; private set; }
        public string parsedcomment { get; private set; }
        public bool redirect { get; private set; }
        public bool patrolled { get; private set; }
        public long? logid { get; private set; }
        public recentchangeslogtype logtype { get; private set; }
        public string logaction { get; private set; }
        public string sha1 { get; private set; }
        public bool? sha1hidden { get; private set; }

        private recentchangesSelect()
        {
        }

        public static recentchangesSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new recentchangesSelect();
            var typeValue = element.Attribute("type");
            if (typeValue != null && typeValue.Value != "")
                result.type = new recentchangestype(typeValue.Value);
            var patroltokenValue = element.Attribute("patroltoken");
            if (patroltokenValue != null)
                result.patroltoken = ValueParser.ParseString(patroltokenValue.Value);
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var new_nsValue = element.Attribute("new_ns");
            if (new_nsValue != null && new_nsValue.Value != "")
                result.new_ns = ValueParser.ParseNamespace(new_nsValue.Value, wiki);
            var new_titleValue = element.Attribute("new_title");
            if (new_titleValue != null)
                result.new_title = ValueParser.ParseString(new_titleValue.Value);
            var rcidValue = element.Attribute("rcid");
            if (rcidValue != null && rcidValue.Value != "")
                result.rcid = ValueParser.ParseInt64(rcidValue.Value);
            var pageidValue = element.Attribute("pageid");
            if (pageidValue != null && pageidValue.Value != "")
                result.pageid = ValueParser.ParseInt64(pageidValue.Value);
            var revidValue = element.Attribute("revid");
            if (revidValue != null && revidValue.Value != "")
                result.revid = ValueParser.ParseInt64(revidValue.Value);
            var old_revidValue = element.Attribute("old_revid");
            if (old_revidValue != null && old_revidValue.Value != "")
                result.old_revid = ValueParser.ParseInt64(old_revidValue.Value);
            var userValue = element.Attribute("user");
            if (userValue != null)
                result.user = ValueParser.ParseString(userValue.Value);
            var anonValue = element.Attribute("anon");
            if (anonValue != null)
                result.anon = ValueParser.ParseBoolean(anonValue.Value);
            var useridValue = element.Attribute("userid");
            if (useridValue != null && useridValue.Value != "")
                result.userid = ValueParser.ParseInt64(useridValue.Value);
            var botValue = element.Attribute("bot");
            if (botValue != null)
                result.bot = ValueParser.ParseBoolean(botValue.Value);
            var newValue = element.Attribute("new");
            if (newValue != null)
                result.@new = ValueParser.ParseBoolean(newValue.Value);
            var minorValue = element.Attribute("minor");
            if (minorValue != null)
                result.minor = ValueParser.ParseBoolean(minorValue.Value);
            var oldlenValue = element.Attribute("oldlen");
            if (oldlenValue != null && oldlenValue.Value != "")
                result.oldlen = ValueParser.ParseInt32(oldlenValue.Value);
            var newlenValue = element.Attribute("newlen");
            if (newlenValue != null && newlenValue.Value != "")
                result.newlen = ValueParser.ParseInt32(newlenValue.Value);
            var timestampValue = element.Attribute("timestamp");
            if (timestampValue != null && timestampValue.Value != "")
                result.timestamp = ValueParser.ParseDateTime(timestampValue.Value);
            var commentValue = element.Attribute("comment");
            if (commentValue != null)
                result.comment = ValueParser.ParseString(commentValue.Value);
            var parsedcommentValue = element.Attribute("parsedcomment");
            if (parsedcommentValue != null)
                result.parsedcomment = ValueParser.ParseString(parsedcommentValue.Value);
            var redirectValue = element.Attribute("redirect");
            if (redirectValue != null)
                result.redirect = ValueParser.ParseBoolean(redirectValue.Value);
            var patrolledValue = element.Attribute("patrolled");
            if (patrolledValue != null)
                result.patrolled = ValueParser.ParseBoolean(patrolledValue.Value);
            var logidValue = element.Attribute("logid");
            if (logidValue != null && logidValue.Value != "")
                result.logid = ValueParser.ParseInt64(logidValue.Value);
            var logtypeValue = element.Attribute("logtype");
            if (logtypeValue != null && logtypeValue.Value != "")
                result.logtype = new recentchangeslogtype(logtypeValue.Value);
            var logactionValue = element.Attribute("logaction");
            if (logactionValue != null)
                result.logaction = ValueParser.ParseString(logactionValue.Value);
            var sha1Value = element.Attribute("sha1");
            if (sha1Value != null)
                result.sha1 = ValueParser.ParseString(sha1Value.Value);
            var sha1hiddenValue = element.Attribute("sha1hidden");
            if (sha1hiddenValue != null)
                result.sha1hidden = ValueParser.ParseBoolean(sha1hiddenValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("type: {0}; patroltoken: {1}; ns: {2}; title: {3}; new_ns: {4}; new_title: {5}; rcid: {6}; pageid: {7}; revid: {8}; old_revid: {9}; user: {10}; anon: {11}; userid: {12}; bot: {13}; new: {14}; minor: {15}; oldlen: {16}; newlen: {17}; timestamp: {18}; comment: {19}; parsedcomment: {20}; redirect: {21}; patrolled: {22}; logid: {23}; logtype: {24}; logaction: {25}; sha1: {26}; sha1hidden: {27}", type, patroltoken, ns, title, new_ns, new_title, rcid, pageid, revid, old_revid, user, anon, userid, bot, @new, minor, oldlen, newlen, timestamp, comment, parsedcomment, redirect, patrolled, logid, logtype, logaction, sha1, sha1hidden);
        }
    }

    public sealed class recentchangesWhere
    {
        ///<summary>
        ///The timestamp to start enumerating from
        ///</summary>
        public DateTime start { get; private set; }

        ///<summary>
        ///The timestamp to end enumerating
        ///</summary>
        public DateTime end { get; private set; }

        ///<summary>
        ///Filter log entries to only this namespace(s)
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
        ///Only list changes tagged with this tag
        ///</summary>
        public string tag { get; private set; }

        ///<summary>
        ///Which tokens to obtain for each change
        ///</summary>
        public ItemOrCollection<recentchangestoken> token { get; private set; }

        ///<summary>
        ///Show only items that meet this criteria.
        ///For example, to see only minor edits done by logged-in users, set rcshow=minor|!anon
        ///</summary>
        public ItemOrCollection<recentchangesshow> show { get; private set; }

        ///<summary>
        ///Which types of changes to show
        ///</summary>
        public ItemOrCollection<recentchangestype2> type { get; private set; }

        ///<summary>
        ///Only list changes which are the latest revision
        ///</summary>
        public bool toponly { get; private set; }

        private recentchangesWhere()
        {
        }
    }

    public sealed class recentchangesOrderBy
    {
        private recentchangesOrderBy()
        {
        }
    }
}