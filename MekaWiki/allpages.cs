using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class allpagesSelect
    {
        public long pageid { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }

        private allpagesSelect()
        {
        }

        public static allpagesSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new allpagesSelect();
            var pageidValue = element.Attribute("pageid");
            if (pageidValue != null && pageidValue.Value != "")
                result.pageid = ValueParser.ParseInt64(pageidValue.Value);
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
            return string.Format("pageid: {0}; ns: {1}; title: {2}", pageid, ns, title);
        }
    }

    public sealed class allpagesWhere
    {
        ///<summary>
        ///The page title to start enumerating from
        ///</summary>
        public string from { get; private set; }

        ///<summary>
        ///The page title to stop enumerating at
        ///</summary>
        public string to { get; private set; }

        ///<summary>
        ///Search for all page titles that begin with this value
        ///</summary>
        public string prefix { get; private set; }

        ///<summary>
        ///The namespace to enumerate
        ///</summary>
        public Namespace ns { get; private set; }

        ///<summary>
        ///Which pages to list
        ///</summary>
        public allpagesfilterredir filterredir { get; private set; }

        ///<summary>
        ///Limit to pages with at least this many bytes
        ///</summary>
        public int minsize { get; private set; }

        ///<summary>
        ///Limit to pages with at most this many bytes
        ///</summary>
        public int maxsize { get; private set; }

        ///<summary>
        ///Limit to protected pages only
        ///</summary>
        public ItemOrCollection<allpagesprtype> prtype { get; private set; }

        ///<summary>
        ///The protection level (must be used with apprtype= parameter)
        ///</summary>
        public ItemOrCollection<allpagesprlevel> prlevel { get; private set; }

        ///<summary>
        ///Filter protections based on cascadingness (ignored when apprtype isn't set)
        ///</summary>
        public allpagesprfiltercascade prfiltercascade { get; private set; }

        ///<summary>
        ///Filter based on whether a page has langlinks
        ///Note that this may not consider langlinks added by extensions.
        ///</summary>
        public allpagesfilterlanglinks filterlanglinks { get; private set; }

        ///<summary>
        ///Which protection expiry to filter the page on
        /// indefinite - Get only pages with indefinite protection expiry
        /// definite - Get only pages with a definite (specific) protection expiry
        /// all - Get pages with any protections expiry
        ///</summary>
        public allpagesprexpiry prexpiry { get; private set; }

        private allpagesWhere()
        {
        }
    }

    public sealed class allpagesOrderBy
    {
        private allpagesOrderBy()
        {
        }
    }
}