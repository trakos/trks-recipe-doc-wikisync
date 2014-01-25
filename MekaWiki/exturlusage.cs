using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class exturlusageSelect
    {
        public long pageid { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public string url { get; private set; }

        private exturlusageSelect()
        {
        }

        public static exturlusageSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new exturlusageSelect();
            var pageidValue = element.Attribute("pageid");
            if (pageidValue != null && pageidValue.Value != "")
                result.pageid = ValueParser.ParseInt64(pageidValue.Value);
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var urlValue = element.Attribute("url");
            if (urlValue != null)
                result.url = ValueParser.ParseString(urlValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("pageid: {0}; ns: {1}; title: {2}; url: {3}", pageid, ns, title, url);
        }
    }

    public sealed class exturlusageWhere
    {
        ///<summary>
        ///Protocol of the URL. If empty and euquery set, the protocol is http.
        ///Leave both this and euquery empty to list all external links
        ///</summary>
        public exturlusageprotocol protocol { get; private set; }

        ///<summary>
        ///Search string without protocol. See [[Special:LinkSearch]]. Leave empty to list all external links
        ///</summary>
        public string query { get; private set; }

        ///<summary>
        ///The page namespace(s) to enumerate.
        ///</summary>
        public ItemOrCollection<Namespace> ns { get; private set; }

        ///<summary>
        ///Expand protocol-relative URLs with the canonical protocol
        ///</summary>
        public bool expandurl { get; private set; }

        private exturlusageWhere()
        {
        }
    }
}