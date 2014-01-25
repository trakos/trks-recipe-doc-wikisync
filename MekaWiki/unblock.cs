using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class unblockResult
    {
        public long? id { get; private set; }
        public string user { get; private set; }
        public long? userid { get; private set; }
        public string reason { get; private set; }

        private unblockResult()
        {
        }

        public static unblockResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new unblockResult();
            var idValue = element.Attribute("id");
            if (idValue != null && idValue.Value != "")
                result.id = ValueParser.ParseInt64(idValue.Value);
            var userValue = element.Attribute("user");
            if (userValue != null)
                result.user = ValueParser.ParseString(userValue.Value);
            var useridValue = element.Attribute("userid");
            if (useridValue != null && useridValue.Value != "")
                result.userid = ValueParser.ParseInt64(useridValue.Value);
            var reasonValue = element.Attribute("reason");
            if (reasonValue != null)
                result.reason = ValueParser.ParseString(reasonValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("id: {0}; user: {1}; userid: {2}; reason: {3}", id, user, userid, reason);
        }
    }
}