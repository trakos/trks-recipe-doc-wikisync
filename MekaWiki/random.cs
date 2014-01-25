using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class randomSelect
    {
        public long id { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }

        private randomSelect()
        {
        }

        public static randomSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new randomSelect();
            var idValue = element.Attribute("id");
            if (idValue != null && idValue.Value != "")
                result.id = ValueParser.ParseInt64(idValue.Value);
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
            return string.Format("id: {0}; ns: {1}; title: {2}", id, ns, title);
        }
    }

    public sealed class randomWhere
    {
        ///<summary>
        ///Return pages in these namespaces only
        ///</summary>
        public ItemOrCollection<Namespace> ns { get; private set; }

        ///<summary>
        ///Load a random redirect instead of a random page
        ///</summary>
        public bool redirect { get; private set; }

        private randomWhere()
        {
        }
    }
}