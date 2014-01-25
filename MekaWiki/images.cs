using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class imagesSelect
    {
        public Namespace ns { get; private set; }
        public string title { get; private set; }

        private imagesSelect()
        {
        }

        public static imagesSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new imagesSelect();
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

    public sealed class imagesWhere
    {
        ///<summary>
        ///Only list these images. Useful for checking whether a certain page has a certain Image.
        ///</summary>
        public ItemOrCollection<string> images { get; private set; }

        private imagesWhere()
        {
        }
    }

    public sealed class imagesOrderBy
    {
        private imagesOrderBy()
        {
        }
    }
}