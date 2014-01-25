using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class usersSelect
    {
        public long? userid { get; private set; }
        public string name { get; private set; }
        public bool invalid { get; private set; }
        public bool hidden { get; private set; }
        public bool interwiki { get; private set; }
        public bool missing { get; private set; }
        public string userrightstoken { get; private set; }
        public int? editcount { get; private set; }
        public DateTime? registration { get; private set; }
        public long? blockid { get; private set; }
        public string blockedby { get; private set; }
        public long? blockedbyid { get; private set; }
        public string blockedreason { get; private set; }
        public DateTime? blockedexpiry { get; private set; }
        public bool emailable { get; private set; }
        public usersgender gender { get; private set; }

        private usersSelect()
        {
        }

        public static usersSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new usersSelect();
            var useridValue = element.Attribute("userid");
            if (useridValue != null && useridValue.Value != "")
                result.userid = ValueParser.ParseInt64(useridValue.Value);
            var nameValue = element.Attribute("name");
            if (nameValue != null)
                result.name = ValueParser.ParseString(nameValue.Value);
            var invalidValue = element.Attribute("invalid");
            if (invalidValue != null)
                result.invalid = ValueParser.ParseBoolean(invalidValue.Value);
            var hiddenValue = element.Attribute("hidden");
            if (hiddenValue != null)
                result.hidden = ValueParser.ParseBoolean(hiddenValue.Value);
            var interwikiValue = element.Attribute("interwiki");
            if (interwikiValue != null)
                result.interwiki = ValueParser.ParseBoolean(interwikiValue.Value);
            var missingValue = element.Attribute("missing");
            if (missingValue != null)
                result.missing = ValueParser.ParseBoolean(missingValue.Value);
            var userrightstokenValue = element.Attribute("userrightstoken");
            if (userrightstokenValue != null)
                result.userrightstoken = ValueParser.ParseString(userrightstokenValue.Value);
            var editcountValue = element.Attribute("editcount");
            if (editcountValue != null && editcountValue.Value != "")
                result.editcount = ValueParser.ParseInt32(editcountValue.Value);
            var registrationValue = element.Attribute("registration");
            if (registrationValue != null && registrationValue.Value != "")
                result.registration = ValueParser.ParseDateTime(registrationValue.Value);
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
            var blockedexpiryValue = element.Attribute("blockedexpiry");
            if (blockedexpiryValue != null && blockedexpiryValue.Value != "")
                result.blockedexpiry = ValueParser.ParseDateTime(blockedexpiryValue.Value);
            var emailableValue = element.Attribute("emailable");
            if (emailableValue != null)
                result.emailable = ValueParser.ParseBoolean(emailableValue.Value);
            var genderValue = element.Attribute("gender");
            if (genderValue != null && genderValue.Value != "")
                result.gender = new usersgender(genderValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("userid: {0}; name: {1}; invalid: {2}; hidden: {3}; interwiki: {4}; missing: {5}; userrightstoken: {6}; editcount: {7}; registration: {8}; blockid: {9}; blockedby: {10}; blockedbyid: {11}; blockedreason: {12}; blockedexpiry: {13}; emailable: {14}; gender: {15}", userid, name, invalid, hidden, interwiki, missing, userrightstoken, editcount, registration, blockid, blockedby, blockedbyid, blockedreason, blockedexpiry, emailable, gender);
        }
    }

    public sealed class usersWhere
    {
        ///<summary>
        ///A list of users to obtain the same information for
        ///</summary>
        public ItemOrCollection<string> users { get; private set; }

        ///<summary>
        ///Which tokens to obtain for each user
        ///</summary>
        public ItemOrCollection<userstoken> token { get; private set; }

        private usersWhere()
        {
        }
    }
}