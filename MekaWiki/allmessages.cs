using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class allmessagesSelect
    {
        public string name { get; private set; }
        public bool customised { get; private set; }
        public bool missing { get; private set; }
        public string value { get; private set; }
        public bool defaultmissing { get; private set; }
        public string defaultvalue { get; private set; }

        private allmessagesSelect()
        {
        }

        public static allmessagesSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new allmessagesSelect();
            var nameValue = element.Attribute("name");
            if (nameValue != null)
                result.name = ValueParser.ParseString(nameValue.Value);
            var customisedValue = element.Attribute("customised");
            if (customisedValue != null)
                result.customised = ValueParser.ParseBoolean(customisedValue.Value);
            var missingValue = element.Attribute("missing");
            if (missingValue != null)
                result.missing = ValueParser.ParseBoolean(missingValue.Value);
            var valueValue = element;
            result.value = ValueParser.ParseString(valueValue.Value);
            var defaultmissingValue = element.Attribute("defaultmissing");
            if (defaultmissingValue != null)
                result.defaultmissing = ValueParser.ParseBoolean(defaultmissingValue.Value);
            var defaultvalueValue = element.Attribute("default");
            if (defaultvalueValue != null)
                result.defaultvalue = ValueParser.ParseString(defaultvalueValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("name: {0}; customised: {1}; missing: {2}; value: {3}; defaultmissing: {4}; defaultvalue: {5}", name, customised, missing, value, defaultmissing, defaultvalue);
        }
    }

    public sealed class allmessagesWhere
    {
        ///<summary>
        ///Which messages to output. "*" (default) means all messages
        ///</summary>
        public ItemOrCollection<string> messages { get; private set; }

        ///<summary>
        ///Set to enable parser, will preprocess the wikitext of message
        ///Will substitute magic words, handle templates etc.
        ///</summary>
        public bool enableparser { get; private set; }

        ///<summary>
        ///If set, do not include the content of the messages in the output.
        ///</summary>
        public bool nocontent { get; private set; }

        ///<summary>
        ///Also include local messages, i.e. messages that don't exist in the software but do exist as a MediaWiki: page.
        ///This lists all MediaWiki: pages, so it will also list those that aren't 'really' messages such as Common.js
        ///</summary>
        public bool includelocal { get; private set; }

        ///<summary>
        ///Arguments to be substituted into message
        ///</summary>
        public ItemOrCollection<string> args { get; private set; }

        ///<summary>
        ///Return only messages with names that contain this string
        ///</summary>
        public string filter { get; private set; }

        ///<summary>
        ///Return only messages in this customisation state
        ///</summary>
        public allmessagescustomised customised { get; private set; }

        ///<summary>
        ///Return messages in this language
        ///</summary>
        public string lang { get; private set; }

        ///<summary>
        ///Return messages starting at this message
        ///</summary>
        public string from { get; private set; }

        ///<summary>
        ///Return messages ending at this message
        ///</summary>
        public string to { get; private set; }

        ///<summary>
        ///Page name to use as context when parsing message (for enableparser option)
        ///</summary>
        public string title { get; private set; }

        ///<summary>
        ///Return messages with this prefix
        ///</summary>
        public string prefix { get; private set; }

        private allmessagesWhere()
        {
        }
    }
}