using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class categoryinfoResult
    {
        public int size { get; private set; }
        public int pages { get; private set; }
        public int files { get; private set; }
        public int subcats { get; private set; }
        public bool hidden { get; private set; }

        private categoryinfoResult()
        {
        }

        public static categoryinfoResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new categoryinfoResult();
            var sizeValue = element.Attribute("size");
            if (sizeValue != null && sizeValue.Value != "")
                result.size = ValueParser.ParseInt32(sizeValue.Value);
            var pagesValue = element.Attribute("pages");
            if (pagesValue != null && pagesValue.Value != "")
                result.pages = ValueParser.ParseInt32(pagesValue.Value);
            var filesValue = element.Attribute("files");
            if (filesValue != null && filesValue.Value != "")
                result.files = ValueParser.ParseInt32(filesValue.Value);
            var subcatsValue = element.Attribute("subcats");
            if (subcatsValue != null && subcatsValue.Value != "")
                result.subcats = ValueParser.ParseInt32(subcatsValue.Value);
            var hiddenValue = element.Attribute("hidden");
            if (hiddenValue != null)
                result.hidden = ValueParser.ParseBoolean(hiddenValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("size: {0}; pages: {1}; files: {2}; subcats: {3}; hidden: {4}", size, pages, files, subcats, hidden);
        }
    }
}