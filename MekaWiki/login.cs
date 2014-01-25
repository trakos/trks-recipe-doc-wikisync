using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class loginResult
    {
        public loginresult result { get; private set; }
        public long? lguserid { get; private set; }
        public string lgusername { get; private set; }
        public string lgtoken { get; private set; }
        public string cookieprefix { get; private set; }
        public string sessionid { get; private set; }
        public string token { get; private set; }
        public string details { get; private set; }
        public int? wait { get; private set; }
        public string reason { get; private set; }

        private loginResult()
        {
        }

        public static loginResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new loginResult();
            var resultValue = element.Attribute("result");
            if (resultValue != null && resultValue.Value != "")
                result.result = new loginresult(resultValue.Value);
            var lguseridValue = element.Attribute("lguserid");
            if (lguseridValue != null && lguseridValue.Value != "")
                result.lguserid = ValueParser.ParseInt64(lguseridValue.Value);
            var lgusernameValue = element.Attribute("lgusername");
            if (lgusernameValue != null)
                result.lgusername = ValueParser.ParseString(lgusernameValue.Value);
            var lgtokenValue = element.Attribute("lgtoken");
            if (lgtokenValue != null)
                result.lgtoken = ValueParser.ParseString(lgtokenValue.Value);
            var cookieprefixValue = element.Attribute("cookieprefix");
            if (cookieprefixValue != null)
                result.cookieprefix = ValueParser.ParseString(cookieprefixValue.Value);
            var sessionidValue = element.Attribute("sessionid");
            if (sessionidValue != null)
                result.sessionid = ValueParser.ParseString(sessionidValue.Value);
            var tokenValue = element.Attribute("token");
            if (tokenValue != null)
                result.token = ValueParser.ParseString(tokenValue.Value);
            var detailsValue = element.Attribute("details");
            if (detailsValue != null)
                result.details = ValueParser.ParseString(detailsValue.Value);
            var waitValue = element.Attribute("wait");
            if (waitValue != null && waitValue.Value != "")
                result.wait = ValueParser.ParseInt32(waitValue.Value);
            var reasonValue = element.Attribute("reason");
            if (reasonValue != null)
                result.reason = ValueParser.ParseString(reasonValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("result: {0}; lguserid: {1}; lgusername: {2}; lgtoken: {3}; cookieprefix: {4}; sessionid: {5}; token: {6}; details: {7}; wait: {8}; reason: {9}", result, lguserid, lgusername, lgtoken, cookieprefix, sessionid, token, details, wait, reason);
        }
    }
}