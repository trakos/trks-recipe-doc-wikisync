using System;
using System.Collections.Generic;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;
using TrksRecipeDoc.MekaWiki.Entities;

namespace TrksRecipeDoc.MekaWiki
{
    public abstract class Page
    {
        private Page()
        {
        }

        private static readonly IDictionary<string, string[]> categoriesProps = new Dictionary<string, string[]>() { { "ns", new[] { "" } }, { "title", new[] { "" } }, { "sortkey", new[] { "sortkey" } }, { "sortkeyprefix", new[] { "sortkey" } }, { "timestamp", new[] { "timestamp" } }, { "hidden", new[] { "hidden" } } };
        private static readonly QueryTypeProperties<categoriesSelect> categoriesProperties = new QueryTypeProperties<categoriesSelect>("categories", "cl", QueryType.Prop, SortType.Ascending, new TupleList<string, string>() { }, categoriesProps, categoriesSelect.Parse);

        ///<summary>
        ///List all categories the page(s) belong to
        ///</summary>
        public abstract WikiQuerySortableGenerator<Page, categoriesWhere, categoriesOrderBy, categoriesSelect> categories();

        private static readonly IDictionary<string, string[]> categoryinfoProps = new Dictionary<string, string[]>() { { "size", new[] { "" } }, { "pages", new[] { "" } }, { "files", new[] { "" } }, { "subcats", new[] { "" } }, { "hidden", new[] { "" } } };
        private static readonly QueryTypeProperties<categoryinfoResult> categoryinfoProperties = new QueryTypeProperties<categoryinfoResult>("categoryinfo", "ci", QueryType.Prop, null, new TupleList<string, string>() { }, categoryinfoProps, categoryinfoResult.Parse);

        ///<summary>
        ///Returns information about the given categories
        ///</summary>
        public abstract categoryinfoResult categoryinfo { get; }

        private static readonly IDictionary<string, string[]> duplicatefilesProps = new Dictionary<string, string[]>() { { "name", new[] { "" } }, { "user", new[] { "" } }, { "timestamp", new[] { "" } }, { "shared", new[] { "" } } };
        private static readonly QueryTypeProperties<duplicatefilesSelect> duplicatefilesProperties = new QueryTypeProperties<duplicatefilesSelect>("duplicatefiles", "df", QueryType.Prop, SortType.Ascending, new TupleList<string, string>() { }, duplicatefilesProps, duplicatefilesSelect.Parse);

        ///<summary>
        ///List all files that are duplicates of the given file(s) based on hash values
        ///</summary>
        public abstract WikiQuerySortableGenerator<Page, duplicatefilesWhere, duplicatefilesOrderBy, duplicatefilesSelect> duplicatefiles();

        private static readonly IDictionary<string, string[]> extlinksProps = new Dictionary<string, string[]>() { { "*", new[] { "" } } };
        private static readonly QueryTypeProperties<extlinksSelect> extlinksProperties = new QueryTypeProperties<extlinksSelect>("extlinks", "el", QueryType.Prop, null, new TupleList<string, string>() { }, extlinksProps, extlinksSelect.Parse);

        ///<summary>
        ///Returns all external URLs (not interwikis) from the given page(s)
        ///</summary>
        public abstract WikiQuery<extlinksWhere, extlinksSelect> extlinks();

