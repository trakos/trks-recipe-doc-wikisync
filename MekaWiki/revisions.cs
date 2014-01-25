using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class revisionsSelect : IFirst
    {
        public string rollbacktoken { get; private set; }
        public long revid { get; private set; }
        public long? parentid { get; private set; }
        public bool minor { get; private set; }
        public bool userhidden { get; private set; }
        public string user { get; private set; }
        public bool anon { get; private set; }
        public long userid { get; private set; }
        public DateTime timestamp { get; private set; }
        public int size { get; private set; }
        public string sha1 { get; private set; }
        public bool commenthidden { get; private set; }
        public string comment { get; private set; }
        public string parsedcomment { get; private set; }
        public string value { get; private set; }
        public bool texthidden { get; private set; }
        public bool textmissing { get; private set; }
        public string contentmodel { get; private set; }

        private revisionsSelect()
        {
        }

        public static revisionsSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new revisionsSelect();
            var rollbacktokenValue = element.Attribute("rollbacktoken");
            if (rollbacktokenValue != null)
                result.rollbacktoken = ValueParser.ParseString(rollbacktokenValue.Value);
            var revidValue = element.Attribute("revid");
            if (revidValue != null && revidValue.Value != "")
                result.revid = ValueParser.ParseInt64(revidValue.Value);
            var parentidValue = element.Attribute("parentid");
            if (parentidValue != null && parentidValue.Value != "")
                result.parentid = ValueParser.ParseInt64(parentidValue.Value);
            var minorValue = element.Attribute("minor");
            if (minorValue != null)
                result.minor = ValueParser.ParseBoolean(minorValue.Value);
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
            var sizeValue = element.Attribute("size");
            if (sizeValue != null && sizeValue.Value != "")
                result.size = ValueParser.ParseInt32(sizeValue.Value);
            var sha1Value = element.Attribute("sha1");
            if (sha1Value != null)
                result.sha1 = ValueParser.ParseString(sha1Value.Value);
            var commenthiddenValue = element.Attribute("commenthidden");
            if (commenthiddenValue != null)
                result.commenthidden = ValueParser.ParseBoolean(commenthiddenValue.Value);
            var commentValue = element.Attribute("comment");
            if (commentValue != null)
                result.comment = ValueParser.ParseString(commentValue.Value);
            var parsedcommentValue = element.Attribute("parsedcomment");
            if (parsedcommentValue != null)
                result.parsedcomment = ValueParser.ParseString(parsedcommentValue.Value);
            var valueValue = element;
            result.value = ValueParser.ParseString(valueValue.Value);
            var texthiddenValue = element.Attribute("texthidden");
            if (texthiddenValue != null)
                result.texthidden = ValueParser.ParseBoolean(texthiddenValue.Value);
            var textmissingValue = element.Attribute("textmissing");
            if (textmissingValue != null)
                result.textmissing = ValueParser.ParseBoolean(textmissingValue.Value);
            var contentmodelValue = element.Attribute("contentmodel");
            if (contentmodelValue != null)
                result.contentmodel = ValueParser.ParseString(contentmodelValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("rollbacktoken: {0}; revid: {1}; parentid: {2}; minor: {3}; userhidden: {4}; user: {5}; anon: {6}; userid: {7}; timestamp: {8}; size: {9}; sha1: {10}; commenthidden: {11}; comment: {12}; parsedcomment: {13}; value: {14}; texthidden: {15}; textmissing: {16}; contentmodel: {17}", rollbacktoken, revid, parentid, minor, userhidden, user, anon, userid, timestamp, size, sha1, commenthidden, comment, parsedcomment, value, texthidden, textmissing, contentmodel);
        }
    }

    public sealed class revisionsWhere
    {
        ///<summary>
        ///From which revision id to start enumeration (enum)
        ///</summary>
        public long startid { get; private set; }

        ///<summary>
        ///Stop revision enumeration on this revid (enum)
        ///</summary>
        public long endid { get; private set; }

        ///<summary>
        ///From which revision timestamp to start enumeration (enum)
        ///</summary>
        public DateTime start { get; private set; }

        ///<summary>
        ///Enumerate up to this timestamp (enum)
        ///</summary>
        public DateTime end { get; private set; }

        ///<summary>
        ///Only include revisions made by user (enum)
        ///</summary>
        public string user { get; private set; }

        ///<summary>
        ///Exclude revisions made by user (enum)
        ///</summary>
        public string excludeuser { get; private set; }

        ///<summary>
        ///Only list revisions tagged with this tag
        ///</summary>
        public string tag { get; private set; }

        ///<summary>
        ///Expand templates in revision content (requires rvprop=content)
        ///</summary>
        public bool expandtemplates { get; private set; }

        ///<summary>
        ///Generate XML parse tree for revision content (requires rvprop=content)
        ///</summary>
        public bool generatexml { get; private set; }

        ///<summary>
        ///Parse revision content (requires rvprop=content).
        ///For performance reasons if this option is used, rvlimit is enforced to 1.
        ///</summary>
        public bool parse { get; private set; }

        ///<summary>
        ///Only retrieve the content of this section number
        ///</summary>
        public string section { get; private set; }

        ///<summary>
        ///Which tokens to obtain for each revision
        ///</summary>
        public ItemOrCollection<revisionstoken> token { get; private set; }

        ///<summary>
        ///Revision ID to diff each revision to.
        ///Use "prev", "next" and "cur" for the previous, next and current revision respectively
        ///</summary>
        public string diffto { get; private set; }

        ///<summary>
        ///Text to diff each revision to. Only diffs a limited number of revisions.
        ///Overrides rvdiffto. If rvsection is set, only that section will be diffed against this text
        ///</summary>
        public string difftotext { get; private set; }

        ///<summary>
        ///Serialization format used for difftotext and expected for output of content
        ///</summary>
        public revisionscontentformat contentformat { get; private set; }

        private revisionsWhere()
        {
        }
    }

    public sealed class revisionsOrderBy
    {
        private revisionsOrderBy()
        {
        }
    }
}