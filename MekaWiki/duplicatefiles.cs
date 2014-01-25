using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class duplicatefilesSelect
    {
        public string name { get; private set; }
        public string user { get; private set; }
        public DateTime timestamp { get; private set; }
        public bool shared { get; private set; }

        private duplicatefilesSelect()
        {
        }

        public static duplicatefilesSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new duplicatefilesSelect();
            var nameValue = element.Attribute("name");
            if (nameValue != null)
                result.name = ValueParser.ParseString(nameValue.Value);
            var userValue = element.Attribute("user");
            if (userValue != null)
                result.user = ValueParser.ParseString(userValue.Value);
            var timestampValue = element.Attribute("timestamp");
            if (timestampValue != null && timestampValue.Value != "")
                result.timestamp = ValueParser.ParseDateTime(timestampValue.Value);
            var sharedValue = element.Attribute("shared");
            if (sharedValue != null)
                result.shared = ValueParser.ParseBoolean(sharedValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("name: {0}; user: {1}; timestamp: {2}; shared: {3}", name, user, timestamp, shared);
        }
    }

    public sealed class duplicatefilesWhere
    {
        ///<summary>
        ///Look only for files in the local repository
        ///</summary>
        public bool localonly { get; private set; }

        private duplicatefilesWhere()
        {
        }
    }

    public sealed class duplicatefilesOrderBy
    {
        private duplicatefilesOrderBy()
        {
        }
    }
}