using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class categorymembersSelect
    {
        public long pageid { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public string sortkey { get; private set; }
        public string sortkeyprefix { get; private set; }
        public categorymemberstype type { get; private set; }
        public DateTime timestamp { get; private set; }

        private categorymembersSelect()
        {
        }

        public static categorymembersSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new categorymembersSelect();
            var pageidValue = element.Attribute("pageid");
            if (pageidValue != null && pageidValue.Value != "")
                result.pageid = ValueParser.ParseInt64(pageidValue.Value);
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
            var typeValue = element.Attribute("type");
            if (typeValue != null && typeValue.Value != "")
                result.type = new categorymemberstype(typeValue.Value);
            var timestampValue = element.Attribute("timestamp");
            if (timestampValue != null && timestampValue.Value != "")
                result.timestamp = ValueParser.ParseDateTime(timestampValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("pageid: {0}; ns: {1}; title: {2}; sortkey: {3}; sortkeyprefix: {4}; type: {5}; timestamp: {6}", pageid, ns, title, sortkey, sortkeyprefix, type, timestamp);
        }
    }

    public sealed class categorymembersWhere
    {
        ///<summary>
        ///Which category to enumerate (required). Must include Category: prefix. Cannot be used together with cmpageid
        ///</summary>
        public string title { get; private set; }

        ///<summary>
        ///Page ID of the category to enumerate. Cannot be used together with cmtitle
        ///</summary>
        public long pageid { get; private set; }

        ///<summary>
        ///Only include pages in these namespaces
        ///</summary>
        public ItemOrCollection<Namespace> ns { get; private set; }

        ///<summary>
        ///What type of category members to include. Ignored when cmsort=timestamp is set
        ///</summary>
        public ItemOrCollection<categorymemberstype> type { get; private set; }

        ///<summary>
        ///Timestamp to start listing from. Can only be used with cmsort=timestamp
        ///</summary>
        public DateTime start { get; private set; }

        ///<summary>
        ///Timestamp to end listing at. Can only be used with cmsort=timestamp
        ///</summary>
        public DateTime end { get; private set; }

        ///<summary>
        ///Sortkey to start listing from. Must be given in binary format. Can only be used with cmsort=sortkey
        ///</summary>
        public string startsortkey { get; private set; }

        ///<summary>
        ///Sortkey to end listing at. Must be given in binary format. Can only be used with cmsort=sortkey
        ///</summary>
        public string endsortkey { get; private set; }

        ///<summary>
        ///Sortkey prefix to start listing from. Can only be used with cmsort=sortkey. Overrides cmstartsortkey
        ///</summary>
        public string startsortkeyprefix { get; private set; }

        ///<summary>
        ///Sortkey prefix to end listing BEFORE (not at, if this value occurs it will not be included!). Can only be used with cmsort=sortkey. Overrides cmendsortkey
        ///</summary>
        public string endsortkeyprefix { get; private set; }

        private categorymembersWhere()
        {
        }
    }

    public sealed class categorymembersOrderBy
    {
        public string sortkey { get; private set; }
        public DateTime timestamp { get; private set; }

        private categorymembersOrderBy()
        {
        }
    }
}