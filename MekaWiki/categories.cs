using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class categoriesSelect
    {
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public string sortkey { get; private set; }
        public string sortkeyprefix { get; private set; }
        public DateTime timestamp { get; private set; }
        public bool hidden { get; private set; }

        private categoriesSelect()
        {
        }

        public static categoriesSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new categoriesSelect();
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var sortkeyValue = element.Attribute("sortkey");
            if (sortkeyValue != null)
                result.sortkey = ValueParser.ParseString(sortkeyValue.Value);
            var sortkeyprefixValue = element.Attribute("sortkeyprefix");
            if (sortkeyprefixValue != null)
                result.sortkeyprefix = ValueParser.ParseString(sortkeyprefixValue.Value);
            var timestampValue = element.Attribute("timestamp");
            if (timestampValue != null && timestampValue.Value != "")
                result.timestamp = ValueParser.ParseDateTime(timestampValue.Value);
            var hiddenValue = element.Attribute("hidden");
            if (hiddenValue != null)
                result.hidden = ValueParser.ParseBoolean(hiddenValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("ns: {0}; title: {1}; sortkey: {2}; sortkeyprefix: {3}; timestamp: {4}; hidden: {5}", ns, title, sortkey, sortkeyprefix, timestamp, hidden);
        }
    }

    public sealed class categoriesWhere
    {
        ///<summary>
        ///Which kind of categories to show
        ///</summary>
        public ItemOrCollection<categoriesshow> show { get; private set; }

        ///<summary>
        ///Only list these categories. Useful for checking whether a certain page is in a certain category
        ///</summary>
        public ItemOrCollection<string> categories { get; private set; }

        private categoriesWhere()
        {
        }
    }

    public sealed class categoriesOrderBy
    {
        private categoriesOrderBy()
        {
        }
    }
}