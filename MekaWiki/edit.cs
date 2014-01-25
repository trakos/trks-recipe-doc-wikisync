using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class editResult
    {
        public bool @new { get; private set; }
        public editresult result { get; private set; }
        public long? pageid { get; private set; }
        public string title { get; private set; }
        public bool nochange { get; private set; }
        public long? oldrevid { get; private set; }
        public long? newrevid { get; private set; }
        public string newtimestamp { get; private set; }

        private editResult()
        {
        }

        public static editResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new editResult();
            var newValue = element.Attribute("new");
            if (newValue != null)
                result.@new = ValueParser.ParseBoolean(newValue.Value);
            var resultValue = element.Attribute("result");
            if (resultValue != null && resultValue.Value != "")
                result.result = new editresult(resultValue.Value);
            var pageidValue = element.Attribute("pageid");
            if (pageidValue != null && pageidValue.Value != "")
                result.pageid = ValueParser.ParseInt64(pageidValue.Value);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var nochangeValue = element.Attribute("nochange");
            if (nochangeValue != null)
                result.nochange = ValueParser.ParseBoolean(nochangeValue.Value);
            var oldrevidValue = element.Attribute("oldrevid");
            if (oldrevidValue != null && oldrevidValue.Value != "")
                result.oldrevid = ValueParser.ParseInt64(oldrevidValue.Value);
            var newrevidValue = element.Attribute("newrevid");
            if (newrevidValue != null && newrevidValue.Value != "")
                result.newrevid = ValueParser.ParseInt64(newrevidValue.Value);
            var newtimestampValue = element.Attribute("newtimestamp");
            if (newtimestampValue != null)
                result.newtimestamp = ValueParser.ParseString(newtimestampValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("new: {0}; result: {1}; pageid: {2}; title: {3}; nochange: {4}; oldrevid: {5}; newrevid: {6}; newtimestamp: {7}", @new, result, pageid, title, nochange, oldrevid, newrevid, newtimestamp);
        }
    }
}