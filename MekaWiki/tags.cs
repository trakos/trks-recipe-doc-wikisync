using System;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class tagsSelect
    {
        public string name { get; private set; }
        public string displayname { get; private set; }
        public string description { get; private set; }
        public int hitcount { get; private set; }

        private tagsSelect()
        {
        }

        public static tagsSelect Parse(XElement element, WikiInfo wiki)
        {
            var result = new tagsSelect();
            var nameValue = element.Attribute("name");
            if (nameValue != null)
                result.name = ValueParser.ParseString(nameValue.Value);
            var displaynameValue = element.Attribute("displayname");
            if (displaynameValue != null)
                result.displayname = ValueParser.ParseString(displaynameValue.Value);
            var descriptionValue = element.Attribute("description");
            if (descriptionValue != null)
                result.description = ValueParser.ParseString(descriptionValue.Value);
            var hitcountValue = element.Attribute("hitcount");
            if (hitcountValue != null && hitcountValue.Value != "")
                result.hitcount = ValueParser.ParseInt32(hitcountValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("name: {0}; displayname: {1}; description: {2}; hitcount: {3}", name, displayname, description, hitcount);
        }
    }

    public sealed class tagsWhere
    {
        private tagsWhere()
        {
        }
    }
}