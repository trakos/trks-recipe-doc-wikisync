using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class allusersSelect
    {
        public long userid { get; private set; }
        public string name { get; private set; }
        public int? recenteditcount { get; private set; }
        public long? blockid { get; private set; }
        public string blockedby { get; private set; }
        public long? blockedbyid { get; private set; }
        public string blockedreason { get; private set; }
        public string blockedexpiry { get; private set; }
        public bool hidden { get; private set; }
        public int editcount { get; private set; }
        public string registration { get; private set; }

        private allusersSelect()
        {
        }

        public static allusersSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new allusersSelect();
            var useridValue = element.Attribute("userid");
            if (useridValue != null && useridValue.Value != "")
                result.userid = ValueParser.ParseInt64(useridValue.Value);
            var nameValue = element.Attribute("name");
            if (nameValue != null)
                result.name = ValueParser.ParseString(nameValue.Value);
            var recenteditcountValue = element.Attribute("recenteditcount");
            if (recenteditcountValue != null && recenteditcountValue.Value != "")
                result.recenteditcount = ValueParser.ParseInt32(recenteditcountValue.Value);
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
            if (blockedexpiryValue != null)
                result.blockedexpiry = ValueParser.ParseString(blockedexpiryValue.Value);
            var hiddenValue = element.Attribute("hidden");
            if (hiddenValue != null)
                result.hidden = ValueParser.ParseBoolean(hiddenValue.Value);
            var editcountValue = element.Attribute("editcount");
            if (editcountValue != null && editcountValue.Value != "")
                result.editcount = ValueParser.ParseInt32(editcountValue.Value);
            var registrationValue = element.Attribute("registration");
            if (registrationValue != null)
                result.registration = ValueParser.ParseString(registrationValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("userid: {0}; name: {1}; recenteditcount: {2}; blockid: {3}; blockedby: {4}; blockedbyid: {5}; blockedreason: {6}; blockedexpiry: {7}; hidden: {8}; editcount: {9}; registration: {10}", userid, name, recenteditcount, blockid, blockedby, blockedbyid, blockedreason, blockedexpiry, hidden, editcount, registration);
        }
    }

    public sealed class allusersWhere
    {
        ///<summary>
        ///The user name to start enumerating from
        ///</summary>
        public string from { get; private set; }

        ///<summary>
        ///The user name to stop enumerating at
        ///</summary>
        public string to { get; private set; }

        ///<summary>
        ///Search for all users that begin with this value
        ///</summary>
        public string prefix { get; private set; }

        ///<summary>
        ///Limit users to given group name(s)
        ///</summary>
        public ItemOrCollection<allusersgroup> group { get; private set; }

        ///<summary>
        ///Exclude users in given group name(s)
        ///</summary>
        public ItemOrCollection<allusersgroup> excludegroup { get; private set; }

        ///<summary>
        ///Limit users to given right(s) (does not include rights granted by implicit or auto-promoted groups like *, user, or autoconfirmed)
        ///</summary>
        public ItemOrCollection<allusersrights> rights { get; private set; }

        ///<summary>
        ///Only list users who have made edits
        ///</summary>
        public bool witheditsonly { get; private set; }

        ///<summary>
        ///Only list users active in the last 30 days(s)
        ///</summary>
        public bool activeusers { get; private set; }

        private allusersWhere()
        {
        }
    }

    public sealed class allusersOrderBy
    {
        private allusersOrderBy()
        {
        }
    }
}