using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class uploadResult
    {
        public uploadresult result { get; private set; }
        public string filekey { get; private set; }
        public string sessionkey { get; private set; }
        public int? offset { get; private set; }
        public string statuskey { get; private set; }
        public string filename { get; private set; }

        private uploadResult()
        {
        }

        public static uploadResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new uploadResult();
            var resultValue = element.Attribute("result");
            if (resultValue != null && resultValue.Value != "")
                result.result = new uploadresult(resultValue.Value);
            var filekeyValue = element.Attribute("filekey");
            if (filekeyValue != null)
                result.filekey = ValueParser.ParseString(filekeyValue.Value);
            var sessionkeyValue = element.Attribute("sessionkey");
            if (sessionkeyValue != null)
                result.sessionkey = ValueParser.ParseString(sessionkeyValue.Value);
            var offsetValue = element.Attribute("offset");
            if (offsetValue != null && offsetValue.Value != "")
                result.offset = ValueParser.ParseInt32(offsetValue.Value);
            var statuskeyValue = element.Attribute("statuskey");
            if (statuskeyValue != null)
                result.statuskey = ValueParser.ParseString(statuskeyValue.Value);
            var filenameValue = element.Attribute("filename");
            if (filenameValue != null)
                result.filename = ValueParser.ParseString(filenameValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("result: {0}; filekey: {1}; sessionkey: {2}; offset: {3}; statuskey: {4}; filename: {5}", result, filekey, sessionkey, offset, statuskey, filename);
        }
    }
}