        private static readonly IDictionary<string, string[]> imageinfoProps = new Dictionary<string, string[]>() { { "timestamp", new[] { "timestamp" } }, { "userhidden", new[] { "user", "userid" } }, { "user", new[] { "user" } }, { "anon", new[] { "user", "userid" } }, { "userid", new[] { "userid" } }, { "size", new[] { "size", "dimensions" } }, { "width", new[] { "size", "dimensions" } }, { "height", new[] { "size", "dimensions" } }, { "pagecount", new[] { "size", "dimensions" } }, { "commenthidden", new[] { "comment", "parsedcomment" } }, { "comment", new[] { "comment" } }, { "parsedcomment", new[] { "parsedcomment" } }, { "filehidden", new[] { "url", "sha1", "mime", "thumbmime", "mediatype", "archivename", "bitdepth" } }, { "thumburl", new[] { "url" } }, { "thumbwidth", new[] { "url" } }, { "thumbheight", new[] { "url" } }, { "thumberror", new[] { "url" } }, { "url", new[] { "url" } }, { "descriptionurl", new[] { "url" } }, { "sha1", new[] { "sha1" } }, { "mime", new[] { "mime" } }, { "thumbmime", new[] { "thumbmime" } }, { "mediatype", new[] { "mediatype" } }, { "archivename", new[] { "archivename" } }, { "bitdepth", new[] { "bitdepth" } } };
        private static readonly QueryTypeProperties<imageinfoSelect> imageinfoProperties = new QueryTypeProperties<imageinfoSelect>("imageinfo", "ii", QueryType.Prop, null, new TupleList<string, string>() { }, imageinfoProps, imageinfoSelect.Parse);

        ///<summary>
        ///Returns image information and upload history
        ///</summary>
        public abstract WikiQuery<imageinfoWhere, imageinfoSelect> imageinfo();

        private static readonly IDictionary<string, string[]> imagesProps = new Dictionary<string, string[]>() { { "ns", new[] { "" } }, { "title", new[] { "" } } };
        private static readonly QueryTypeProperties<imagesSelect> imagesProperties = new QueryTypeProperties<imagesSelect>("images", "im", QueryType.Prop, SortType.Ascending, new TupleList<string, string>() { }, imagesProps, imagesSelect.Parse);

        ///<summary>
        ///Returns all images contained on the given page(s)
        ///</summary>
        public abstract WikiQuerySortableGenerator<Page, imagesWhere, imagesOrderBy, imagesSelect> images();

        private static readonly IDictionary<string, string[]> infoProps = new Dictionary<string, string[]>() { { "pageid", new[] { "" } }, { "ns", new[] { "" } }, { "title", new[] { "" } }, { "missing", new[] { "" } }, { "invalid", new[] { "" } }, { "special", new[] { "" } }, { "touched", new[] { "" } }, { "lastrevid", new[] { "" } }, { "counter", new[] { "" } }, { "length", new[] { "" } }, { "redirect", new[] { "" } }, { "new", new[] { "" } }, { "starttimestamp", new[] { "" } }, { "contentmodel", new[] { "" } }, { "edittoken", new[] { "" } }, { "deletetoken", new[] { "" } }, { "protecttoken", new[] { "" } }, { "movetoken", new[] { "" } }, { "blocktoken", new[] { "" } }, { "unblocktoken", new[] { "" } }, { "emailtoken", new[] { "" } }, { "importtoken", new[] { "" } }, { "watchtoken", new[] { "" } }, { "watched", new[] { "watched" } }, { "watchers", new[] { "watchers" } }, { "notificationtimestamp", new[] { "notificationtimestamp" } }, { "talkid", new[] { "talkid" } }, { "subjectid", new[] { "subjectid" } }, { "fullurl", new[] { "url" } }, { "editurl", new[] { "url" } }, { "readable", new[] { "readable" } }, { "preload", new[] { "preload" } }, { "displaytitle", new[] { "displaytitle" } } };
        private static readonly QueryTypeProperties<infoResult> infoProperties = new QueryTypeProperties<infoResult>("info", "in", QueryType.Prop, null, new TupleList<string, string>() { }, infoProps, infoResult.Parse);

        ///<summary>
        ///Get basic page information such as namespace, title, last touched date, ...
        ///</summary>
        public abstract infoResult info { get; }

        private static readonly IDictionary<string, string[]> iwlinksProps = new Dictionary<string, string[]>() { { "prefix", new[] { "" } }, { "url", new[] { "" } }, { "*", new[] { "" } } };
        private static readonly QueryTypeProperties<iwlinksSelect> iwlinksProperties = new QueryTypeProperties<iwlinksSelect>("iwlinks", "iw", QueryType.Prop, SortType.Ascending, new TupleList<string, string>() { }, iwlinksProps, iwlinksSelect.Parse);

