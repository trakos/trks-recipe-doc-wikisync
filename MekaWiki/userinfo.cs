using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class userinfoResult
    {
        public long id { get; private set; }
        public string name { get; private set; }
        public bool anon { get; private set; }
        public long? blockid { get; private set; }
        public string blockedby { get; private set; }
        public long? blockedbyid { get; private set; }
        public string blockedreason { get; private set; }
        public bool messages { get; private set; }
        public string preferencestoken { get; private set; }
        public int editcount { get; private set; }
        public string realname { get; private set; }
        public string email { get; private set; }
        public DateTime? emailauthenticated { get; private set; }
        public DateTime? registrationdate { get; private set; }

        private userinfoResult()
        {
        }

        public static userinfoResult Parse(XElement element, WikiInfo wiki)
        {
            element = element.Elements().Single();
            var result = new userinfoResult();
            var idValue = element.Attribute("id");
            if (idValue != null && idValue.Value != "")
                result.id = ValueParser.ParseInt64(idValue.Value);
            var nameValue = element.Attribute("name");
            if (nameValue != null)
                result.name = ValueParser.ParseString(nameValue.Value);
            var anonValue = element.Attribute("anon");
            if (anonValue != null)
                result.anon = ValueParser.ParseBoolean(anonValue.Value);
            var blockidValue = element.Attribute("blockid");
            if (blockidValue != null && blockidValue.Value != "")
                result.blockid = ValueParser.ParseInt64(blockidValue.Value);
            var blockedbyValue = element.Attribute("blockedby");
            if (blockedbyValue != null)
                result.blockedby = ValueParser.ParseString(blockedbyValue.Value);
            var blockedbyidValue = element.Attribute("blockedbyid");
            if (blockedbyidValue != null && blockedbyidValue.Value != "")
                result.blockedbyid = ValueParser.ParseInt64(blockedbyidValue.Value);
            var blockedreasonValue = element.Attribute("blockedreason");
            if (blockedreasonValue != null)
                result.blockedreason = ValueParser.ParseString(blockedreasonValue.Value);
            var messagesValue = element.Attribute("messages");
            if (messagesValue != null)
                result.messages = ValueParser.ParseBoolean(messagesValue.Value);
            var preferencestokenValue = element.Attribute("preferencestoken");
            if (preferencestokenValue != null)
                result.preferencestoken = ValueParser.ParseString(preferencestokenValue.Value);
            var editcountValue = element.Attribute("editcount");
            if (editcountValue != null && editcountValue.Value != "")
                result.editcount = ValueParser.ParseInt32(editcountValue.Value);
            var realnameValue = element.Attribute("realname");
            if (realnameValue != null)
                result.realname = ValueParser.ParseString(realnameValue.Value);
            var emailValue = element.Attribute("email");
            if (emailValue != null)
                result.email = ValueParser.ParseString(emailValue.Value);
            var emailauthenticatedValue = element.Attribute("emailauthenticated");
            if (emailauthenticatedValue != null && emailauthenticatedValue.Value != "")
                result.emailauthenticated = ValueParser.ParseDateTime(emailauthenticatedValue.Value);
            var registrationdateValue = element.Attribute("registrationdate");
            if (registrationdateValue != null && registrationdateValue.Value != "")
                result.registrationdate = ValueParser.ParseDateTime(registrationdateValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("id: {0}; name: {1}; anon: {2}; blockid: {3}; blockedby: {4}; blockedbyid: {5}; blockedreason: {6}; messages: {7}; preferencestoken: {8}; editcount: {9}; realname: {10}; email: {11}; emailauthenticated: {12}; registrationdate: {13}", id, name, anon, blockid, blockedby, blockedbyid, blockedreason, messages, preferencestoken, editcount, realname, email, emailauthenticated, registrationdate);
        }
    }
}