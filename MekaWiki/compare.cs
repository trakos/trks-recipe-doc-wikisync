using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class compareResult
    {
        public string fromtitle { get; private set; }
        public long fromrevid { get; private set; }
        public string totitle { get; private set; }
        public long torevid { get; private set; }
        public string value { get; private set; }

        private compareResult()
        {
        }

        public static compareResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new compareResult();
            var fromtitleValue = element.Attribute("fromtitle");
            if (fromtitleValue != null)
                result.fromtitle = ValueParser.ParseString(fromtitleValue.Value);
            var fromrevidValue = element.Attribute("fromrevid");
            if (fromrevidValue != null && fromrevidValue.Value != "")
                result.fromrevid = ValueParser.ParseInt64(fromrevidValue.Value);
            var totitleValue = element.Attribute("totitle");
            if (totitleValue != null)
                result.totitle = ValueParser.ParseString(totitleValue.Value);
            var torevidValue = element.Attribute("torevid");
            if (torevidValue != null && torevidValue.Value != "")
                result.torevid = ValueParser.ParseInt64(torevidValue.Value);
            var valueValue = element;
            result.value = ValueParser.ParseString(valueValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("fromtitle: {0}; fromrevid: {1}; totitle: {2}; torevid: {3}; value: {4}", fromtitle, fromrevid, totitle, torevid, value);
        }
    }
}