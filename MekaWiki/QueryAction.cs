using System;
using System.Collections.Generic;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Parameters;
using LinqToWiki.Internals;
using TrksRecipeDoc.MekaWiki.Entities;

namespace TrksRecipeDoc.MekaWiki
{
    public sealed class QueryAction
    {
        private readonly WikiInfo m_wiki;

        internal QueryAction(WikiInfo wiki)
        {
            m_wiki = wiki;
        }

        private static readonly IDictionary<string, string[]> allcategoriesProps = new Dictionary<string, string[]>() { { "*", new[] { "" } }, { "size", new[] { "size" } }, { "pages", new[] { "size" } }, { "files", new[] { "size" } }, { "subcats", new[] { "size" } }, { "hidden", new[] { "hidden" } } };
        private static readonly QueryTypeProperties<allcategoriesSelect> allcategoriesProperties = new QueryTypeProperties<allcategoriesSelect>("allcategories", "ac", QueryType.List, SortType.Ascending, new TupleList<string, string>() { { "action", "query" }, { "list", "allcategories" } }, allcategoriesProps, allcategoriesSelect.Parse);

        ///<summary>
        ///Enumerate all categories
        ///</summary>
        public WikiQuerySortableGenerator<Page, allcategoriesWhere, allcategoriesOrderBy, allcategoriesSelect> allcategories()
        {
            var queryParameters = QueryParameters.Create<allcategoriesSelect>();
            return new WikiQuerySortableGenerator<Page, allcategoriesWhere, allcategoriesOrderBy, allcategoriesSelect>(new QueryProcessor<allcategoriesSelect>(m_wiki, allcategoriesProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> allfileusagesProps = new Dictionary<string, string[]>() { { "fromid", new[] { "ids" } }, { "ns", new[] { "title" } }, { "title", new[] { "title" } } };
        private static readonly QueryTypeProperties<allfileusagesSelect> allfileusagesProperties = new QueryTypeProperties<allfileusagesSelect>("allfileusages", "af", QueryType.List, SortType.Ascending, new TupleList<string, string>() { { "action", "query" }, { "list", "allfileusages" } }, allfileusagesProps, allfileusagesSelect.Parse);

        ///<summary>
        ///List all file usages, including non-existing
        ///</summary>
        public WikiQuerySortableGenerator<Page, allfileusagesWhere, allfileusagesOrderBy, allfileusagesSelect> allfileusages()
        {
            var queryParameters = QueryParameters.Create<allfileusagesSelect>();
            return new WikiQuerySortableGenerator<Page, allfileusagesWhere, allfileusagesOrderBy, allfileusagesSelect>(new QueryProcessor<allfileusagesSelect>(m_wiki, allfileusagesProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> allimagesProps = new Dictionary<string, string[]>() { { "name", new[] { "" } }, { "ns", new[] { "" } }, { "title", new[] { "" } }, { "timestamp", new[] { "timestamp" } }, { "userhidden", new[] { "user", "userid" } }, { "user", new[] { "user" } }, { "anon", new[] { "user", "userid" } }, { "userid", new[] { "userid" } }, { "size", new[] { "size", "dimensions" } }, { "width", new[] { "size", "dimensions" } }, { "height", new[] { "size", "dimensions" } }, { "pagecount", new[] { "size", "dimensions" } }, { "commenthidden", new[] { "comment", "parsedcomment" } }, { "comment", new[] { "comment" } }, { "parsedcomment", new[] { "parsedcomment" } }, { "filehidden", new[] { "url", "sha1", "mime", "mediatype", "bitdepth" } }, { "thumburl", new[] { "url" } }, { "thumbwidth", new[] { "url" } }, { "thumbheight", new[] { "url" } }, { "thumberror", new[] { "url" } }, { "url", new[] { "url" } }, { "descriptionurl", new[] { "url" } }, { "sha1", new[] { "sha1" } }, { "mime", new[] { "mime" } }, { "mediatype", new[] { "mediatype" } }, { "bitdepth", new[] { "bitdepth" } } };
        private static readonly QueryTypeProperties<allimagesSelect> allimagesProperties = new QueryTypeProperties<allimagesSelect>("allimages", "ai", QueryType.List, SortType.Ascending, new TupleList<string, string>() { { "action", "query" }, { "list", "allimages" } }, allimagesProps, allimagesSelect.Parse);

        ///<summary>
        ///Enumerate all images sequentially
        ///</summary>
        public WikiQuerySortableGenerator<Page, allimagesWhere, allimagesOrderBy, allimagesSelect> allimages()
        {
            var queryParameters = QueryParameters.Create<allimagesSelect>();
            return new WikiQuerySortableGenerator<Page, allimagesWhere, allimagesOrderBy, allimagesSelect>(new QueryProcessor<allimagesSelect>(m_wiki, allimagesProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> alllinksProps = new Dictionary<string, string[]>() { { "fromid", new[] { "ids" } }, { "ns", new[] { "title" } }, { "title", new[] { "title" } } };
        private static readonly QueryTypeProperties<alllinksSelect> alllinksProperties = new QueryTypeProperties<alllinksSelect>("alllinks", "al", QueryType.List, SortType.Ascending, new TupleList<string, string>() { { "action", "query" }, { "list", "alllinks" } }, alllinksProps, alllinksSelect.Parse);

        ///<summary>
        ///Enumerate all links that point to a given namespace
        ///</summary>
        public WikiQuerySortableGenerator<Page, alllinksWhere, alllinksOrderBy, alllinksSelect> alllinks()
        {
            var queryParameters = QueryParameters.Create<alllinksSelect>();
            return new WikiQuerySortableGenerator<Page, alllinksWhere, alllinksOrderBy, alllinksSelect>(new QueryProcessor<alllinksSelect>(m_wiki, alllinksProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> allmessagesProps = new Dictionary<string, string[]>() { { "name", new[] { "" } }, { "customised", new[] { "" } }, { "missing", new[] { "" } }, { "*", new[] { "" } }, { "defaultmissing", new[] { "default" } }, { "default", new[] { "default" } } };
        private static readonly QueryTypeProperties<allmessagesSelect> allmessagesProperties = new QueryTypeProperties<allmessagesSelect>("allmessages", "am", QueryType.Meta, null, new TupleList<string, string>() { { "action", "query" }, { "meta", "allmessages" } }, allmessagesProps, allmessagesSelect.Parse);

        ///<summary>
        ///Return messages from this site
        ///</summary>
        public WikiQuery<allmessagesWhere, allmessagesSelect> allmessages()
        {
            var queryParameters = QueryParameters.Create<allmessagesSelect>();
            return new WikiQuery<allmessagesWhere, allmessagesSelect>(new QueryProcessor<allmessagesSelect>(m_wiki, allmessagesProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> allpagesProps = new Dictionary<string, string[]>() { { "pageid", new[] { "" } }, { "ns", new[] { "" } }, { "title", new[] { "" } } };
        private static readonly QueryTypeProperties<allpagesSelect> allpagesProperties = new QueryTypeProperties<allpagesSelect>("allpages", "ap", QueryType.List, SortType.Ascending, new TupleList<string, string>() { { "action", "query" }, { "list", "allpages" } }, allpagesProps, allpagesSelect.Parse);

        ///<summary>
        ///Enumerate all pages sequentially in a given namespace
        ///</summary>
        public WikiQuerySortableGenerator<Page, allpagesWhere, allpagesOrderBy, allpagesSelect> allpages()
        {
            var queryParameters = QueryParameters.Create<allpagesSelect>();
            return new WikiQuerySortableGenerator<Page, allpagesWhere, allpagesOrderBy, allpagesSelect>(new QueryProcessor<allpagesSelect>(m_wiki, allpagesProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> alltransclusionsProps = new Dictionary<string, string[]>() { { "fromid", new[] { "ids" } }, { "ns", new[] { "title" } }, { "title", new[] { "title" } } };
        private static readonly QueryTypeProperties<alltransclusionsSelect> alltransclusionsProperties = new QueryTypeProperties<alltransclusionsSelect>("alltransclusions", "at", QueryType.List, SortType.Ascending, new TupleList<string, string>() { { "action", "query" }, { "list", "alltransclusions" } }, alltransclusionsProps, alltransclusionsSelect.Parse);

        ///<summary>
        ///List all transclusions (pages embedded using {{x}}), including non-existing
        ///</summary>
        public WikiQuerySortableGenerator<Page, alltransclusionsWhere, alltransclusionsOrderBy, alltransclusionsSelect> alltransclusions()
        {
            var queryParameters = QueryParameters.Create<alltransclusionsSelect>();
            return new WikiQuerySortableGenerator<Page, alltransclusionsWhere, alltransclusionsOrderBy, alltransclusionsSelect>(new QueryProcessor<alltransclusionsSelect>(m_wiki, alltransclusionsProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> allusersProps = new Dictionary<string, string[]>() { { "userid", new[] { "" } }, { "name", new[] { "" } }, { "recenteditcount", new[] { "" } }, { "blockid", new[] { "blockinfo" } }, { "blockedby", new[] { "blockinfo" } }, { "blockedbyid", new[] { "blockinfo" } }, { "blockedreason", new[] { "blockinfo" } }, { "blockedexpiry", new[] { "blockinfo" } }, { "hidden", new[] { "blockinfo" } }, { "editcount", new[] { "editcount" } }, { "registration", new[] { "registration" } } };
        private static readonly QueryTypeProperties<allusersSelect> allusersProperties = new QueryTypeProperties<allusersSelect>("allusers", "au", QueryType.List, SortType.Ascending, new TupleList<string, string>() { { "action", "query" }, { "list", "allusers" } }, allusersProps, allusersSelect.Parse);

        ///<summary>
        ///Enumerate all registered users
        ///</summary>
        public WikiQuerySortable<allusersWhere, allusersOrderBy, allusersSelect> allusers()
        {
            var queryParameters = QueryParameters.Create<allusersSelect>();
            return new WikiQuerySortable<allusersWhere, allusersOrderBy, allusersSelect>(new QueryProcessor<allusersSelect>(m_wiki, allusersProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> backlinksProps = new Dictionary<string, string[]>() { { "pageid", new[] { "" } }, { "ns", new[] { "" } }, { "title", new[] { "" } }, { "redirect", new[] { "" } } };
        private static readonly QueryTypeProperties<backlinksSelect> backlinksProperties = new QueryTypeProperties<backlinksSelect>("backlinks", "bl", QueryType.List, SortType.Ascending, new TupleList<string, string>() { { "action", "query" }, { "list", "backlinks" } }, backlinksProps, backlinksSelect.Parse);

        ///<summary>
        ///Find all pages that link to the given page
        ///</summary>
        public WikiQuerySortableGenerator<Page, backlinksWhere, backlinksOrderBy, backlinksSelect> backlinks()
        {
            var queryParameters = QueryParameters.Create<backlinksSelect>();
            return new WikiQuerySortableGenerator<Page, backlinksWhere, backlinksOrderBy, backlinksSelect>(new QueryProcessor<backlinksSelect>(m_wiki, backlinksProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> blocksProps = new Dictionary<string, string[]>() { { "id", new[] { "id" } }, { "user", new[] { "user" } }, { "userid", new[] { "userid" } }, { "by", new[] { "by" } }, { "byid", new[] { "byid" } }, { "timestamp", new[] { "timestamp" } }, { "expiry", new[] { "expiry" } }, { "reason", new[] { "reason" } }, { "rangestart", new[] { "range" } }, { "rangeend", new[] { "range" } }, { "automatic", new[] { "flags" } }, { "anononly", new[] { "flags" } }, { "nocreate", new[] { "flags" } }, { "autoblock", new[] { "flags" } }, { "noemail", new[] { "flags" } }, { "hidden", new[] { "flags" } }, { "allowusertalk", new[] { "flags" } } };
        private static readonly QueryTypeProperties<blocksSelect> blocksProperties = new QueryTypeProperties<blocksSelect>("blocks", "bk", QueryType.List, SortType.Newer, new TupleList<string, string>() { { "action", "query" }, { "list", "blocks" } }, blocksProps, blocksSelect.Parse);

        ///<summary>
        ///List all blocked users and IP addresses
        ///</summary>
        public WikiQuerySortable<blocksWhere, blocksOrderBy, blocksSelect> blocks()
        {
            var queryParameters = QueryParameters.Create<blocksSelect>();
            return new WikiQuerySortable<blocksWhere, blocksOrderBy, blocksSelect>(new QueryProcessor<blocksSelect>(m_wiki, blocksProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> categorymembersProps = new Dictionary<string, string[]>() { { "pageid", new[] { "ids" } }, { "ns", new[] { "title" } }, { "title", new[] { "title" } }, { "sortkey", new[] { "sortkey" } }, { "sortkeyprefix", new[] { "sortkeyprefix" } }, { "type", new[] { "type" } }, { "timestamp", new[] { "timestamp" } } };
        private static readonly QueryTypeProperties<categorymembersSelect> categorymembersProperties = new QueryTypeProperties<categorymembersSelect>("categorymembers", "cm", QueryType.List, SortType.Ascending, new TupleList<string, string>() { { "action", "query" }, { "list", "categorymembers" } }, categorymembersProps, categorymembersSelect.Parse);

        ///<summary>
        ///List all pages in a given category
        ///</summary>
        public WikiQuerySortableGenerator<Page, categorymembersWhere, categorymembersOrderBy, categorymembersSelect> categorymembers()
        {
            var queryParameters = QueryParameters.Create<categorymembersSelect>();
            return new WikiQuerySortableGenerator<Page, categorymembersWhere, categorymembersOrderBy, categorymembersSelect>(new QueryProcessor<categorymembersSelect>(m_wiki, categorymembersProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> deletedrevsProps = new Dictionary<string, string[]>() { { "ns", new[] { "" } }, { "title", new[] { "" } }, { "token", new[] { "token" } } };
        private static readonly QueryTypeProperties<deletedrevsSelect> deletedrevsProperties = new QueryTypeProperties<deletedrevsSelect>("deletedrevs", "dr", QueryType.List, SortType.Newer, new TupleList<string, string>() { { "action", "query" }, { "list", "deletedrevs" } }, deletedrevsProps, deletedrevsSelect.Parse);

        ///<summary>
        ///List deleted revisions.
        ///Operates in three modes:
        /// 1) List deleted revisions for the given title(s), sorted by timestamp
        /// 2) List deleted contributions for the given user, sorted by timestamp (no titles specified)
        /// 3) List all deleted revisions in the given namespace, sorted by title and timestamp (no titles specified, druser not set)
        ///Certain parameters only apply to some modes and are ignored in others.
        ///For instance, a parameter marked (1) only applies to mode 1 and is ignored in modes 2 and 3
        ///</summary>
        public WikiQuerySortable<deletedrevsWhere, deletedrevsOrderBy, deletedrevsSelect> deletedrevs()
        {
            var queryParameters = QueryParameters.Create<deletedrevsSelect>();
            return new WikiQuerySortable<deletedrevsWhere, deletedrevsOrderBy, deletedrevsSelect>(new QueryProcessor<deletedrevsSelect>(m_wiki, deletedrevsProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> embeddedinProps = new Dictionary<string, string[]>() { { "pageid", new[] { "" } }, { "ns", new[] { "" } }, { "title", new[] { "" } }, { "redirect", new[] { "" } } };
        private static readonly QueryTypeProperties<embeddedinSelect> embeddedinProperties = new QueryTypeProperties<embeddedinSelect>("embeddedin", "ei", QueryType.List, SortType.Ascending, new TupleList<string, string>() { { "action", "query" }, { "list", "embeddedin" } }, embeddedinProps, embeddedinSelect.Parse);

        ///<summary>
        ///Find all pages that embed (transclude) the given title
        ///</summary>
        public WikiQuerySortableGenerator<Page, embeddedinWhere, embeddedinOrderBy, embeddedinSelect> embeddedin()
        {
            var queryParameters = QueryParameters.Create<embeddedinSelect>();
            return new WikiQuerySortableGenerator<Page, embeddedinWhere, embeddedinOrderBy, embeddedinSelect>(new QueryProcessor<embeddedinSelect>(m_wiki, embeddedinProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> exturlusageProps = new Dictionary<string, string[]>() { { "pageid", new[] { "ids" } }, { "ns", new[] { "title" } }, { "title", new[] { "title" } }, { "url", new[] { "url" } } };
        private static readonly QueryTypeProperties<exturlusageSelect> exturlusageProperties = new QueryTypeProperties<exturlusageSelect>("exturlusage", "eu", QueryType.List, null, new TupleList<string, string>() { { "action", "query" }, { "list", "exturlusage" } }, exturlusageProps, exturlusageSelect.Parse);

        ///<summary>
        ///Enumerate pages that contain a given URL
        ///</summary>
        public WikiQueryGenerator<Page, exturlusageWhere, exturlusageSelect> exturlusage()
        {
            var queryParameters = QueryParameters.Create<exturlusageSelect>();
            return new WikiQueryGenerator<Page, exturlusageWhere, exturlusageSelect>(new QueryProcessor<exturlusageSelect>(m_wiki, exturlusageProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> filearchiveProps = new Dictionary<string, string[]>() { { "name", new[] { "" } }, { "ns", new[] { "" } }, { "title", new[] { "" } }, { "filehidden", new[] { "" } }, { "commenthidden", new[] { "" } }, { "userhidden", new[] { "" } }, { "suppressed", new[] { "" } }, { "sha1", new[] { "sha1" } }, { "timestamp", new[] { "timestamp" } }, { "userid", new[] { "user" } }, { "user", new[] { "user" } }, { "size", new[] { "size", "dimensions" } }, { "pagecount", new[] { "size", "dimensions" } }, { "height", new[] { "size", "dimensions" } }, { "width", new[] { "size", "dimensions" } }, { "description", new[] { "description", "parseddescription" } }, { "parseddescription", new[] { "parseddescription" } }, { "metadata", new[] { "metadata" } }, { "bitdepth", new[] { "bitdepth" } }, { "mime", new[] { "mime" } }, { "mediatype", new[] { "mediatype" } }, { "archivename", new[] { "archivename" } } };
        private static readonly QueryTypeProperties<filearchiveSelect> filearchiveProperties = new QueryTypeProperties<filearchiveSelect>("filearchive", "fa", QueryType.List, SortType.Ascending, new TupleList<string, string>() { { "action", "query" }, { "list", "filearchive" } }, filearchiveProps, filearchiveSelect.Parse);

        ///<summary>
        ///Enumerate all deleted files sequentially
        ///</summary>
        public WikiQuerySortable<filearchiveWhere, filearchiveOrderBy, filearchiveSelect> filearchive()
        {
            var queryParameters = QueryParameters.Create<filearchiveSelect>();
            return new WikiQuerySortable<filearchiveWhere, filearchiveOrderBy, filearchiveSelect>(new QueryProcessor<filearchiveSelect>(m_wiki, filearchiveProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> imageusageProps = new Dictionary<string, string[]>() { { "pageid", new[] { "" } }, { "ns", new[] { "" } }, { "title", new[] { "" } }, { "redirect", new[] { "" } } };
        private static readonly QueryTypeProperties<imageusageSelect> imageusageProperties = new QueryTypeProperties<imageusageSelect>("imageusage", "iu", QueryType.List, SortType.Ascending, new TupleList<string, string>() { { "action", "query" }, { "list", "imageusage" } }, imageusageProps, imageusageSelect.Parse);

        ///<summary>
        ///Find all pages that use the given image title.
        ///</summary>
        public WikiQuerySortableGenerator<Page, imageusageWhere, imageusageOrderBy, imageusageSelect> imageusage()
        {
            var queryParameters = QueryParameters.Create<imageusageSelect>();
            return new WikiQuerySortableGenerator<Page, imageusageWhere, imageusageOrderBy, imageusageSelect>(new QueryProcessor<imageusageSelect>(m_wiki, imageusageProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> iwbacklinksProps = new Dictionary<string, string[]>() { { "pageid", new[] { "" } }, { "ns", new[] { "" } }, { "title", new[] { "" } }, { "redirect", new[] { "" } }, { "iwprefix", new[] { "iwprefix" } }, { "iwtitle", new[] { "iwtitle" } } };
        private static readonly QueryTypeProperties<iwbacklinksSelect> iwbacklinksProperties = new QueryTypeProperties<iwbacklinksSelect>("iwbacklinks", "iwbl", QueryType.List, SortType.Ascending, new TupleList<string, string>() { { "action", "query" }, { "list", "iwbacklinks" } }, iwbacklinksProps, iwbacklinksSelect.Parse);

        ///<summary>
        ///Find all pages that link to the given interwiki link.
        ///Can be used to find all links with a prefix, or
        ///all links to a title (with a given prefix).
        ///Using neither parameter is effectively "All IW Links"
        ///</summary>
        public WikiQuerySortableGenerator<Page, iwbacklinksWhere, iwbacklinksOrderBy, iwbacklinksSelect> iwbacklinks()
        {
            var queryParameters = QueryParameters.Create<iwbacklinksSelect>();
            return new WikiQuerySortableGenerator<Page, iwbacklinksWhere, iwbacklinksOrderBy, iwbacklinksSelect>(new QueryProcessor<iwbacklinksSelect>(m_wiki, iwbacklinksProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> langbacklinksProps = new Dictionary<string, string[]>() { { "pageid", new[] { "" } }, { "ns", new[] { "" } }, { "title", new[] { "" } }, { "redirect", new[] { "" } }, { "lllang", new[] { "lllang" } }, { "lltitle", new[] { "lltitle" } } };
        private static readonly QueryTypeProperties<langbacklinksSelect> langbacklinksProperties = new QueryTypeProperties<langbacklinksSelect>("langbacklinks", "lbl", QueryType.List, SortType.Ascending, new TupleList<string, string>() { { "action", "query" }, { "list", "langbacklinks" } }, langbacklinksProps, langbacklinksSelect.Parse);

        ///<summary>
        ///Find all pages that link to the given language link.
        ///Can be used to find all links with a language code, or
        ///all links to a title (with a given language).
        ///Using neither parameter is effectively "All Language Links".
        ///Note that this may not consider language links added by extensions.
        ///</summary>
        public WikiQuerySortableGenerator<Page, langbacklinksWhere, langbacklinksOrderBy, langbacklinksSelect> langbacklinks()
        {
            var queryParameters = QueryParameters.Create<langbacklinksSelect>();
            return new WikiQuerySortableGenerator<Page, langbacklinksWhere, langbacklinksOrderBy, langbacklinksSelect>(new QueryProcessor<langbacklinksSelect>(m_wiki, langbacklinksProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> logeventsProps = new Dictionary<string, string[]>() { { "logid", new[] { "ids" } }, { "pageid", new[] { "ids" } }, { "ns", new[] { "title" } }, { "title", new[] { "title" } }, { "type", new[] { "type" } }, { "action", new[] { "type" } }, { "actionhidden", new[] { "details" } }, { "userhidden", new[] { "user", "userid" } }, { "user", new[] { "user" } }, { "anon", new[] { "user", "userid" } }, { "userid", new[] { "userid" } }, { "timestamp", new[] { "timestamp" } }, { "commenthidden", new[] { "comment", "parsedcomment" } }, { "comment", new[] { "comment" } }, { "parsedcomment", new[] { "parsedcomment" } } };
        private static readonly QueryTypeProperties<logeventsSelect> logeventsProperties = new QueryTypeProperties<logeventsSelect>("logevents", "le", QueryType.List, SortType.Newer, new TupleList<string, string>() { { "action", "query" }, { "list", "logevents" } }, logeventsProps, logeventsSelect.Parse);

        ///<summary>
        ///Get events from logs
        ///</summary>
        public WikiQuerySortable<logeventsWhere, logeventsOrderBy, logeventsSelect> logevents()
        {
            var queryParameters = QueryParameters.Create<logeventsSelect>();
            return new WikiQuerySortable<logeventsWhere, logeventsOrderBy, logeventsSelect>(new QueryProcessor<logeventsSelect>(m_wiki, logeventsProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> protectedtitlesProps = new Dictionary<string, string[]>() { { "ns", new[] { "" } }, { "title", new[] { "" } }, { "timestamp", new[] { "timestamp" } }, { "user", new[] { "user" } }, { "userid", new[] { "user", "userid" } }, { "comment", new[] { "comment" } }, { "parsedcomment", new[] { "parsedcomment" } }, { "expiry", new[] { "expiry" } }, { "level", new[] { "level" } } };
        private static readonly QueryTypeProperties<protectedtitlesSelect> protectedtitlesProperties = new QueryTypeProperties<protectedtitlesSelect>("protectedtitles", "pt", QueryType.List, SortType.Newer, new TupleList<string, string>() { { "action", "query" }, { "list", "protectedtitles" } }, protectedtitlesProps, protectedtitlesSelect.Parse);

        ///<summary>
        ///List all titles protected from creation
        ///</summary>
        public WikiQuerySortableGenerator<Page, protectedtitlesWhere, protectedtitlesOrderBy, protectedtitlesSelect> protectedtitles()
        {
            var queryParameters = QueryParameters.Create<protectedtitlesSelect>();
            return new WikiQuerySortableGenerator<Page, protectedtitlesWhere, protectedtitlesOrderBy, protectedtitlesSelect>(new QueryProcessor<protectedtitlesSelect>(m_wiki, protectedtitlesProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> querypageProps = new Dictionary<string, string[]>() { { "value", new[] { "" } }, { "timestamp", new[] { "" } }, { "ns", new[] { "" } }, { "title", new[] { "" } } };
        private static readonly QueryTypeProperties<querypageSelect> querypageProperties = new QueryTypeProperties<querypageSelect>("querypage", "qp", QueryType.List, null, new TupleList<string, string>() { { "action", "query" }, { "list", "querypage" } }, querypageProps, querypageSelect.Parse);

        ///<summary>
        ///Get a list provided by a QueryPage-based special page
        ///</summary>
        ///<param name="page">
        ///The name of the special page. Note, this is case sensitive
        ///</param >
        public WikiQueryGenerator<Page, querypageWhere, querypageSelect> querypage(querypagepage page)
        {
            var queryParameters = QueryParameters.Create<querypageSelect>();
            queryParameters = queryParameters.AddSingleValue("page", page.ToQueryString());
            return new WikiQueryGenerator<Page, querypageWhere, querypageSelect>(new QueryProcessor<querypageSelect>(m_wiki, querypageProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> randomProps = new Dictionary<string, string[]>() { { "id", new[] { "" } }, { "ns", new[] { "" } }, { "title", new[] { "" } } };
        private static readonly QueryTypeProperties<randomSelect> randomProperties = new QueryTypeProperties<randomSelect>("random", "rn", QueryType.List, null, new TupleList<string, string>() { { "action", "query" }, { "list", "random" } }, randomProps, randomSelect.Parse);

        ///<summary>
        ///Get a set of random pages
        ///NOTE: Pages are listed in a fixed sequence, only the starting point is random. This means that if, for example, "Main Page" is the first
        ///      random page on your list, "List of fictional monkeys" will *always* be second, "List of people on stamps of Vanuatu" third, etc
        ///NOTE: If the number of pages in the namespace is lower than rnlimit, you will get fewer pages. You will not get the same page twice
        ///</summary>
        public WikiQueryGenerator<Page, randomWhere, randomSelect> random()
        {
            var queryParameters = QueryParameters.Create<randomSelect>();
            return new WikiQueryGenerator<Page, randomWhere, randomSelect>(new QueryProcessor<randomSelect>(m_wiki, randomProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> recentchangesProps = new Dictionary<string, string[]>() { { "type", new[] { "" } }, { "patroltoken", new[] { "" } }, { "ns", new[] { "title" } }, { "title", new[] { "title" } }, { "new_ns", new[] { "title" } }, { "new_title", new[] { "title" } }, { "rcid", new[] { "ids" } }, { "pageid", new[] { "ids" } }, { "revid", new[] { "ids" } }, { "old_revid", new[] { "ids" } }, { "user", new[] { "user" } }, { "anon", new[] { "user", "userid" } }, { "userid", new[] { "userid" } }, { "bot", new[] { "flags" } }, { "new", new[] { "flags" } }, { "minor", new[] { "flags" } }, { "oldlen", new[] { "sizes" } }, { "newlen", new[] { "sizes" } }, { "timestamp", new[] { "timestamp" } }, { "comment", new[] { "comment" } }, { "parsedcomment", new[] { "parsedcomment" } }, { "redirect", new[] { "redirect" } }, { "patrolled", new[] { "patrolled" } }, { "logid", new[] { "loginfo" } }, { "logtype", new[] { "loginfo" } }, { "logaction", new[] { "loginfo" } }, { "sha1", new[] { "sha1" } }, { "sha1hidden", new[] { "sha1" } } };
        private static readonly QueryTypeProperties<recentchangesSelect> recentchangesProperties = new QueryTypeProperties<recentchangesSelect>("recentchanges", "rc", QueryType.List, SortType.Newer, new TupleList<string, string>() { { "action", "query" }, { "list", "recentchanges" } }, recentchangesProps, recentchangesSelect.Parse);

        ///<summary>
        ///Enumerate recent changes
        ///</summary>
        public WikiQuerySortableGenerator<Page, recentchangesWhere, recentchangesOrderBy, recentchangesSelect> recentchanges()
        {
            var queryParameters = QueryParameters.Create<recentchangesSelect>();
            return new WikiQuerySortableGenerator<Page, recentchangesWhere, recentchangesOrderBy, recentchangesSelect>(new QueryProcessor<recentchangesSelect>(m_wiki, recentchangesProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> searchProps = new Dictionary<string, string[]>() { { "ns", new[] { "" } }, { "title", new[] { "" } }, { "snippet", new[] { "snippet" } }, { "size", new[] { "size" } }, { "wordcount", new[] { "wordcount" } }, { "timestamp", new[] { "timestamp" } }, { "score", new[] { "score" } }, { "titlesnippet", new[] { "titlesnippet" } }, { "redirecttitle", new[] { "redirecttitle" } }, { "redirectsnippet", new[] { "redirectsnippet" } }, { "sectiontitle", new[] { "sectiontitle" } }, { "sectionsnippet", new[] { "sectionsnippet" } }, { "hasrelated", new[] { "hasrelated" } } };
        private static readonly QueryTypeProperties<searchSelect> searchProperties = new QueryTypeProperties<searchSelect>("search", "sr", QueryType.List, null, new TupleList<string, string>() { { "action", "query" }, { "list", "search" } }, searchProps, searchSelect.Parse);

        ///<summary>
        ///Perform a full text search
        ///</summary>
        ///<param name="search">
        ///Search for all page titles (or content) that has this value
        ///</param >
        public WikiQueryGenerator<Page, searchWhere, searchSelect> search(string search)
        {
            var queryParameters = QueryParameters.Create<searchSelect>();
            queryParameters = queryParameters.AddSingleValue("search", search.ToQueryString());
            return new WikiQueryGenerator<Page, searchWhere, searchSelect>(new QueryProcessor<searchSelect>(m_wiki, searchProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> tagsProps = new Dictionary<string, string[]>() { { "name", new[] { "" } }, { "displayname", new[] { "displayname" } }, { "description", new[] { "description" } }, { "hitcount", new[] { "hitcount" } } };
        private static readonly QueryTypeProperties<tagsSelect> tagsProperties = new QueryTypeProperties<tagsSelect>("tags", "tg", QueryType.List, null, new TupleList<string, string>() { { "action", "query" }, { "list", "tags" } }, tagsProps, tagsSelect.Parse);

        ///<summary>
        ///List change tags
        ///</summary>
        public WikiQuery<tagsWhere, tagsSelect> tags()
        {
            var queryParameters = QueryParameters.Create<tagsSelect>();
            return new WikiQuery<tagsWhere, tagsSelect>(new QueryProcessor<tagsSelect>(m_wiki, tagsProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> usercontribsProps = new Dictionary<string, string[]>() { { "userid", new[] { "" } }, { "user", new[] { "" } }, { "userhidden", new[] { "" } }, { "pageid", new[] { "ids" } }, { "revid", new[] { "ids" } }, { "parentid", new[] { "ids" } }, { "ns", new[] { "title" } }, { "title", new[] { "title" } }, { "timestamp", new[] { "timestamp" } }, { "new", new[] { "flags" } }, { "minor", new[] { "flags" } }, { "top", new[] { "flags" } }, { "commenthidden", new[] { "comment", "parsedcomment" } }, { "comment", new[] { "comment" } }, { "parsedcomment", new[] { "parsedcomment" } }, { "patrolled", new[] { "patrolled" } }, { "size", new[] { "size" } }, { "sizediff", new[] { "sizediff" } } };
        private static readonly QueryTypeProperties<usercontribsSelect> usercontribsProperties = new QueryTypeProperties<usercontribsSelect>("usercontribs", "uc", QueryType.List, SortType.Newer, new TupleList<string, string>() { { "action", "query" }, { "list", "usercontribs" } }, usercontribsProps, usercontribsSelect.Parse);

        ///<summary>
        ///Get all edits by a user
        ///</summary>
        public WikiQuerySortable<usercontribsWhere, usercontribsOrderBy, usercontribsSelect> usercontribs()
        {
            var queryParameters = QueryParameters.Create<usercontribsSelect>();
            return new WikiQuerySortable<usercontribsWhere, usercontribsOrderBy, usercontribsSelect>(new QueryProcessor<usercontribsSelect>(m_wiki, usercontribsProperties), queryParameters);
        }

        private static readonly QueryTypeProperties<userinfoResult> userinfoProperties = new QueryTypeProperties<userinfoResult>("userinfo", "ui", QueryType.Meta, null, new TupleList<string, string>() { { "action", "query" }, { "meta", "userinfo" }, { "uiprop", "blockinfo|hasmsg|preferencestoken|editcount|realname|email|registrationdate" } }, null, userinfoResult.Parse);

        ///<summary>
        ///Get information about the current user
        ///</summary>
        public userinfoResult userinfo()
        {
            var queryParameters = QueryParameters.Create<userinfoResult>();
            return new QueryProcessor<userinfoResult>(m_wiki, userinfoProperties).ExecuteSingle(queryParameters);
        }

        private static readonly IDictionary<string, string[]> usersProps = new Dictionary<string, string[]>() { { "userid", new[] { "" } }, { "name", new[] { "" } }, { "invalid", new[] { "" } }, { "hidden", new[] { "" } }, { "interwiki", new[] { "" } }, { "missing", new[] { "" } }, { "userrightstoken", new[] { "" } }, { "editcount", new[] { "editcount" } }, { "registration", new[] { "registration" } }, { "blockid", new[] { "blockinfo" } }, { "blockedby", new[] { "blockinfo" } }, { "blockedbyid", new[] { "blockinfo" } }, { "blockedreason", new[] { "blockinfo" } }, { "blockedexpiry", new[] { "blockinfo" } }, { "emailable", new[] { "emailable" } }, { "gender", new[] { "gender" } } };
        private static readonly QueryTypeProperties<usersSelect> usersProperties = new QueryTypeProperties<usersSelect>("users", "us", QueryType.List, null, new TupleList<string, string>() { { "action", "query" }, { "list", "users" } }, usersProps, usersSelect.Parse);

        ///<summary>
        ///Get information about a list of users
        ///</summary>
        public WikiQuery<usersWhere, usersSelect> users()
        {
            var queryParameters = QueryParameters.Create<usersSelect>();
            return new WikiQuery<usersWhere, usersSelect>(new QueryProcessor<usersSelect>(m_wiki, usersProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> watchlistProps = new Dictionary<string, string[]>() { { "type", new[] { "" } }, { "pageid", new[] { "ids" } }, { "revid", new[] { "ids" } }, { "old_revid", new[] { "ids" } }, { "ns", new[] { "title" } }, { "title", new[] { "title" } }, { "user", new[] { "user" } }, { "anon", new[] { "user", "userid" } }, { "userid", new[] { "userid" } }, { "new", new[] { "flags" } }, { "minor", new[] { "flags" } }, { "bot", new[] { "flags" } }, { "patrolled", new[] { "patrol" } }, { "timestamp", new[] { "timestamp" } }, { "oldlen", new[] { "sizes" } }, { "newlen", new[] { "sizes" } }, { "notificationtimestamp", new[] { "notificationtimestamp" } }, { "comment", new[] { "comment" } }, { "parsedcomment", new[] { "parsedcomment" } }, { "logid", new[] { "loginfo" } }, { "logtype", new[] { "loginfo" } }, { "logaction", new[] { "loginfo" } } };
        private static readonly QueryTypeProperties<watchlistSelect> watchlistProperties = new QueryTypeProperties<watchlistSelect>("watchlist", "wl", QueryType.List, SortType.Newer, new TupleList<string, string>() { { "action", "query" }, { "list", "watchlist" } }, watchlistProps, watchlistSelect.Parse);

        ///<summary>
        ///Get all recent changes to pages in the logged in user's watchlist
        ///</summary>
        public WikiQuerySortableGenerator<Page, watchlistWhere, watchlistOrderBy, watchlistSelect> watchlist()
        {
            var queryParameters = QueryParameters.Create<watchlistSelect>();
            return new WikiQuerySortableGenerator<Page, watchlistWhere, watchlistOrderBy, watchlistSelect>(new QueryProcessor<watchlistSelect>(m_wiki, watchlistProperties), queryParameters);
        }

        private static readonly IDictionary<string, string[]> watchlistrawProps = new Dictionary<string, string[]>() { { "ns", new[] { "" } }, { "title", new[] { "" } }, { "changed", new[] { "changed" } } };
        private static readonly QueryTypeProperties<watchlistrawSelect> watchlistrawProperties = new QueryTypeProperties<watchlistrawSelect>("watchlistraw", "wr", QueryType.List, SortType.Ascending, new TupleList<string, string>() { { "action", "query" }, { "list", "watchlistraw" } }, watchlistrawProps, watchlistrawSelect.Parse);

        ///<summary>
        ///Get all pages on the logged in user's watchlist
        ///</summary>
        public WikiQuerySortableGenerator<Page, watchlistrawWhere, watchlistrawOrderBy, watchlistrawSelect> watchlistraw()
        {
            var queryParameters = QueryParameters.Create<watchlistrawSelect>();
            return new WikiQuerySortableGenerator<Page, watchlistrawWhere, watchlistrawOrderBy, watchlistrawSelect>(new QueryProcessor<watchlistrawSelect>(m_wiki, watchlistrawProperties), queryParameters);
        }
    }
}