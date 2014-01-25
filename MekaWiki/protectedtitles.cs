using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class protectedtitlesSelect
    {
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public DateTime timestamp { get; private set; }
        public string user { get; private set; }
        public long userid { get; private set; }
        public string comment { get; private set; }
        public string parsedcomment { get; private set; }
        public DateTime expiry { get; private set; }
        public protectedtitleslevel level { get; private set; }

        private protectedtitlesSelect()
        {
        }

        public static protectedtitlesSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new protectedtitlesSelect();
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var timestampValue = element.Attribute("timestamp");
            if (timestampValue != null && timestampValue.Value != "")
                result.timestamp = ValueParser.ParseDateTime(timestampValue.Value);
            var userValue = element.Attribute("user");
            if (userValue != null)
                result.user = ValueParser.ParseString(userValue.Value);
            var useridValue = element.Attribute("userid");
            if (useridValue != null && useridValue.Value != "")
                result.userid = ValueParser.ParseInt64(useridValue.Value);
            var commentValue = element.Attribute("comment");
            if (commentValue != null)
                result.comment = ValueParser.ParseString(commentValue.Value);
            var parsedcommentValue = element.Attribute("parsedcomment");
            if (parsedcommentValue != null)
                result.parsedcomment = ValueParser.ParseString(parsedcommentValue.Value);
            var expiryValue = element.Attribute("expiry");
            if (expiryValue != null && expiryValue.Value != "")
                result.expiry = ValueParser.ParseDateTime(expiryValue.Value);
            var levelValue = element.Attribute("level");
            if (levelValue != null && levelValue.Value != "")
                result.level = new protectedtitleslevel(levelValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("ns: {0}; title: {1}; timestamp: {2}; user: {3}; userid: {4}; comment: {5}; parsedcomment: {6}; expiry: {7}; level: {8}", ns, title, timestamp, user, userid, comment, parsedcomment, expiry, level);
        }
    }

    public sealed class protectedtitlesWhere
    {
        ///<summary>
        ///Only list titles in these namespaces
        ///</summary>
        public ItemOrCollection<Namespace> ns { get; private set; }

        ///<summary>
        ///Only list titles with these protection levels
        ///</summary>
        public ItemOrCollection<protectedtitleslevel> level { get; private set; }

        ///<summary>
        ///Start listing at this protection timestamp
        ///</summary>
        public DateTime start { get; private set; }

        ///<summary>
        ///Stop listing at this protection timestamp
        ///</summary>
        public DateTime end { get; private set; }

        private protectedtitlesWhere()
        {
        }
    }

    public sealed class protectedtitlesOrderBy
    {
        private protectedtitlesOrderBy()
        {
        }
    }
}