        ///<summary>
        ///Returns all interwiki links from the given page(s)
        ///</summary>
        public abstract WikiQuerySortable<iwlinksWhere, iwlinksOrderBy, iwlinksSelect> iwlinks();

        private static readonly IDictionary<string, string[]> langlinksProps = new Dictionary<string, string[]>() { { "lang", new[] { "" } }, { "url", new[] { "" } }, { "*", new[] { "" } } };
        private static readonly QueryTypeProperties<langlinksSelect> langlinksProperties = new QueryTypeProperties<langlinksSelect>("langlinks", "ll", QueryType.Prop, SortType.Ascending, new TupleList<string, string>() { }, langlinksProps, langlinksSelect.Parse);

        ///<summary>
        ///Returns all interlanguage links from the given page(s)
        ///</summary>
        public abstract WikiQuerySortable<langlinksWhere, langlinksOrderBy, langlinksSelect> langlinks();

        private static readonly IDictionary<string, string[]> linksProps = new Dictionary<string, string[]>() { { "ns", new[] { "" } }, { "title", new[] { "" } } };
        private static readonly QueryTypeProperties<linksSelect> linksProperties = new QueryTypeProperties<linksSelect>("links", "pl", QueryType.Prop, SortType.Ascending, new TupleList<string, string>() { }, linksProps, linksSelect.Parse);

        ///<summary>
        ///Returns all links from the given page(s)
        ///</summary>
        public abstract WikiQuerySortableGenerator<Page, linksWhere, linksOrderBy, linksSelect> links();

        private static readonly IDictionary<string, string[]> revisionsProps = new Dictionary<string, string[]>() { { "rollbacktoken", new[] { "" } }, { "revid", new[] { "ids" } }, { "parentid", new[] { "ids" } }, { "minor", new[] { "flags" } }, { "userhidden", new[] { "user", "userid" } }, { "user", new[] { "user" } }, { "anon", new[] { "user", "userid" } }, { "userid", new[] { "userid" } }, { "timestamp", new[] { "timestamp" } }, { "size", new[] { "size" } }, { "sha1", new[] { "sha1" } }, { "commenthidden", new[] { "comment", "parsedcomment" } }, { "comment", new[] { "comment" } }, { "parsedcomment", new[] { "parsedcomment" } }, { "*", new[] { "content" } }, { "texthidden", new[] { "content" } }, { "textmissing", new[] { "content" } }, { "contentmodel", new[] { "contentmodel" } } };
        private static readonly QueryTypeProperties<revisionsSelect> revisionsProperties = new QueryTypeProperties<revisionsSelect>("revisions", "rv", QueryType.Prop, SortType.Newer, new TupleList<string, string>() { }, revisionsProps, revisionsSelect.Parse);

        ///<summary>
        ///Get revision information
        ///May be used in several ways:
        /// 1) Get data about a set of pages (last revision), by setting titles or pageids parameter
        /// 2) Get revisions for one given page, by using titles/pageids with start/end/limit params
        /// 3) Get data about a set of revisions by setting their IDs with revids parameter
        ///All parameters marked as (enum) may only be used with a single page (#2)
        ///</summary>
        public abstract WikiQuerySortable<revisionsWhere, revisionsOrderBy, revisionsSelect> revisions();

        private static readonly IDictionary<string, string[]> templatesProps = new Dictionary<string, string[]>() { { "ns", new[] { "" } }, { "title", new[] { "" } } };
        private static readonly QueryTypeProperties<templatesSelect> templatesProperties = new QueryTypeProperties<templatesSelect>("templates", "tl", QueryType.Prop, SortType.Ascending, new TupleList<string, string>() { }, templatesProps, templatesSelect.Parse);

        ///<summary>
        ///Returns all templates from the given page(s)
        ///</summary>
        public abstract WikiQuerySortableGenerator<Page, templatesWhere, templatesOrderBy, templatesSelect> templates();
    }
}