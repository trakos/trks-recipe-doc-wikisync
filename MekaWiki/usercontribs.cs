using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class usercontribsSelect
    {
        public long userid { get; private set; }
        public string user { get; private set; }
        public bool userhidden { get; private set; }
        public long pageid { get; private set; }
        public long revid { get; private set; }
        public long? parentid { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public DateTime timestamp { get; private set; }
        public bool @new { get; private set; }
        public bool minor { get; private set; }
        public bool top { get; private set; }
        public bool commenthidden { get; private set; }
        public string comment { get; private set; }
        public string parsedcomment { get; private set; }
        public bool patrolled { get; private set; }
        public int? size { get; private set; }
        public int? sizediff { get; private set; }

        private usercontribsSelect()
        {
        }

        public static usercontribsSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new usercontribsSelect();
            var useridValue = element.Attribute("userid");
            if (useridValue != null && useridValue.Value != "")
                result.userid = ValueParser.ParseInt64(useridValue.Value);
            var userValue = element.Attribute("user");
            if (userValue != null)
                result.user = ValueParser.ParseString(userValue.Value);
            var userhiddenValue = element.Attribute("userhidden");
            if (userhiddenValue != null)
                result.userhidden = ValueParser.ParseBoolean(userhiddenValue.Value);
            var pageidValue = element.Attribute("pageid");
            if (pageidValue != null && pageidValue.Value != "")
                result.pageid = ValueParser.ParseInt64(pageidValue.Value);
            var revidValue = element.Attribute("revid");
            if (revidValue != null && revidValue.Value != "")
                result.revid = ValueParser.ParseInt64(revidValue.Value);
            var parentidValue = element.Attribute("parentid");
            if (parentidValue != null && parentidValue.Value != "")
                result.parentid = ValueParser.ParseInt64(parentidValue.Value);
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var timestampValue = element.Attribute("timestamp");
            if (timestampValue != null && timestampValue.Value != "")
                result.timestamp = ValueParser.ParseDateTime(timestampValue.Value);
            var newValue = element.Attribute("new");
            if (newValue != null)
                result.@new = ValueParser.ParseBoolean(newValue.Value);
            var minorValue = element.Attribute("minor");
            if (minorValue != null)
                result.minor = ValueParser.ParseBoolean(minorValue.Value);
            var topValue = element.Attribute("top");
            if (topValue != null)
                result.top = ValueParser.ParseBoolean(topValue.Value);
            var commenthiddenValue = element.Attribute("commenthidden");
            if (commenthiddenValue != null)
                result.commenthidden = ValueParser.ParseBoolean(commenthiddenValue.Value);
            var commentValue = element.Attribute("comment");
            if (commentValue != null)
                result.comment = ValueParser.ParseString(commentValue.Value);
            var parsedcommentValue = element.Attribute("parsedcomment");
            if (parsedcommentValue != null)
                result.parsedcomment = ValueParser.ParseString(parsedcommentValue.Value);
            var patrolledValue = element.Attribute("patrolled");
            if (patrolledValue != null)
                result.patrolled = ValueParser.ParseBoolean(patrolledValue.Value);
            var sizeValue = element.Attribute("size");
            if (sizeValue != null && sizeValue.Value != "")
                result.size = ValueParser.ParseInt32(sizeValue.Value);
            var sizediffValue = element.Attribute("sizediff");
            if (sizediffValue != null && sizediffValue.Value != "")
                result.sizediff = ValueParser.ParseInt32(sizediffValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("userid: {0}; user: {1}; userhidden: {2}; pageid: {3}; revid: {4}; parentid: {5}; ns: {6}; title: {7}; timestamp: {8}; new: {9}; minor: {10}; top: {11}; commenthidden: {12}; comment: {13}; parsedcomment: {14}; patrolled: {15}; size: {16}; sizediff: {17}", userid, user, userhidden, pageid, revid, parentid, ns, title, timestamp, @new, minor, top, commenthidden, comment, parsedcomment, patrolled, size, sizediff);
        }
    }

    public sealed class usercontribsWhere
    {
        ///<summary>
        ///The start timestamp to return from
        ///</summary>
        public DateTime start { get; private set; }

        ///<summary>
        ///The end timestamp to return to
        ///</summary>
        public DateTime end { get; private set; }

        ///<summary>
        ///The users to retrieve contributions for
        ///</summary>
        public ItemOrCollection<string> user { get; private set; }

        ///<summary>
        ///Retrieve contributions for all users whose names begin with this value. Overrides ucuser
        ///</summary>
        public string userprefix { get; private set; }

        ///<summary>
        ///Only list contributions in these namespaces
        ///</summary>
        public ItemOrCollection<Namespace> ns { get; private set; }

        ///<summary>
        ///Show only items that meet this criteria, e.g. non minor edits only: ucshow=!minor
        ///NOTE: if ucshow=patrolled or ucshow=!patrolled is set, revisions older than $wgRCMaxAge (7862400) won't be shown
        ///</summary>
        public ItemOrCollection<usercontribsshow> show { get; private set; }

        ///<summary>
        ///Only list revisions tagged with this tag
        ///</summary>
        public string tag { get; private set; }

        ///<summary>
        ///Only list changes which are the latest revision
        ///</summary>
        public bool toponly { get; private set; }

        private usercontribsWhere()
        {
        }
    }

    public sealed class usercontribsOrderBy
    {
        private usercontribsOrderBy()
        {
        }
    }
}