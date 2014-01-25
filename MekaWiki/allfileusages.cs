using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class allfileusagesSelect
    {
        public long fromid { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }

        private allfileusagesSelect()
        {
        }

        public static allfileusagesSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new allfileusagesSelect();
            var fromidValue = element.Attribute("fromid");
            if (fromidValue != null && fromidValue.Value != "")
                result.fromid = ValueParser.ParseInt64(fromidValue.Value);
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
            return string.Format("fromid: {0}; ns: {1}; title: {2}", fromid, ns, title);
        }
    }

    public sealed class allfileusagesWhere
    {
        ///<summary>
        ///The title of the file to start enumerating from
        ///</summary>
        public string from { get; private set; }

        ///<summary>
        ///The title of the file to stop enumerating at
        ///</summary>
        public string to { get; private set; }

        ///<summary>
        ///Search for all file titles that begin with this value
        ///</summary>
        public string prefix { get; private set; }

        ///<summary>
        ///Only show distinct file titles. Cannot be used with afprop=ids.
        ///When used as a generator, yields target pages instead of source pages.
        ///</summary>
        public bool unique { get; private set; }

        private allfileusagesWhere()
        {
        }
    }

    public sealed class allfileusagesOrderBy
    {
        private allfileusagesOrderBy()
        {
        }
    }
}