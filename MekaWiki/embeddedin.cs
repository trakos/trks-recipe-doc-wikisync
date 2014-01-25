using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class embeddedinSelect
    {
        public long pageid { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public bool redirect { get; private set; }

        private embeddedinSelect()
        {
        }

        public static embeddedinSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new embeddedinSelect();
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
            return result;
        }

        public override string ToString()
        {
            return string.Format("pageid: {0}; ns: {1}; title: {2}; redirect: {3}", pageid, ns, title, redirect);
        }
    }

    public sealed class embeddedinWhere
    {
        ///<summary>
        ///Title to search. Cannot be used together with eipageid
        ///</summary>
        public string title { get; private set; }

        ///<summary>
        ///Pageid to search. Cannot be used together with eititle
        ///</summary>
        public long pageid { get; private set; }

        ///<summary>
        ///The namespace to enumerate
        ///</summary>
        public ItemOrCollection<Namespace> ns { get; private set; }

        ///<summary>
        ///How to filter for redirects
        ///</summary>
        public embeddedinfilterredir filterredir { get; private set; }

        private embeddedinWhere()
        {
        }
    }

    public sealed class embeddedinOrderBy
    {
        private embeddedinOrderBy()
        {
        }
    }
}