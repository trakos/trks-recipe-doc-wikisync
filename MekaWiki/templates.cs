using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class templatesSelect
    {
        public Namespace ns { get; private set; }
        public string title { get; private set; }

        private templatesSelect()
        {
        }

        public static templatesSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new templatesSelect();
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

    public sealed class templatesWhere
    {
        ///<summary>
        ///Show templates in this namespace(s) only
        ///</summary>
        public ItemOrCollection<Namespace> ns { get; private set; }

        ///<summary>
        ///Only list these templates. Useful for checking whether a certain page uses a certain template.
        ///</summary>
        public ItemOrCollection<string> templates { get; private set; }

        private templatesWhere()
        {
        }
    }

    public sealed class templatesOrderBy
    {
        private templatesOrderBy()
        {
        }
    }
}