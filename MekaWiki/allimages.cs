using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class allimagesSelect
    {
        public string name { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public DateTime timestamp { get; private set; }
        public bool userhidden { get; private set; }
        public string user { get; private set; }
        public bool anon { get; private set; }
        public long userid { get; private set; }
        public int size { get; private set; }
        public int width { get; private set; }
        public int height { get; private set; }
        public int? pagecount { get; private set; }
        public bool commenthidden { get; private set; }
        public string comment { get; private set; }
        public string parsedcomment { get; private set; }
        public bool filehidden { get; private set; }
        public string thumburl { get; private set; }
        public int? thumbwidth { get; private set; }
        public int? thumbheight { get; private set; }
        public string thumberror { get; private set; }
        public string url { get; private set; }
        public string descriptionurl { get; private set; }
        public string sha1 { get; private set; }
        public string mime { get; private set; }
        public string mediatype { get; private set; }
        public int? bitdepth { get; private set; }

        private allimagesSelect()
        {
        }

        public static allimagesSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new allimagesSelect();
            var nameValue = element.Attribute("name");
            if (nameValue != null)
                result.name = ValueParser.ParseString(nameValue.Value);
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var timestampValue = element.Attribute("timestamp");
            if (timestampValue != null && timestampValue.Value != "")
                result.timestamp = ValueParser.ParseDateTime(timestampValue.Value);
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
            var sizeValue = element.Attribute("size");
            if (sizeValue != null && sizeValue.Value != "")
                result.size = ValueParser.ParseInt32(sizeValue.Value);
            var widthValue = element.Attribute("width");
            if (widthValue != null && widthValue.Value != "")
                result.width = ValueParser.ParseInt32(widthValue.Value);
            var heightValue = element.Attribute("height");
            if (heightValue != null && heightValue.Value != "")
                result.height = ValueParser.ParseInt32(heightValue.Value);
            var pagecountValue = element.Attribute("pagecount");
            if (pagecountValue != null && pagecountValue.Value != "")
                result.pagecount = ValueParser.ParseInt32(pagecountValue.Value);
            var commenthiddenValue = element.Attribute("commenthidden");
            if (commenthiddenValue != null)
                result.commenthidden = ValueParser.ParseBoolean(commenthiddenValue.Value);
            var commentValue = element.Attribute("comment");
            if (commentValue != null)
                result.comment = ValueParser.ParseString(commentValue.Value);
            var parsedcommentValue = element.Attribute("parsedcomment");
            if (parsedcommentValue != null)
                result.parsedcomment = ValueParser.ParseString(parsedcommentValue.Value);
            var filehiddenValue = element.Attribute("filehidden");
            if (filehiddenValue != null)
                result.filehidden = ValueParser.ParseBoolean(filehiddenValue.Value);
            var thumburlValue = element.Attribute("thumburl");
            if (thumburlValue != null)
                result.thumburl = ValueParser.ParseString(thumburlValue.Value);
            var thumbwidthValue = element.Attribute("thumbwidth");
            if (thumbwidthValue != null && thumbwidthValue.Value != "")
                result.thumbwidth = ValueParser.ParseInt32(thumbwidthValue.Value);
            var thumbheightValue = element.Attribute("thumbheight");
            if (thumbheightValue != null && thumbheightValue.Value != "")
                result.thumbheight = ValueParser.ParseInt32(thumbheightValue.Value);
            var thumberrorValue = element.Attribute("thumberror");
            if (thumberrorValue != null)
                result.thumberror = ValueParser.ParseString(thumberrorValue.Value);
            var urlValue = element.Attribute("url");
            if (urlValue != null)
                result.url = ValueParser.ParseString(urlValue.Value);
            var descriptionurlValue = element.Attribute("descriptionurl");
            if (descriptionurlValue != null)
                result.descriptionurl = ValueParser.ParseString(descriptionurlValue.Value);
            var sha1Value = element.Attribute("sha1");
            if (sha1Value != null)
                result.sha1 = ValueParser.ParseString(sha1Value.Value);
            var mimeValue = element.Attribute("mime");
            if (mimeValue != null)
                result.mime = ValueParser.ParseString(mimeValue.Value);
            var mediatypeValue = element.Attribute("mediatype");
            if (mediatypeValue != null)
                result.mediatype = ValueParser.ParseString(mediatypeValue.Value);
            var bitdepthValue = element.Attribute("bitdepth");
            if (bitdepthValue != null && bitdepthValue.Value != "")
                result.bitdepth = ValueParser.ParseInt32(bitdepthValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("name: {0}; ns: {1}; title: {2}; timestamp: {3}; userhidden: {4}; user: {5}; anon: {6}; userid: {7}; size: {8}; width: {9}; height: {10}; pagecount: {11}; commenthidden: {12}; comment: {13}; parsedcomment: {14}; filehidden: {15}; thumburl: {16}; thumbwidth: {17}; thumbheight: {18}; thumberror: {19}; url: {20}; descriptionurl: {21}; sha1: {22}; mime: {23}; mediatype: {24}; bitdepth: {25}", name, ns, title, timestamp, userhidden, user, anon, userid, size, width, height, pagecount, commenthidden, comment, parsedcomment, filehidden, thumburl, thumbwidth, thumbheight, thumberror, url, descriptionurl, sha1, mime, mediatype, bitdepth);
        }
    }

    public sealed class allimagesWhere
    {
        ///<summary>
        ///The image title to start enumerating from. Can only be used with aisort=name
        ///</summary>
        public string from { get; private set; }

        ///<summary>
        ///The image title to stop enumerating at. Can only be used with aisort=name
        ///</summary>
        public string to { get; private set; }

        ///<summary>
        ///The timestamp to start enumerating from. Can only be used with aisort=timestamp
        ///</summary>
        public DateTime start { get; private set; }

        ///<summary>
        ///The timestamp to end enumerating. Can only be used with aisort=timestamp
        ///</summary>
        public DateTime end { get; private set; }

        ///<summary>
        ///Search for all image titles that begin with this value. Can only be used with aisort=name
        ///</summary>
        public string prefix { get; private set; }

        ///<summary>
        ///Limit to images with at least this many bytes
        ///</summary>
        public int minsize { get; private set; }

        ///<summary>
        ///Limit to images with at most this many bytes
        ///</summary>
        public int maxsize { get; private set; }

        ///<summary>
        ///SHA1 hash of image. Overrides aisha1base36
        ///</summary>
        public string sha1 { get; private set; }

        ///<summary>
        ///SHA1 hash of image in base 36 (used in MediaWiki)
        ///</summary>
        public string sha1base36 { get; private set; }

        ///<summary>
        ///Only return files uploaded by this user. Can only be used with aisort=timestamp. Cannot be used together with aifilterbots
        ///</summary>
        public string user { get; private set; }

        ///<summary>
        ///How to filter files uploaded by bots. Can only be used with aisort=timestamp. Cannot be used together with aiuser
        ///</summary>
        public allimagesfilterbots filterbots { get; private set; }

        ///<summary>
        ///What MIME type to search for. e.g. image/jpeg. Disabled in Miser Mode
        ///</summary>
        public string mime { get; private set; }

        private allimagesWhere()
        {
        }
    }

    public sealed class allimagesOrderBy
    {
        public string name { get; private set; }
        public DateTime timestamp { get; private set; }

        private allimagesOrderBy()
        {
        }
    }
}