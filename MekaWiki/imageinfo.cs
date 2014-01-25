using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class imageinfoSelect
    {
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
        public string thumbmime { get; private set; }
        public string mediatype { get; private set; }
        public string archivename { get; private set; }
        public int? bitdepth { get; private set; }

        private imageinfoSelect()
        {
        }

        public static imageinfoSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new imageinfoSelect();
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
            var thumbmimeValue = element.Attribute("thumbmime");
            if (thumbmimeValue != null)
                result.thumbmime = ValueParser.ParseString(thumbmimeValue.Value);
            var mediatypeValue = element.Attribute("mediatype");
            if (mediatypeValue != null)
                result.mediatype = ValueParser.ParseString(mediatypeValue.Value);
            var archivenameValue = element.Attribute("archivename");
            if (archivenameValue != null)
                result.archivename = ValueParser.ParseString(archivenameValue.Value);
            var bitdepthValue = element.Attribute("bitdepth");
            if (bitdepthValue != null && bitdepthValue.Value != "")
                result.bitdepth = ValueParser.ParseInt32(bitdepthValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("timestamp: {0}; userhidden: {1}; user: {2}; anon: {3}; userid: {4}; size: {5}; width: {6}; height: {7}; pagecount: {8}; commenthidden: {9}; comment: {10}; parsedcomment: {11}; filehidden: {12}; thumburl: {13}; thumbwidth: {14}; thumbheight: {15}; thumberror: {16}; url: {17}; descriptionurl: {18}; sha1: {19}; mime: {20}; thumbmime: {21}; mediatype: {22}; archivename: {23}; bitdepth: {24}", timestamp, userhidden, user, anon, userid, size, width, height, pagecount, commenthidden, comment, parsedcomment, filehidden, thumburl, thumbwidth, thumbheight, thumberror, url, descriptionurl, sha1, mime, thumbmime, mediatype, archivename, bitdepth);
        }
    }

    public sealed class imageinfoWhere
    {
        ///<summary>
        ///Timestamp to start listing from
        ///</summary>
        public DateTime start { get; private set; }

        ///<summary>
        ///Timestamp to stop listing at
        ///</summary>
        public DateTime end { get; private set; }

        ///<summary>
        ///If iiprop=url is set, a URL to an image scaled to this width will be returned.
        ///For performance reasons if this option is used, no more than 50 scaled images will be returned.
        ///</summary>
        public int urlwidth { get; private set; }

        ///<summary>
        ///Similar to iiurlwidth.
        ///</summary>
        public int urlheight { get; private set; }

        ///<summary>
        ///Version of metadata to use. if 'latest' is specified, use latest version.
        ///Defaults to '1' for backwards compatibility
        ///</summary>
        public string metadataversion { get; private set; }

        ///<summary>
        ///A handler specific parameter string. For example, pdf's
        ///might use 'page15-100px'. iiurlwidth must be used and be consistent with iiurlparam
        ///</summary>
        public string urlparam { get; private set; }

        ///<summary>
        ///Look only for files in the local repository
        ///</summary>
        public bool localonly { get; private set; }

        private imageinfoWhere()
        {
        }
    }
}