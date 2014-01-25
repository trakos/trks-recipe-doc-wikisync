using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class filerevertResult
    {
        public filerevertresult result { get; private set; }
        public string errors { get; private set; }

        private filerevertResult()
        {
        }

        public static filerevertResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new filerevertResult();
            var resultValue = element.Attribute("result");
            if (resultValue != null && resultValue.Value != "")
                result.result = new filerevertresult(resultValue.Value);
            var errorsValue = element.Attribute("errors");
            if (errorsValue != null)
                result.errors = ValueParser.ParseString(errorsValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("result: {0}; errors: {1}", result, errors);
        }
    }
}