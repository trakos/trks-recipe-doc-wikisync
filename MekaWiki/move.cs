using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class moveResult
    {
        public string from { get; private set; }
        public string to { get; private set; }
        public string reason { get; private set; }
        public bool redirectcreated { get; private set; }
        public bool moveoverredirect { get; private set; }
        public string talkfrom { get; private set; }
        public string talkto { get; private set; }
        public bool talkmoveoverredirect { get; private set; }
        public string talkmove_error_code { get; private set; }
        public string talkmove_error_info { get; private set; }

        private moveResult()
        {
        }

        public static moveResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new moveResult();
            var fromValue = element.Attribute("from");
            if (fromValue != null)
                result.from = ValueParser.ParseString(fromValue.Value);
            var toValue = element.Attribute("to");
            if (toValue != null)
                result.to = ValueParser.ParseString(toValue.Value);
            var reasonValue = element.Attribute("reason");
            if (reasonValue != null)
                result.reason = ValueParser.ParseString(reasonValue.Value);
            var redirectcreatedValue = element.Attribute("redirectcreated");
            if (redirectcreatedValue != null)
                result.redirectcreated = ValueParser.ParseBoolean(redirectcreatedValue.Value);
            var moveoverredirectValue = element.Attribute("moveoverredirect");
            if (moveoverredirectValue != null)
                result.moveoverredirect = ValueParser.ParseBoolean(moveoverredirectValue.Value);
            var talkfromValue = element.Attribute("talkfrom");
            if (talkfromValue != null)
                result.talkfrom = ValueParser.ParseString(talkfromValue.Value);
            var talktoValue = element.Attribute("talkto");
            if (talktoValue != null)
                result.talkto = ValueParser.ParseString(talktoValue.Value);
            var talkmoveoverredirectValue = element.Attribute("talkmoveoverredirect");
            if (talkmoveoverredirectValue != null)
                result.talkmoveoverredirect = ValueParser.ParseBoolean(talkmoveoverredirectValue.Value);
            var talkmove_error_codeValue = element.Attribute("talkmove-error-code");
            if (talkmove_error_codeValue != null)
                result.talkmove_error_code = ValueParser.ParseString(talkmove_error_codeValue.Value);
            var talkmove_error_infoValue = element.Attribute("talkmove-error-info");
            if (talkmove_error_infoValue != null)
                result.talkmove_error_info = ValueParser.ParseString(talkmove_error_infoValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("from: {0}; to: {1}; reason: {2}; redirectcreated: {3}; moveoverredirect: {4}; talkfrom: {5}; talkto: {6}; talkmoveoverredirect: {7}; talkmove_error_code: {8}; talkmove_error_info: {9}", from, to, reason, redirectcreated, moveoverredirect, talkfrom, talkto, talkmoveoverredirect, talkmove_error_code, talkmove_error_info);
        }
    }
}