using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class extlinksSelect
    {
        public string value { get; private set; }

        private extlinksSelect()
        {
        }

        public static extlinksSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new extlinksSelect();
            var valueValue = element;
            result.value = ValueParser.ParseString(valueValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("value: {0}", value);
        }
    }

    public sealed class extlinksWhere
    {
        ///<summary>
        ///Protocol of the URL. If empty and elquery set, the protocol is http.
        ///Leave both this and elquery empty to list all external links
        ///</summary>
        public extlinksprotocol protocol { get; private set; }

        ///<summary>
        ///Search string without protocol. Useful for checking whether a certain page contains a certain external url
        ///</summary>
        public string query { get; private set; }

        ///<summary>
        ///Expand protocol-relative URLs with the canonical protocol
        ///</summary>
        public bool expandurl { get; private set; }

        private extlinksWhere()
        {
        }
    }
}