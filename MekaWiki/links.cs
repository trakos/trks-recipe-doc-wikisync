using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class linksSelect
    {
        public Namespace ns { get; private set; }
        public string title { get; private set; }

        private linksSelect()
        {
        }

        public static linksSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new linksSelect();
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("ns: {0}; title: {1}", ns, title);
        }
    }

    public sealed class linksWhere
    {
        ///<summary>
        ///Show links in this namespace(s) only
        ///</summary>
        public ItemOrCollection<Namespace> ns { get; private set; }

        ///<summary>
        ///Only list links to these titles. Useful for checking whether a certain page links to a certain title.
        ///</summary>
        public ItemOrCollection<string> titles { get; private set; }

        private linksWhere()
        {
        }
    }

    public sealed class linksOrderBy
    {
        private linksOrderBy()
        {
        }
    }
}