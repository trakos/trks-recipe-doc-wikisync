using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class iwbacklinksSelect
    {
        public long pageid { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public bool redirect { get; private set; }
        public string iwprefix { get; private set; }
        public string iwtitle { get; private set; }

        private iwbacklinksSelect()
        {
        }

        public static iwbacklinksSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new iwbacklinksSelect();
            var pageidValue = element.Attribute("pageid");
            if (pageidValue != null && pageidValue.Value != "")
                result.pageid = ValueParser.ParseInt64(pageidValue.Value);
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var redirectValue = element.Attribute("redirect");
            if (redirectValue != null)
                result.redirect = ValueParser.ParseBoolean(redirectValue.Value);
            var iwprefixValue = element.Attribute("iwprefix");
            if (iwprefixValue != null)
                result.iwprefix = ValueParser.ParseString(iwprefixValue.Value);
            var iwtitleValue = element.Attribute("iwtitle");
            if (iwtitleValue != null)
                result.iwtitle = ValueParser.ParseString(iwtitleValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("pageid: {0}; ns: {1}; title: {2}; redirect: {3}; iwprefix: {4}; iwtitle: {5}", pageid, ns, title, redirect, iwprefix, iwtitle);
        }
    }

    public sealed class iwbacklinksWhere
    {
        ///<summary>
        ///Prefix for the interwiki
        ///</summary>
        public string prefix { get; private set; }

        ///<summary>
        ///Interwiki link to search for. Must be used with iwblprefix
        ///</summary>
        public string title { get; private set; }

        private iwbacklinksWhere()
        {
        }
    }

    public sealed class iwbacklinksOrderBy
    {
        private iwbacklinksOrderBy()
        {
        }
    }
}