using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class deletedrevsSelect
    {
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public string token { get; private set; }

        private deletedrevsSelect()
        {
        }

        public static deletedrevsSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new deletedrevsSelect();
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var tokenValue = element.Attribute("token");
            if (tokenValue != null)
                result.token = ValueParser.ParseString(tokenValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("ns: {0}; title: {1}; token: {2}", ns, title, token);
        }
    }

    public sealed class deletedrevsWhere
    {
        ///<summary>
        ///The timestamp to start enumerating from (1, 2)
        ///</summary>
        public DateTime start { get; private set; }

        ///<summary>
        ///The timestamp to stop enumerating at (1, 2)
        ///</summary>
        public DateTime end { get; private set; }

        ///<summary>
        ///Start listing at this title (3)
        ///</summary>
        public string from { get; private set; }

        ///<summary>
        ///Stop listing at this title (3)
        ///</summary>
        public string to { get; private set; }

        ///<summary>
        ///Search for all page titles that begin with this value (3)
        ///</summary>
        public string prefix { get; private set; }

        ///<summary>
        ///List only one revision for each page (3)
        ///</summary>
        public bool unique { get; private set; }

        ///<summary>
        ///Only list revisions by this user
        ///</summary>
        public string user { get; private set; }

        ///<summary>
        ///Don't list revisions by this user
        ///</summary>
        public string excludeuser { get; private set; }

        ///<summary>
        ///Only list pages in this namespace (3)
        ///</summary>
        public Namespace ns { get; private set; }

        private deletedrevsWhere()
        {
        }
    }

    public sealed class deletedrevsOrderBy
    {
        private deletedrevsOrderBy()
        {
        }
    }
}