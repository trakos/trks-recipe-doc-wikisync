using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class searchSelect
    {
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public string snippet { get; private set; }
        public int size { get; private set; }
        public int wordcount { get; private set; }
        public DateTime timestamp { get; private set; }
        public string score { get; private set; }
        public string titlesnippet { get; private set; }
        public string redirecttitle { get; private set; }
        public string redirectsnippet { get; private set; }
        public string sectiontitle { get; private set; }
        public string sectionsnippet { get; private set; }
        public bool hasrelated { get; private set; }

        private searchSelect()
        {
        }

        public static searchSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new searchSelect();
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var snippetValue = element.Attribute("snippet");
            if (snippetValue != null)
                result.snippet = ValueParser.ParseString(snippetValue.Value);
            var sizeValue = element.Attribute("size");
            if (sizeValue != null && sizeValue.Value != "")
                result.size = ValueParser.ParseInt32(sizeValue.Value);
            var wordcountValue = element.Attribute("wordcount");
            if (wordcountValue != null && wordcountValue.Value != "")
                result.wordcount = ValueParser.ParseInt32(wordcountValue.Value);
            var timestampValue = element.Attribute("timestamp");
            if (timestampValue != null && timestampValue.Value != "")
                result.timestamp = ValueParser.ParseDateTime(timestampValue.Value);
            var scoreValue = element.Attribute("score");
            if (scoreValue != null)
                result.score = ValueParser.ParseString(scoreValue.Value);
            var titlesnippetValue = element.Attribute("titlesnippet");
            if (titlesnippetValue != null)
                result.titlesnippet = ValueParser.ParseString(titlesnippetValue.Value);
            var redirecttitleValue = element.Attribute("redirecttitle");
            if (redirecttitleValue != null)
                result.redirecttitle = ValueParser.ParseString(redirecttitleValue.Value);
            var redirectsnippetValue = element.Attribute("redirectsnippet");
            if (redirectsnippetValue != null)
                result.redirectsnippet = ValueParser.ParseString(redirectsnippetValue.Value);
            var sectiontitleValue = element.Attribute("sectiontitle");
            if (sectiontitleValue != null)
                result.sectiontitle = ValueParser.ParseString(sectiontitleValue.Value);
            var sectionsnippetValue = element.Attribute("sectionsnippet");
            if (sectionsnippetValue != null)
                result.sectionsnippet = ValueParser.ParseString(sectionsnippetValue.Value);
            var hasrelatedValue = element.Attribute("hasrelated");
            if (hasrelatedValue != null)
                result.hasrelated = ValueParser.ParseBoolean(hasrelatedValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("ns: {0}; title: {1}; snippet: {2}; size: {3}; wordcount: {4}; timestamp: {5}; score: {6}; titlesnippet: {7}; redirecttitle: {8}; redirectsnippet: {9}; sectiontitle: {10}; sectionsnippet: {11}; hasrelated: {12}", ns, title, snippet, size, wordcount, timestamp, score, titlesnippet, redirecttitle, redirectsnippet, sectiontitle, sectionsnippet, hasrelated);
        }
    }

    public sealed class searchWhere
    {
        ///<summary>
        ///The namespace(s) to enumerate
        ///</summary>
        public ItemOrCollection<Namespace> ns { get; private set; }

        ///<summary>
        ///Search inside the text or titles
        ///</summary>
        public searchwhat what { get; private set; }

        ///<summary>
        ///What metadata to return
        ///</summary>
        public ItemOrCollection<searchinfo> info { get; private set; }

        ///<summary>
        ///Include redirect pages in the search
        ///</summary>
        public bool redirects { get; private set; }

        private searchWhere()
        {
        }
    }
}