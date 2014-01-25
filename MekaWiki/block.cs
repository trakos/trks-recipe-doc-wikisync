using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class blockResult
    {
        public string user { get; private set; }
        public int? userID { get; private set; }
        public string expiry { get; private set; }
        public long? id { get; private set; }
        public string reason { get; private set; }
        public bool anononly { get; private set; }
        public bool nocreate { get; private set; }
        public bool autoblock { get; private set; }
        public bool noemail { get; private set; }
        public bool hidename { get; private set; }
        public bool allowusertalk { get; private set; }
        public bool watchuser { get; private set; }

        private blockResult()
        {
        }

        public static blockResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new blockResult();
            var userValue = element.Attribute("user");
            if (userValue != null)
                result.user = ValueParser.ParseString(userValue.Value);
            var userIDValue = element.Attribute("userID");
            if (userIDValue != null && userIDValue.Value != "")
                result.userID = ValueParser.ParseInt32(userIDValue.Value);
            var expiryValue = element.Attribute("expiry");
            if (expiryValue != null)
                result.expiry = ValueParser.ParseString(expiryValue.Value);
            var idValue = element.Attribute("id");
            if (idValue != null && idValue.Value != "")
                result.id = ValueParser.ParseInt64(idValue.Value);
            var reasonValue = element.Attribute("reason");
            if (reasonValue != null)
                result.reason = ValueParser.ParseString(reasonValue.Value);
            var anononlyValue = element.Attribute("anononly");
            if (anononlyValue != null)
                result.anononly = ValueParser.ParseBoolean(anononlyValue.Value);
            var nocreateValue = element.Attribute("nocreate");
            if (nocreateValue != null)
                result.nocreate = ValueParser.ParseBoolean(nocreateValue.Value);
            var autoblockValue = element.Attribute("autoblock");
            if (autoblockValue != null)
                result.autoblock = ValueParser.ParseBoolean(autoblockValue.Value);
            var noemailValue = element.Attribute("noemail");
            if (noemailValue != null)
                result.noemail = ValueParser.ParseBoolean(noemailValue.Value);
            var hidenameValue = element.Attribute("hidename");
            if (hidenameValue != null)
                result.hidename = ValueParser.ParseBoolean(hidenameValue.Value);
            var allowusertalkValue = element.Attribute("allowusertalk");
            if (allowusertalkValue != null)
                result.allowusertalk = ValueParser.ParseBoolean(allowusertalkValue.Value);
            var watchuserValue = element.Attribute("watchuser");
            if (watchuserValue != null)
                result.watchuser = ValueParser.ParseBoolean(watchuserValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("user: {0}; userID: {1}; expiry: {2}; id: {3}; reason: {4}; anononly: {5}; nocreate: {6}; autoblock: {7}; noemail: {8}; hidename: {9}; allowusertalk: {10}; watchuser: {11}", user, userID, expiry, id, reason, anononly, nocreate, autoblock, noemail, hidename, allowusertalk, watchuser);
        }
    }
}