using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class langbacklinksSelect
    {
        public long pageid { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public bool redirect { get; private set; }
        public string lllang { get; private set; }
        public string lltitle { get; private set; }

        private langbacklinksSelect()
        {
        }

        public static langbacklinksSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new langbacklinksSelect();
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
            var lllangValue = element.Attribute("lllang");
            if (lllangValue != null)
                result.lllang = ValueParser.ParseString(lllangValue.Value);
            var lltitleValue = element.Attribute("lltitle");
            if (lltitleValue != null)
                result.lltitle = ValueParser.ParseString(lltitleValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("pageid: {0}; ns: {1}; title: {2}; redirect: {3}; lllang: {4}; lltitle: {5}", pageid, ns, title, redirect, lllang, lltitle);
        }
    }

    public sealed class langbacklinksWhere
    {
        ///<summary>
        ///Language for the language link
        ///</summary>
        public string lang { get; private set; }

        ///<summary>
        ///Language link to search for. Must be used with lbllang
        ///</summary>
        public string title { get; private set; }

        private langbacklinksWhere()
        {
        }
    }

    public sealed class langbacklinksOrderBy
    {
        private langbacklinksOrderBy()
        {
        }
    }
}