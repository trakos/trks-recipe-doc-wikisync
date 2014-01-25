using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class blocksSelect
    {
        public long id { get; private set; }
        public string user { get; private set; }
        public long? userid { get; private set; }
        public string by { get; private set; }
        public long byid { get; private set; }
        public DateTime timestamp { get; private set; }
        public DateTime expiry { get; private set; }
        public string reason { get; private set; }
        public string rangestart { get; private set; }
        public string rangeend { get; private set; }
        public bool automatic { get; private set; }
        public bool anononly { get; private set; }
        public bool nocreate { get; private set; }
        public bool autoblock { get; private set; }
        public bool noemail { get; private set; }
        public bool hidden { get; private set; }
        public bool allowusertalk { get; private set; }

        private blocksSelect()
        {
        }

        public static blocksSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new blocksSelect();
            var idValue = element.Attribute("id");
            if (idValue != null && idValue.Value != "")
                result.id = ValueParser.ParseInt64(idValue.Value);
            var userValue = element.Attribute("user");
            if (userValue != null)
                result.user = ValueParser.ParseString(userValue.Value);
            var useridValue = element.Attribute("userid");
            if (useridValue != null && useridValue.Value != "")
                result.userid = ValueParser.ParseInt64(useridValue.Value);
            var byValue = element.Attribute("by");
            if (byValue != null)
                result.by = ValueParser.ParseString(byValue.Value);
            var byidValue = element.Attribute("byid");
            if (byidValue != null && byidValue.Value != "")
                result.byid = ValueParser.ParseInt64(byidValue.Value);
            var timestampValue = element.Attribute("timestamp");
            if (timestampValue != null && timestampValue.Value != "")
                result.timestamp = ValueParser.ParseDateTime(timestampValue.Value);
            var expiryValue = element.Attribute("expiry");
            if (expiryValue != null && expiryValue.Value != "")
                result.expiry = ValueParser.ParseDateTime(expiryValue.Value);
            var reasonValue = element.Attribute("reason");
            if (reasonValue != null)
                result.reason = ValueParser.ParseString(reasonValue.Value);
            var rangestartValue = element.Attribute("rangestart");
            if (rangestartValue != null)
                result.rangestart = ValueParser.ParseString(rangestartValue.Value);
            var rangeendValue = element.Attribute("rangeend");
            if (rangeendValue != null)
                result.rangeend = ValueParser.ParseString(rangeendValue.Value);
            var automaticValue = element.Attribute("automatic");
            if (automaticValue != null)
                result.automatic = ValueParser.ParseBoolean(automaticValue.Value);
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
            var hiddenValue = element.Attribute("hidden");
            if (hiddenValue != null)
                result.hidden = ValueParser.ParseBoolean(hiddenValue.Value);
            var allowusertalkValue = element.Attribute("allowusertalk");
            if (allowusertalkValue != null)
                result.allowusertalk = ValueParser.ParseBoolean(allowusertalkValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("id: {0}; user: {1}; userid: {2}; by: {3}; byid: {4}; timestamp: {5}; expiry: {6}; reason: {7}; rangestart: {8}; rangeend: {9}; automatic: {10}; anononly: {11}; nocreate: {12}; autoblock: {13}; noemail: {14}; hidden: {15}; allowusertalk: {16}", id, user, userid, by, byid, timestamp, expiry, reason, rangestart, rangeend, automatic, anononly, nocreate, autoblock, noemail, hidden, allowusertalk);
        }
    }

    public sealed class blocksWhere
    {
        ///<summary>
        ///The timestamp to start enumerating from
        ///</summary>
        public DateTime start { get; private set; }

        ///<summary>
        ///The timestamp to stop enumerating at
        ///</summary>
        public DateTime end { get; private set; }

        ///<summary>
        ///List of block IDs to list (optional)
        ///</summary>
        public ItemOrCollection<int> ids { get; private set; }

        ///<summary>
        ///List of users to search for (optional)
        ///</summary>
        public ItemOrCollection<string> users { get; private set; }

        ///<summary>
        ///Get all blocks applying to this IP or CIDR range, including range blocks.
        ///Cannot be used together with bkusers. CIDR ranges broader than IPv4/16 or IPv6/19 are not accepted
        ///</summary>
        public string ip { get; private set; }

        ///<summary>
        ///Show only items that meet this criteria.
        ///For example, to see only indefinite blocks on IPs, set bkshow=ip|!temp
        ///</summary>
        public ItemOrCollection<blocksshow> show { get; private set; }

        private blocksWhere()
        {
        }
    }

    public sealed class blocksOrderBy
    {
        private blocksOrderBy()
        {
        }
    }
}