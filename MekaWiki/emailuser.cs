using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class emailuserResult
    {
        public emailuserresult result { get; private set; }
        public string message { get; private set; }

        private emailuserResult()
        {
        }

        public static emailuserResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new emailuserResult();
            var resultValue = element.Attribute("result");
            if (resultValue != null && resultValue.Value != "")
                result.result = new emailuserresult(resultValue.Value);
            var messageValue = element.Attribute("message");
            if (messageValue != null)
                result.message = ValueParser.ParseString(messageValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("result: {0}; message: {1}", result, message);
        }
    }
}