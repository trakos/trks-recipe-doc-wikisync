using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class filearchiveSelect
    {
        public string name { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public bool filehidden { get; private set; }
        public bool commenthidden { get; private set; }
        public bool userhidden { get; private set; }
        public bool suppressed { get; private set; }
        public string sha1 { get; private set; }
        public DateTime timestamp { get; private set; }
        public long userid { get; private set; }
        public string user { get; private set; }
        public int size { get; private set; }
        public int? pagecount { get; private set; }
        public int height { get; private set; }
        public int width { get; private set; }
        public string description { get; private set; }
        public string parseddescription { get; private set; }
        public string metadata { get; private set; }
        public int bitdepth { get; private set; }
        public string mime { get; private set; }
        public string mediatype { get; private set; }
        public string archivename { get; private set; }

        private filearchiveSelect()
        {
        }

        public static filearchiveSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new filearchiveSelect();
            var nameValue = element.Attribute("name");
            if (nameValue != null)
                result.name = ValueParser.ParseString(nameValue.Value);
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var filehiddenValue = element.Attribute("filehidden");
            if (filehiddenValue != null)
                result.filehidden = ValueParser.ParseBoolean(filehiddenValue.Value);
            var commenthiddenValue = element.Attribute("commenthidden");
            if (commenthiddenValue != null)
                result.commenthidden = ValueParser.ParseBoolean(commenthiddenValue.Value);
            var userhiddenValue = element.Attribute("userhidden");
            if (userhiddenValue != null)
                result.userhidden = ValueParser.ParseBoolean(userhiddenValue.Value);
            var suppressedValue = element.Attribute("suppressed");
            if (suppressedValue != null)
                result.suppressed = ValueParser.ParseBoolean(suppressedValue.Value);
            var sha1Value = element.Attribute("sha1");
            if (sha1Value != null)
                result.sha1 = ValueParser.ParseString(sha1Value.Value);
            var timestampValue = element.Attribute("timestamp");
            if (timestampValue != null && timestampValue.Value != "")
                result.timestamp = ValueParser.ParseDateTime(timestampValue.Value);
            var useridValue = element.Attribute("userid");
            if (useridValue != null && useridValue.Value != "")
                result.userid = ValueParser.ParseInt64(useridValue.Value);
            var userValue = element.Attribute("user");
            if (userValue != null)
                result.user = ValueParser.ParseString(userValue.Value);
            var sizeValue = element.Attribute("size");
            if (sizeValue != null && sizeValue.Value != "")
                result.size = ValueParser.ParseInt32(sizeValue.Value);
            var pagecountValue = element.Attribute("pagecount");
            if (pagecountValue != null && pagecountValue.Value != "")
                result.pagecount = ValueParser.ParseInt32(pagecountValue.Value);
            var heightValue = element.Attribute("height");
            if (heightValue != null && heightValue.Value != "")
                result.height = ValueParser.ParseInt32(heightValue.Value);
            var widthValue = element.Attribute("width");
            if (widthValue != null && widthValue.Value != "")
                result.width = ValueParser.ParseInt32(widthValue.Value);
            var descriptionValue = element.Attribute("description");
            if (descriptionValue != null)
                result.description = ValueParser.ParseString(descriptionValue.Value);
            var parseddescriptionValue = element.Attribute("parseddescription");
            if (parseddescriptionValue != null)
                result.parseddescription = ValueParser.ParseString(parseddescriptionValue.Value);
            var metadataValue = element.Attribute("metadata");
            if (metadataValue != null)
                result.metadata = ValueParser.ParseString(metadataValue.Value);
            var bitdepthValue = element.Attribute("bitdepth");
            if (bitdepthValue != null && bitdepthValue.Value != "")
                result.bitdepth = ValueParser.ParseInt32(bitdepthValue.Value);
            var mimeValue = element.Attribute("mime");
            if (mimeValue != null)
                result.mime = ValueParser.ParseString(mimeValue.Value);
            var mediatypeValue = element.Attribute("mediatype");
            if (mediatypeValue != null)
                result.mediatype = ValueParser.ParseString(mediatypeValue.Value);
            var archivenameValue = element.Attribute("archivename");
            if (archivenameValue != null)
                result.archivename = ValueParser.ParseString(archivenameValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("name: {0}; ns: {1}; title: {2}; filehidden: {3}; commenthidden: {4}; userhidden: {5}; suppressed: {6}; sha1: {7}; timestamp: {8}; userid: {9}; user: {10}; size: {11}; pagecount: {12}; height: {13}; width: {14}; description: {15}; parseddescription: {16}; metadata: {17}; bitdepth: {18}; mime: {19}; mediatype: {20}; archivename: {21}", name, ns, title, filehidden, commenthidden, userhidden, suppressed, sha1, timestamp, userid, user, size, pagecount, height, width, description, parseddescription, metadata, bitdepth, mime, mediatype, archivename);
        }
    }

    public sealed class filearchiveWhere
    {
        ///<summary>
        ///The image title to start enumerating from
        ///</summary>
        public string from { get; private set; }

        ///<summary>
        ///The image title to stop enumerating at
        ///</summary>
        public string to { get; private set; }

        ///<summary>
        ///Search for all image titles that begin with this value
        ///</summary>
        public string prefix { get; private set; }

        ///<summary>
        ///SHA1 hash of image. Overrides fasha1base36
        ///</summary>
        public string sha1 { get; private set; }

        ///<summary>
        ///SHA1 hash of image in base 36 (used in MediaWiki)
        ///</summary>
        public string sha1base36 { get; private set; }

        private filearchiveWhere()
        {
        }
    }

    public sealed class filearchiveOrderBy
    {
        private filearchiveOrderBy()
        {
        }
    }
}