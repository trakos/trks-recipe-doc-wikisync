using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class tokensResult
    {
        public string blocktoken { get; private set; }
        public string deletetoken { get; private set; }
        public string edittoken { get; private set; }
        public string emailtoken { get; private set; }
        public string importtoken { get; private set; }
        public string movetoken { get; private set; }
        public string optionstoken { get; private set; }
        public string patroltoken { get; private set; }
        public string protecttoken { get; private set; }
        public string unblocktoken { get; private set; }
        public string watchtoken { get; private set; }

        private tokensResult()
        {
        }

        public static tokensResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new tokensResult();
            var blocktokenValue = element.Attribute("blocktoken");
            if (blocktokenValue != null)
                result.blocktoken = ValueParser.ParseString(blocktokenValue.Value);
            var deletetokenValue = element.Attribute("deletetoken");
            if (deletetokenValue != null)
                result.deletetoken = ValueParser.ParseString(deletetokenValue.Value);
            var edittokenValue = element.Attribute("edittoken");
            if (edittokenValue != null)
                result.edittoken = ValueParser.ParseString(edittokenValue.Value);
            var emailtokenValue = element.Attribute("emailtoken");
            if (emailtokenValue != null)
                result.emailtoken = ValueParser.ParseString(emailtokenValue.Value);
            var importtokenValue = element.Attribute("importtoken");
            if (importtokenValue != null)
                result.importtoken = ValueParser.ParseString(importtokenValue.Value);
            var movetokenValue = element.Attribute("movetoken");
            if (movetokenValue != null)
                result.movetoken = ValueParser.ParseString(movetokenValue.Value);
            var optionstokenValue = element.Attribute("optionstoken");
            if (optionstokenValue != null)
                result.optionstoken = ValueParser.ParseString(optionstokenValue.Value);
            var patroltokenValue = element.Attribute("patroltoken");
            if (patroltokenValue != null)
                result.patroltoken = ValueParser.ParseString(patroltokenValue.Value);
            var protecttokenValue = element.Attribute("protecttoken");
            if (protecttokenValue != null)
                result.protecttoken = ValueParser.ParseString(protecttokenValue.Value);
            var unblocktokenValue = element.Attribute("unblocktoken");
            if (unblocktokenValue != null)
                result.unblocktoken = ValueParser.ParseString(unblocktokenValue.Value);
            var watchtokenValue = element.Attribute("watchtoken");
            if (watchtokenValue != null)
                result.watchtoken = ValueParser.ParseString(watchtokenValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("blocktoken: {0}; deletetoken: {1}; edittoken: {2}; emailtoken: {3}; importtoken: {4}; movetoken: {5}; optionstoken: {6}; patroltoken: {7}; protecttoken: {8}; unblocktoken: {9}; watchtoken: {10}", blocktoken, deletetoken, edittoken, emailtoken, importtoken, movetoken, optionstoken, patroltoken, protecttoken, unblocktoken, watchtoken);
        }
    }
}