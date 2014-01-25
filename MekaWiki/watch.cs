using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class watchResult
    {
        public string title { get; private set; }
        public bool unwatched { get; private set; }
        public bool watched { get; private set; }
        public string message { get; private set; }

        private watchResult()
        {
        }

        public static watchResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new watchResult();
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var unwatchedValue = element.Attribute("unwatched");
            if (unwatchedValue != null)
                result.unwatched = ValueParser.ParseBoolean(unwatchedValue.Value);
            var watchedValue = element.Attribute("watched");
            if (watchedValue != null)
                result.watched = ValueParser.ParseBoolean(watchedValue.Value);
            var messageValue = element.Attribute("message");
            if (messageValue != null)
                result.message = ValueParser.ParseString(messageValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("title: {0}; unwatched: {1}; watched: {2}; message: {3}", title, unwatched, watched, message);
        }
    }
}