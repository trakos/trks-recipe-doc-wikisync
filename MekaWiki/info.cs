using System;
using System.Linq;
using System.Globalization;
using System.Xml.Linq;
using LinqToWiki;
using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki.Entities
{
    public sealed class infoResult
    {
        public long? pageid { get; private set; }
        public Namespace ns { get; private set; }
        public string title { get; private set; }
        public bool missing { get; private set; }
        public bool invalid { get; private set; }
        public bool special { get; private set; }
        public DateTime touched { get; private set; }
        public long lastrevid { get; private set; }
        public int? counter { get; private set; }
        public int length { get; private set; }
        public bool redirect { get; private set; }
        public bool @new { get; private set; }
        public DateTime? starttimestamp { get; private set; }
        public string contentmodel { get; private set; }
        public string edittoken { get; private set; }
        public string deletetoken { get; private set; }
        public string protecttoken { get; private set; }
        public string movetoken { get; private set; }
        public string blocktoken { get; private set; }
        public string unblocktoken { get; private set; }
        public string emailtoken { get; private set; }
        public string importtoken { get; private set; }
        public string watchtoken { get; private set; }
        public bool watched { get; private set; }
        public int? watchers { get; private set; }
        public DateTime? notificationtimestamp { get; private set; }
        public long? talkid { get; private set; }
        public long? subjectid { get; private set; }
        public string fullurl { get; private set; }
        public string editurl { get; private set; }
        public bool readable { get; private set; }
        public string preload { get; private set; }
        public string displaytitle { get; private set; }

        private infoResult()
        {
        }

        public static infoResult Parse(XElement element, WikiInfo wiki)
        {
            var result = new infoResult();
            var pageidValue = element.Attribute("pageid");
            if (pageidValue != null && pageidValue.Value != "")
                result.pageid = ValueParser.ParseInt64(pageidValue.Value);
            var nsValue = element.Attribute("ns");
            if (nsValue != null && nsValue.Value != "")
                result.ns = ValueParser.ParseNamespace(nsValue.Value, wiki);
            var titleValue = element.Attribute("title");
            if (titleValue != null)
                result.title = ValueParser.ParseString(titleValue.Value);
            var missingValue = element.Attribute("missing");
            if (missingValue != null)
                result.missing = ValueParser.ParseBoolean(missingValue.Value);
            var invalidValue = element.Attribute("invalid");
            if (invalidValue != null)
                result.invalid = ValueParser.ParseBoolean(invalidValue.Value);
            var specialValue = element.Attribute("special");
            if (specialValue != null)
                result.special = ValueParser.ParseBoolean(specialValue.Value);
            var touchedValue = element.Attribute("touched");
            if (touchedValue != null && touchedValue.Value != "")
                result.touched = ValueParser.ParseDateTime(touchedValue.Value);
            var lastrevidValue = element.Attribute("lastrevid");
            if (lastrevidValue != null && lastrevidValue.Value != "")
                result.lastrevid = ValueParser.ParseInt64(lastrevidValue.Value);
            var counterValue = element.Attribute("counter");
            if (counterValue != null && counterValue.Value != "")
                result.counter = ValueParser.ParseInt32(counterValue.Value);
            var lengthValue = element.Attribute("length");
            if (lengthValue != null && lengthValue.Value != "")
                result.length = ValueParser.ParseInt32(lengthValue.Value);
            var redirectValue = element.Attribute("redirect");
            if (redirectValue != null)
                result.redirect = ValueParser.ParseBoolean(redirectValue.Value);
            var newValue = element.Attribute("new");
            if (newValue != null)
                result.@new = ValueParser.ParseBoolean(newValue.Value);
            var starttimestampValue = element.Attribute("starttimestamp");
            if (starttimestampValue != null && starttimestampValue.Value != "")
                result.starttimestamp = ValueParser.ParseDateTime(starttimestampValue.Value);
            var contentmodelValue = element.Attribute("contentmodel");
            if (contentmodelValue != null)
                result.contentmodel = ValueParser.ParseString(contentmodelValue.Value);
            var edittokenValue = element.Attribute("edittoken");
            if (edittokenValue != null)
                result.edittoken = ValueParser.ParseString(edittokenValue.Value);
            var deletetokenValue = element.Attribute("deletetoken");
            if (deletetokenValue != null)
                result.deletetoken = ValueParser.ParseString(deletetokenValue.Value);
            var protecttokenValue = element.Attribute("protecttoken");
            if (protecttokenValue != null)
                result.protecttoken = ValueParser.ParseString(protecttokenValue.Value);
            var movetokenValue = element.Attribute("movetoken");
            if (movetokenValue != null)
                result.movetoken = ValueParser.ParseString(movetokenValue.Value);
            var blocktokenValue = element.Attribute("blocktoken");
            if (blocktokenValue != null)
                result.blocktoken = ValueParser.ParseString(blocktokenValue.Value);
            var unblocktokenValue = element.Attribute("unblocktoken");
            if (unblocktokenValue != null)
                result.unblocktoken = ValueParser.ParseString(unblocktokenValue.Value);
            var emailtokenValue = element.Attribute("emailtoken");
            if (emailtokenValue != null)
                result.emailtoken = ValueParser.ParseString(emailtokenValue.Value);
            var importtokenValue = element.Attribute("importtoken");
            if (importtokenValue != null)
                result.importtoken = ValueParser.ParseString(importtokenValue.Value);
            var watchtokenValue = element.Attribute("watchtoken");
            if (watchtokenValue != null)
                result.watchtoken = ValueParser.ParseString(watchtokenValue.Value);
            var watchedValue = element.Attribute("watched");
            if (watchedValue != null)
                result.watched = ValueParser.ParseBoolean(watchedValue.Value);
            var watchersValue = element.Attribute("watchers");
            if (watchersValue != null && watchersValue.Value != "")
                result.watchers = ValueParser.ParseInt32(watchersValue.Value);
            var notificationtimestampValue = element.Attribute("notificationtimestamp");
            if (notificationtimestampValue != null && notificationtimestampValue.Value != "")
                result.notificationtimestamp = ValueParser.ParseDateTime(notificationtimestampValue.Value);
            var talkidValue = element.Attribute("talkid");
            if (talkidValue != null && talkidValue.Value != "")
                result.talkid = ValueParser.ParseInt64(talkidValue.Value);
            var subjectidValue = element.Attribute("subjectid");
            if (subjectidValue != null && subjectidValue.Value != "")
                result.subjectid = ValueParser.ParseInt64(subjectidValue.Value);
            var fullurlValue = element.Attribute("fullurl");
            if (fullurlValue != null)
                result.fullurl = ValueParser.ParseString(fullurlValue.Value);
            var editurlValue = element.Attribute("editurl");
            if (editurlValue != null)
                result.editurl = ValueParser.ParseString(editurlValue.Value);
            var readableValue = element.Attribute("readable");
            if (readableValue != null)
                result.readable = ValueParser.ParseBoolean(readableValue.Value);
            var preloadValue = element.Attribute("preload");
            if (preloadValue != null)
                result.preload = ValueParser.ParseString(preloadValue.Value);
            var displaytitleValue = element.Attribute("displaytitle");
            if (displaytitleValue != null)
                result.displaytitle = ValueParser.ParseString(displaytitleValue.Value);
            return result;
        }

        public override string ToString()
        {
            return string.Format("pageid: {0}; ns: {1}; title: {2}; missing: {3}; invalid: {4}; special: {5}; touched: {6}; lastrevid: {7}; counter: {8}; length: {9}; redirect: {10}; new: {11}; starttimestamp: {12}; contentmodel: {13}; edittoken: {14}; deletetoken: {15}; protecttoken: {16}; movetoken: {17}; blocktoken: {18}; unblocktoken: {19}; emailtoken: {20}; importtoken: {21}; watchtoken: {22}; watched: {23}; watchers: {24}; notificationtimestamp: {25}; talkid: {26}; subjectid: {27}; fullurl: {28}; editurl: {29}; readable: {30}; preload: {31}; displaytitle: {32}", pageid, ns, title, missing, invalid, special, touched, lastrevid, counter, length, redirect, @new, starttimestamp, contentmodel, edittoken, deletetoken, protecttoken, movetoken, blocktoken, unblocktoken, emailtoken, importtoken, watchtoken, watched, watchers, notificationtimestamp, talkid, subjectid, fullurl, editurl, readable, preload, displaytitle);
        }
    }
}