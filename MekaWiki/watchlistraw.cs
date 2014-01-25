using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class watchlistrawSelect
    {
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public DateTime? changed { get; private set; }

        private watchlistrawSelect()
        {
        }

        public static watchlistrawSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new watchlistrawSelect();
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var changedValue = element.Attribute("changed");
            if (changedValue != null && changedValue.Value != "")
                result.changed = ValueParser.ParseDateTime(changedValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("ns: {0}; title: {1}; changed: {2}", ns, title, changed);
        }
    }

    public sealed class watchlistrawWhere
    {
        ///<summary>
        ///Only list pages in the given namespace(s)
        ///</summary>
        public ItemOrCollection<Namespace> ns { get; private set; }

        ///<summary>
        ///Only list items that meet these criteria
        ///</summary>
        public ItemOrCollection<watchlistrawshow> show { get; private set; }

        ///<summary>
        ///The name of the user whose watchlist you'd like to access
        ///</summary>
        public string owner { get; private set; }

        ///<summary>
        ///Give a security token (settable in preferences) to allow access to another user's watchlist
        ///</summary>
        public string token { get; private set; }

        private watchlistrawWhere()
        {
        }
    }

    public sealed class watchlistrawOrderBy
    {
        private watchlistrawOrderBy()
        {
        }
    }
}