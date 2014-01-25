using System;
using System.Collections.Generic;
using LinqToWiki;
using LinqToWiki.Collections;
using LinqToWiki.Internals;
using LinqToWiki.Parameters;
using TrksRecipeDoc.MekaWiki.Entities;

namespace TrksRecipeDoc.MekaWiki
{
    public sealed class Wiki
    {
        private readonly WikiInfo m_wiki;

        public QueryAction Query { get; private set; }

        public int PagesSourcePageSize
        {
            get
            {
                return m_wiki.PagesSourcePageSize;
            }

            set
            {
                m_wiki.PagesSourcePageSize = value;
            }
        }

        public Wiki(string userAgent, string baseUri = null, string apiPath = null)
        {
            m_wiki = new WikiInfo(userAgent, baseUri ?? "http://mekawiki.s4.trakos.pl", apiPath ?? "/api.php");
            Query = new QueryAction(m_wiki);
        }

        public PagesSource<Page> CreateTitlesSource(IEnumerable<string> titles)
        {
            return new TitlesSource<Page>(m_wiki, titles);
        }

        public PagesSource<Page> CreateTitlesSource(params string[] titles)
        {
            return new TitlesSource<Page>(m_wiki, titles);
        }

        public PagesSource<Page> CreatePageIdsSource(IEnumerable<long> pageIds)
        {
            return new PageIdsSource<Page>(m_wiki, pageIds);
        }

        public PagesSource<Page> CreatePageIdsSource(params long[] pageIds)
        {
            return new PageIdsSource<Page>(m_wiki, pageIds);
        }

        public PagesSource<Page> CreateRevIdsSource(IEnumerable<long> revIds)
        {
            return new RevIdsSource<Page>(m_wiki, revIds);
        }

        public PagesSource<Page> CreateRevIdsSource(params long[] revIds)
        {
            return new RevIdsSource<Page>(m_wiki, revIds);
        }

        private static readonly QueryTypeProperties<blockResult> blockProperties = new QueryTypeProperties<blockResult>("block", "", null, null, new TupleList<string, string>() { { "action", "block" } }, null, blockResult.Parse);

        ///<summary>
        ///Block a user
        ///</summary>
        ///<param name="user">
        ///Username, IP address or IP range you want to block
        ///</param >
        ///<param name="token">
        ///A block token previously obtained through prop=info
        ///</param >
        ///<param name="expiry">
        ///Relative expiry time, e.g. '5 months' or '2 weeks'. If set to 'infinite', 'indefinite' or 'never', the block will never expire.
        ///</param >
        ///<param name="reason">
        ///Reason for block
        ///</param >
        ///<param name="anononly">
        ///Block anonymous users only (i.e. disable anonymous edits for this IP)
        ///</param >
        ///<param name="nocreate">
        ///Prevent account creation
        ///</param >
        ///<param name="autoblock">
        ///Automatically block the last used IP address, and any subsequent IP addresses they try to login from
        ///</param >
        ///<param name="noemail">
        ///Prevent user from sending email through the wiki. (Requires the "blockemail" right.)
        ///</param >
        ///<param name="hidename">
        ///Hide the username from the block log. (Requires the "hideuser" right.)
        ///</param >
        ///<param name="allowusertalk">
        ///Allow the user to edit their own talk page (depends on $wgBlockAllowsUTEdit)
        ///</param >
        ///<param name="reblock">
        ///If the user is already blocked, overwrite the existing block
        ///</param >
        ///<param name="watchuser">
        ///Watch the user/IP's user and talk pages
        ///</param >
        public blockResult block(string user, string token = null, string expiry = null, string reason = null, bool? anononly = null, bool? nocreate = null, bool? autoblock = null, bool? noemail = null, bool? hidename = null, bool? allowusertalk = null, bool? reblock = null, bool? watchuser = null)
        {
            var queryParameters = QueryParameters.Create<blockResult>();
            queryParameters = queryParameters.AddSingleValue("user", user.ToQueryString());
            if (token != null)
                queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            if (expiry != null)
                queryParameters = queryParameters.AddSingleValue("expiry", expiry.ToQueryString());
            if (reason != null)
                queryParameters = queryParameters.AddSingleValue("reason", reason.ToQueryString());
            if (anononly != null)
                queryParameters = queryParameters.AddSingleValue("anononly", anononly.Value.ToQueryString());
            if (nocreate != null)
                queryParameters = queryParameters.AddSingleValue("nocreate", nocreate.Value.ToQueryString());
            if (autoblock != null)
                queryParameters = queryParameters.AddSingleValue("autoblock", autoblock.Value.ToQueryString());
            if (noemail != null)
                queryParameters = queryParameters.AddSingleValue("noemail", noemail.Value.ToQueryString());
            if (hidename != null)
                queryParameters = queryParameters.AddSingleValue("hidename", hidename.Value.ToQueryString());
            if (allowusertalk != null)
                queryParameters = queryParameters.AddSingleValue("allowusertalk", allowusertalk.Value.ToQueryString());
            if (reblock != null)
                queryParameters = queryParameters.AddSingleValue("reblock", reblock.Value.ToQueryString());
            if (watchuser != null)
                queryParameters = queryParameters.AddSingleValue("watchuser", watchuser.Value.ToQueryString());
            return new QueryProcessor<blockResult>(m_wiki, blockProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<compareResult> compareProperties = new QueryTypeProperties<compareResult>("compare", "", null, null, new TupleList<string, string>() { { "action", "compare" } }, null, compareResult.Parse);

        ///<summary>
        ///Get the difference between 2 pages
        ///You must pass a revision number or a page title or a page ID id for each part (1 and 2)
        ///</summary>
        ///<param name="fromtitle">
        ///First title to compare
        ///</param >
        ///<param name="fromid">
        ///First page ID to compare
        ///</param >
        ///<param name="fromrev">
        ///First revision to compare
        ///</param >
        ///<param name="totitle">
        ///Second title to compare
        ///</param >
        ///<param name="toid">
        ///Second page ID to compare
        ///</param >
        ///<param name="torev">
        ///Second revision to compare
        ///</param >
        public compareResult compare(string fromtitle = null, long? fromid = null, int? fromrev = null, string totitle = null, long? toid = null, int? torev = null)
        {
            var queryParameters = QueryParameters.Create<compareResult>();
            if (fromtitle != null)
                queryParameters = queryParameters.AddSingleValue("fromtitle", fromtitle.ToQueryString());
            if (fromid != null)
                queryParameters = queryParameters.AddSingleValue("fromid", fromid.Value.ToQueryString());
            if (fromrev != null)
                queryParameters = queryParameters.AddSingleValue("fromrev", fromrev.Value.ToQueryString());
            if (totitle != null)
                queryParameters = queryParameters.AddSingleValue("totitle", totitle.ToQueryString());
            if (toid != null)
                queryParameters = queryParameters.AddSingleValue("toid", toid.Value.ToQueryString());
            if (torev != null)
                queryParameters = queryParameters.AddSingleValue("torev", torev.Value.ToQueryString());
            return new QueryProcessor<compareResult>(m_wiki, compareProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<object> createaccountProperties = new QueryTypeProperties<object>("createaccount", "", null, null, new TupleList<string, string>() { { "action", "createaccount" } }, null, _ => null);

        ///<summary>
        ///Create a new user account.
        ///</summary>
        ///<param name="name">
        ///Username
        ///</param >
        ///<param name="password">
        ///Password (ignored if mailpassword is set)
        ///</param >
        ///<param name="domain">
        ///Domain for external authentication (optional)
        ///</param >
        ///<param name="token">
        ///Account creation token obtained in first request
        ///</param >
        ///<param name="email">
        ///Email address of user (optional)
        ///</param >
        ///<param name="realname">
        ///Real name of user (optional)
        ///</param >
        ///<param name="mailpassword">
        ///If set to any value, a random password will be emailed to the user
        ///</param >
        ///<param name="reason">
        ///Optional reason for creating the account to be put in the logs
        ///</param >
        ///<param name="language">
        ///Language code to set as default for the user (optional, defaults to content language)
        ///</param >
        public void createaccount(string name, string password = null, string domain = null, string token = null, string email = null, string realname = null, bool? mailpassword = null, string reason = null, string language = null)
        {
            var queryParameters = QueryParameters.Create<object>();
            queryParameters = queryParameters.AddSingleValue("name", name.ToQueryString());
            if (password != null)
                queryParameters = queryParameters.AddSingleValue("password", password.ToQueryString());
            if (domain != null)
                queryParameters = queryParameters.AddSingleValue("domain", domain.ToQueryString());
            if (token != null)
                queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            if (email != null)
                queryParameters = queryParameters.AddSingleValue("email", email.ToQueryString());
            if (realname != null)
                queryParameters = queryParameters.AddSingleValue("realname", realname.ToQueryString());
            if (mailpassword != null)
                queryParameters = queryParameters.AddSingleValue("mailpassword", mailpassword.Value.ToQueryString());
            if (reason != null)
                queryParameters = queryParameters.AddSingleValue("reason", reason.ToQueryString());
            if (language != null)
                queryParameters = queryParameters.AddSingleValue("language", language.ToQueryString());
            new QueryProcessor<object>(m_wiki, createaccountProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<deleteResult> deleteProperties = new QueryTypeProperties<deleteResult>("delete", "", null, null, new TupleList<string, string>() { { "action", "delete" } }, null, deleteResult.Parse);

        ///<summary>
        ///Delete a page
        ///</summary>
        ///<param name="token">
        ///A delete token previously retrieved through prop=info
        ///</param >
        ///<param name="title">
        ///Title of the page you want to delete. Cannot be used together with pageid
        ///</param >
        ///<param name="pageid">
        ///Page ID of the page you want to delete. Cannot be used together with title
        ///</param >
        ///<param name="reason">
        ///Reason for the deletion. If not set, an automatically generated reason will be used
        ///</param >
        ///<param name="watchlist">
        ///Unconditionally add or remove the page from your watchlist, use preferences or do not change watch
        ///</param >
        ///<param name="oldimage">
        ///The name of the old image to delete as provided by iiprop=archivename
        ///</param >
        public deleteResult delete(string token, string title = null, long? pageid = null, string reason = null, deletewatchlist watchlist = null, string oldimage = null)
        {
            var queryParameters = QueryParameters.Create<deleteResult>();
            queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            if (title != null)
                queryParameters = queryParameters.AddSingleValue("title", title.ToQueryString());
            if (pageid != null)
                queryParameters = queryParameters.AddSingleValue("pageid", pageid.Value.ToQueryString());
            if (reason != null)
                queryParameters = queryParameters.AddSingleValue("reason", reason.ToQueryString());
            if (watchlist != null)
                queryParameters = queryParameters.AddSingleValue("watchlist", watchlist.ToQueryString());
            if (oldimage != null)
                queryParameters = queryParameters.AddSingleValue("oldimage", oldimage.ToQueryString());
            return new QueryProcessor<deleteResult>(m_wiki, deleteProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<editResult> editProperties = new QueryTypeProperties<editResult>("edit", "", null, null, new TupleList<string, string>() { { "action", "edit" } }, null, editResult.Parse);

        ///<summary>
        ///Create and edit pages.
        ///</summary>
        ///<param name="token">
        ///Edit token. You can get one of these through prop=info.
        ///The token should always be sent as the last parameter, or at least, after the text parameter
        ///</param >
        ///<param name="title">
        ///Title of the page you want to edit. Cannot be used together with pageid
        ///</param >
        ///<param name="pageid">
        ///Page ID of the page you want to edit. Cannot be used together with title
        ///</param >
        ///<param name="section">
        ///Section number. 0 for the top section, 'new' for a new section
        ///</param >
        ///<param name="sectiontitle">
        ///The title for a new section
        ///</param >
        ///<param name="text">
        ///Page content
        ///</param >
        ///<param name="summary">
        ///Edit summary. Also section title when section=new and sectiontitle is not set
        ///</param >
        ///<param name="minor">
        ///Minor edit
        ///</param >
        ///<param name="notminor">
        ///Non-minor edit
        ///</param >
        ///<param name="bot">
        ///Mark this edit as bot
        ///</param >
        ///<param name="basetimestamp">
        ///Timestamp of the base revision (obtained through prop=revisions&amp;rvprop=timestamp).
        ///Used to detect edit conflicts; leave unset to ignore conflicts
        ///</param >
        ///<param name="starttimestamp">
        ///Timestamp when you obtained the edit token.
        ///Used to detect edit conflicts; leave unset to ignore conflicts
        ///</param >
        ///<param name="recreate">
        ///Override any errors about the article having been deleted in the meantime
        ///</param >
        ///<param name="createonly">
        ///Don't edit the page if it exists already
        ///</param >
        ///<param name="nocreate">
        ///Throw an error if the page doesn't exist
        ///</param >
        ///<param name="watchlist">
        ///Unconditionally add or remove the page from your watchlist, use preferences or do not change watch
        ///</param >
        ///<param name="md5">
        ///The MD5 hash of the text parameter, or the prependtext and appendtext parameters concatenated.
        ///If set, the edit won't be done unless the hash is correct
        ///</param >
        ///<param name="prependtext">
        ///Add this text to the beginning of the page. Overrides text
        ///</param >
        ///<param name="appendtext">
        ///Add this text to the end of the page. Overrides text.
        ///Use section=new to append a new section
        ///</param >
        ///<param name="undo">
        ///Undo this revision. Overrides text, prependtext and appendtext
        ///</param >
        ///<param name="undoafter">
        ///Undo all revisions from undo to this one. If not set, just undo one revision
        ///</param >
        ///<param name="redirect">
        ///Automatically resolve redirects
        ///</param >
        ///<param name="contentformat">
        ///Content serialization format used for the input text
        ///</param >
        ///<param name="contentmodel">
        ///Content model of the new content
        ///</param >
        public editResult edit(string token, string title = null, long? pageid = null, string section = null, string sectiontitle = null, string text = null, string summary = null, bool? minor = null, bool? notminor = null, bool? bot = null, string basetimestamp = null, string starttimestamp = null, bool? recreate = null, bool? createonly = null, bool? nocreate = null, editwatchlist watchlist = null, string md5 = null, string prependtext = null, string appendtext = null, int? undo = null, int? undoafter = null, bool? redirect = null, editcontentformat contentformat = null, editcontentmodel contentmodel = null)
        {
            var queryParameters = QueryParameters.Create<editResult>();
            queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            if (title != null)
                queryParameters = queryParameters.AddSingleValue("title", title.ToQueryString());
            if (pageid != null)
                queryParameters = queryParameters.AddSingleValue("pageid", pageid.Value.ToQueryString());
            if (section != null)
                queryParameters = queryParameters.AddSingleValue("section", section.ToQueryString());
            if (sectiontitle != null)
                queryParameters = queryParameters.AddSingleValue("sectiontitle", sectiontitle.ToQueryString());
            if (text != null)
                queryParameters = queryParameters.AddSingleValue("text", text.ToQueryString());
            if (summary != null)
                queryParameters = queryParameters.AddSingleValue("summary", summary.ToQueryString());
            if (minor != null)
                queryParameters = queryParameters.AddSingleValue("minor", minor.Value.ToQueryString());
            if (notminor != null)
                queryParameters = queryParameters.AddSingleValue("notminor", notminor.Value.ToQueryString());
            if (bot != null)
                queryParameters = queryParameters.AddSingleValue("bot", bot.Value.ToQueryString());
            if (basetimestamp != null)
                queryParameters = queryParameters.AddSingleValue("basetimestamp", basetimestamp.ToQueryString());
            if (starttimestamp != null)
                queryParameters = queryParameters.AddSingleValue("starttimestamp", starttimestamp.ToQueryString());
            if (recreate != null)
                queryParameters = queryParameters.AddSingleValue("recreate", recreate.Value.ToQueryString());
            if (createonly != null)
                queryParameters = queryParameters.AddSingleValue("createonly", createonly.Value.ToQueryString());
            if (nocreate != null)
                queryParameters = queryParameters.AddSingleValue("nocreate", nocreate.Value.ToQueryString());
            if (watchlist != null)
                queryParameters = queryParameters.AddSingleValue("watchlist", watchlist.ToQueryString());
            if (md5 != null)
                queryParameters = queryParameters.AddSingleValue("md5", md5.ToQueryString());
            if (prependtext != null)
                queryParameters = queryParameters.AddSingleValue("prependtext", prependtext.ToQueryString());
            if (appendtext != null)
                queryParameters = queryParameters.AddSingleValue("appendtext", appendtext.ToQueryString());
            if (undo != null)
                queryParameters = queryParameters.AddSingleValue("undo", undo.Value.ToQueryString());
            if (undoafter != null)
                queryParameters = queryParameters.AddSingleValue("undoafter", undoafter.Value.ToQueryString());
            if (redirect != null)
                queryParameters = queryParameters.AddSingleValue("redirect", redirect.Value.ToQueryString());
            if (contentformat != null)
                queryParameters = queryParameters.AddSingleValue("contentformat", contentformat.ToQueryString());
            if (contentmodel != null)
                queryParameters = queryParameters.AddSingleValue("contentmodel", contentmodel.ToQueryString());
            return new QueryProcessor<editResult>(m_wiki, editProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<emailuserResult> emailuserProperties = new QueryTypeProperties<emailuserResult>("emailuser", "", null, null, new TupleList<string, string>() { { "action", "emailuser" } }, null, emailuserResult.Parse);

        ///<summary>
        ///Email a user.
        ///</summary>
        ///<param name="target">
        ///User to send email to
        ///</param >
        ///<param name="text">
        ///Mail body
        ///</param >
        ///<param name="token">
        ///A token previously acquired via prop=info
        ///</param >
        ///<param name="subject">
        ///Subject header
        ///</param >
        ///<param name="ccme">
        ///Send a copy of this mail to me
        ///</param >
        public emailuserResult emailuser(string target, string text, string token, string subject = null, bool? ccme = null)
        {
            var queryParameters = QueryParameters.Create<emailuserResult>();
            queryParameters = queryParameters.AddSingleValue("target", target.ToQueryString());
            queryParameters = queryParameters.AddSingleValue("text", text.ToQueryString());
            queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            if (subject != null)
                queryParameters = queryParameters.AddSingleValue("subject", subject.ToQueryString());
            if (ccme != null)
                queryParameters = queryParameters.AddSingleValue("ccme", ccme.Value.ToQueryString());
            return new QueryProcessor<emailuserResult>(m_wiki, emailuserProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<expandtemplatesResult> expandtemplatesProperties = new QueryTypeProperties<expandtemplatesResult>("expandtemplates", "", null, null, new TupleList<string, string>() { { "action", "expandtemplates" } }, null, expandtemplatesResult.Parse);

        ///<summary>
        ///Expands all templates in wikitext
        ///</summary>
        ///<param name="text">
        ///Wikitext to convert
        ///</param >
        ///<param name="title">
        ///Title of page
        ///</param >
        ///<param name="generatexml">
        ///Generate XML parse tree
        ///</param >
        ///<param name="includecomments">
        ///Whether to include HTML comments in the output
        ///</param >
        public expandtemplatesResult expandtemplates(string text, string title = null, bool? generatexml = null, bool? includecomments = null)
        {
            var queryParameters = QueryParameters.Create<expandtemplatesResult>();
            queryParameters = queryParameters.AddSingleValue("text", text.ToQueryString());
            if (title != null)
                queryParameters = queryParameters.AddSingleValue("title", title.ToQueryString());
            if (generatexml != null)
                queryParameters = queryParameters.AddSingleValue("generatexml", generatexml.Value.ToQueryString());
            if (includecomments != null)
                queryParameters = queryParameters.AddSingleValue("includecomments", includecomments.Value.ToQueryString());
            return new QueryProcessor<expandtemplatesResult>(m_wiki, expandtemplatesProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<filerevertResult> filerevertProperties = new QueryTypeProperties<filerevertResult>("filerevert", "", null, null, new TupleList<string, string>() { { "action", "filerevert" } }, null, filerevertResult.Parse);

        ///<summary>
        ///Revert a file to an old version
        ///</summary>
        ///<param name="filename">
        ///Target filename without the File: prefix
        ///</param >
        ///<param name="archivename">
        ///Archive name of the revision to revert to
        ///</param >
        ///<param name="token">
        ///Edit token. You can get one of these through prop=info
        ///</param >
        ///<param name="comment">
        ///Upload comment
        ///</param >
        public filerevertResult filerevert(string filename, string archivename, string token, string comment = null)
        {
            var queryParameters = QueryParameters.Create<filerevertResult>();
            queryParameters = queryParameters.AddSingleValue("filename", filename.ToQueryString());
            queryParameters = queryParameters.AddSingleValue("archivename", archivename.ToQueryString());
            queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            if (comment != null)
                queryParameters = queryParameters.AddSingleValue("comment", comment.ToQueryString());
            return new QueryProcessor<filerevertResult>(m_wiki, filerevertProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<importResult> importProperties = new QueryTypeProperties<importResult>("import", "", null, null, new TupleList<string, string>() { { "action", "import" } }, null, importResult.Parse);

        ///<summary>
        ///Import a page from another wiki, or an XML file.
        ///Note that the HTTP POST must be done as a file upload (i.e. using multipart/form-data) when
        ///sending a file for the "xml" parameter.
        ///</summary>
        ///<param name="token">
        ///Import token obtained through prop=info
        ///</param >
        ///<param name="summary">
        ///Import summary
        ///</param >
        ///<param name="xml">
        ///Uploaded XML file
        ///</param >
        ///<param name="interwikisource">
        ///For interwiki imports: wiki to import from
        ///</param >
        ///<param name="interwikipage">
        ///For interwiki imports: page to import
        ///</param >
        ///<param name="fullhistory">
        ///For interwiki imports: import the full history, not just the current version
        ///</param >
        ///<param name="templates">
        ///For interwiki imports: import all included templates as well
        ///</param >
        ///<param name="ns">
        ///For interwiki imports: import to this namespace
        ///</param >
        ///<param name="rootpage">
        ///Import as subpage of this page
        ///</param >
        public IEnumerable<importResult> import(string token, string summary = null, System.IO.Stream xml = null, importinterwikisource interwikisource = null, string interwikipage = null, bool? fullhistory = null, bool? templates = null, Namespace ns = null, string rootpage = null)
        {
            var queryParameters = QueryParameters.Create<importResult>();
            queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            if (summary != null)
                queryParameters = queryParameters.AddSingleValue("summary", summary.ToQueryString());
            if (xml != null)
                queryParameters = queryParameters.AddFile("xml", xml);
            if (interwikisource != null)
                queryParameters = queryParameters.AddSingleValue("interwikisource", interwikisource.ToQueryString());
            if (interwikipage != null)
                queryParameters = queryParameters.AddSingleValue("interwikipage", interwikipage.ToQueryString());
            if (fullhistory != null)
                queryParameters = queryParameters.AddSingleValue("fullhistory", fullhistory.Value.ToQueryString());
            if (templates != null)
                queryParameters = queryParameters.AddSingleValue("templates", templates.Value.ToQueryString());
            if (ns != null)
                queryParameters = queryParameters.AddSingleValue("namespace", ns.ToQueryString());
            if (rootpage != null)
                queryParameters = queryParameters.AddSingleValue("rootpage", rootpage.ToQueryString());
            return new QueryProcessor<importResult>(m_wiki, importProperties).ExecuteList(queryParameters);
        }

        private static readonly QueryTypeProperties<loginResult> loginProperties = new QueryTypeProperties<loginResult>("login", "lg", null, null, new TupleList<string, string>() { { "action", "login" } }, null, loginResult.Parse);

        ///<summary>
        ///Log in and get the authentication tokens.
        ///In the event of a successful log-in, a cookie will be attached
        ///to your session. In the event of a failed log-in, you will not
        ///be able to attempt another log-in through this method for 5 seconds.
        ///This is to prevent password guessing by automated password crackers
        ///</summary>
        ///<param name="name">
        ///User Name
        ///</param >
        ///<param name="password">
        ///Password
        ///</param >
        ///<param name="domain">
        ///Domain (optional)
        ///</param >
        ///<param name="token">
        ///Login token obtained in first request
        ///</param >
        public loginResult login(string name = null, string password = null, string domain = null, string token = null)
        {
            var queryParameters = QueryParameters.Create<loginResult>();
            if (name != null)
                queryParameters = queryParameters.AddSingleValue("name", name.ToQueryString());
            if (password != null)
                queryParameters = queryParameters.AddSingleValue("password", password.ToQueryString());
            if (domain != null)
                queryParameters = queryParameters.AddSingleValue("domain", domain.ToQueryString());
            if (token != null)
                queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            return new QueryProcessor<loginResult>(m_wiki, loginProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<object> logoutProperties = new QueryTypeProperties<object>("logout", "", null, null, new TupleList<string, string>() { { "action", "logout" } }, null, _ => null);

        ///<summary>
        ///Log out and clear session data
        ///</summary>
        public void logout()
        {
            var queryParameters = QueryParameters.Create<object>();
            new QueryProcessor<object>(m_wiki, logoutProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<moveResult> moveProperties = new QueryTypeProperties<moveResult>("move", "", null, null, new TupleList<string, string>() { { "action", "move" } }, null, moveResult.Parse);

        ///<summary>
        ///Move a page
        ///</summary>
        ///<param name="to">
        ///Title you want to rename the page to
        ///</param >
        ///<param name="token">
        ///A move token previously retrieved through prop=info
        ///</param >
        ///<param name="from">
        ///Title of the page you want to move. Cannot be used together with fromid
        ///</param >
        ///<param name="fromid">
        ///Page ID of the page you want to move. Cannot be used together with from
        ///</param >
        ///<param name="reason">
        ///Reason for the move
        ///</param >
        ///<param name="movetalk">
        ///Move the talk page, if it exists
        ///</param >
        ///<param name="movesubpages">
        ///Move subpages, if applicable
        ///</param >
        ///<param name="noredirect">
        ///Don't create a redirect
        ///</param >
        ///<param name="watchlist">
        ///Unconditionally add or remove the page from your watchlist, use preferences or do not change watch
        ///</param >
        ///<param name="ignorewarnings">
        ///Ignore any warnings
        ///</param >
        public moveResult move(string to, string token, string from = null, long? fromid = null, string reason = null, bool? movetalk = null, bool? movesubpages = null, bool? noredirect = null, movewatchlist watchlist = null, bool? ignorewarnings = null)
        {
            var queryParameters = QueryParameters.Create<moveResult>();
            queryParameters = queryParameters.AddSingleValue("to", to.ToQueryString());
            queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            if (from != null)
                queryParameters = queryParameters.AddSingleValue("from", from.ToQueryString());
            if (fromid != null)
                queryParameters = queryParameters.AddSingleValue("fromid", fromid.Value.ToQueryString());
            if (reason != null)
                queryParameters = queryParameters.AddSingleValue("reason", reason.ToQueryString());
            if (movetalk != null)
                queryParameters = queryParameters.AddSingleValue("movetalk", movetalk.Value.ToQueryString());
            if (movesubpages != null)
                queryParameters = queryParameters.AddSingleValue("movesubpages", movesubpages.Value.ToQueryString());
            if (noredirect != null)
                queryParameters = queryParameters.AddSingleValue("noredirect", noredirect.Value.ToQueryString());
            if (watchlist != null)
                queryParameters = queryParameters.AddSingleValue("watchlist", watchlist.ToQueryString());
            if (ignorewarnings != null)
                queryParameters = queryParameters.AddSingleValue("ignorewarnings", ignorewarnings.Value.ToQueryString());
            return new QueryProcessor<moveResult>(m_wiki, moveProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<optionsResult> optionsProperties = new QueryTypeProperties<optionsResult>("options", "", null, null, new TupleList<string, string>() { { "action", "options" } }, null, optionsResult.Parse);

        ///<summary>
        ///Change preferences of the current user
        ///Only options which are registered in core or in one of installed extensions,
        ///or as options with keys prefixed with 'userjs-' (intended to be used by user scripts), can be set.
        ///</summary>
        ///<param name="token">
        ///An options token previously obtained through the action=tokens
        ///</param >
        ///<param name="reset">
        ///Resets preferences to the site defaults
        ///</param >
        ///<param name="resetkinds">
        ///List of types of options to reset when the "reset" option is set
        ///</param >
        ///<param name="change">
        ///List of changes, formatted name=value (e.g. skin=vector), value cannot contain pipe characters. If no value is given (not even an equals sign), e.g., optionname|otheroption|..., the option will be reset to its default value
        ///</param >
        ///<param name="optionname">
        ///A name of a option which should have an optionvalue set
        ///</param >
        ///<param name="optionvalue">
        ///A value of the option specified by the optionname, can contain pipe characters
        ///</param >
        public optionsResult options(string token, bool? reset = null, IEnumerable<optionsresetkinds> resetkinds = null, IEnumerable<string> change = null, string optionname = null, string optionvalue = null)
        {
            var queryParameters = QueryParameters.Create<optionsResult>();
            queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            if (reset != null)
                queryParameters = queryParameters.AddSingleValue("reset", reset.Value.ToQueryString());
            if (resetkinds != null)
                queryParameters = queryParameters.AddSingleValue("resetkinds", resetkinds.ToQueryString());
            if (change != null)
                queryParameters = queryParameters.AddSingleValue("change", change.ToQueryString());
            if (optionname != null)
                queryParameters = queryParameters.AddSingleValue("optionname", optionname.ToQueryString());
            if (optionvalue != null)
                queryParameters = queryParameters.AddSingleValue("optionvalue", optionvalue.ToQueryString());
            return new QueryProcessor<optionsResult>(m_wiki, optionsProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<patrolResult> patrolProperties = new QueryTypeProperties<patrolResult>("patrol", "", null, null, new TupleList<string, string>() { { "action", "patrol" } }, null, patrolResult.Parse);

        ///<summary>
        ///Patrol a page or revision
        ///</summary>
        ///<param name="token">
        ///Patrol token obtained from list=recentchanges
        ///</param >
        ///<param name="rcid">
        ///Recentchanges ID to patrol
        ///</param >
        ///<param name="revid">
        ///Revision ID to patrol
        ///</param >
        public patrolResult patrol(string token, long? rcid = null, long? revid = null)
        {
            var queryParameters = QueryParameters.Create<patrolResult>();
            queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            if (rcid != null)
                queryParameters = queryParameters.AddSingleValue("rcid", rcid.Value.ToQueryString());
            if (revid != null)
                queryParameters = queryParameters.AddSingleValue("revid", revid.Value.ToQueryString());
            return new QueryProcessor<patrolResult>(m_wiki, patrolProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<protectResult> protectProperties = new QueryTypeProperties<protectResult>("protect", "", null, null, new TupleList<string, string>() { { "action", "protect" } }, null, protectResult.Parse);

        ///<summary>
        ///Change the protection level of a page
        ///</summary>
        ///<param name="token">
        ///A protect token previously retrieved through prop=info
        ///</param >
        ///<param name="protections">
        ///List of protection levels, formatted action=group (e.g. edit=sysop)
        ///</param >
        ///<param name="title">
        ///Title of the page you want to (un)protect. Cannot be used together with pageid
        ///</param >
        ///<param name="pageid">
        ///ID of the page you want to (un)protect. Cannot be used together with title
        ///</param >
        ///<param name="expiry">
        ///Expiry timestamps. If only one timestamp is set, it'll be used for all protections.
        ///Use 'infinite', 'indefinite' or 'never', for a never-expiring protection.
        ///</param >
        ///<param name="reason">
        ///Reason for (un)protecting
        ///</param >
        ///<param name="cascade">
        ///Enable cascading protection (i.e. protect pages included in this page)
        ///Ignored if not all protection levels are 'sysop' or 'protect'
        ///</param >
        ///<param name="watchlist">
        ///Unconditionally add or remove the page from your watchlist, use preferences or do not change watch
        ///</param >
        public protectResult protect(string token, IEnumerable<string> protections, string title = null, long? pageid = null, IEnumerable<string> expiry = null, string reason = null, bool? cascade = null, protectwatchlist watchlist = null)
        {
            var queryParameters = QueryParameters.Create<protectResult>();
            queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            queryParameters = queryParameters.AddSingleValue("protections", protections.ToQueryString());
            if (title != null)
                queryParameters = queryParameters.AddSingleValue("title", title.ToQueryString());
            if (pageid != null)
                queryParameters = queryParameters.AddSingleValue("pageid", pageid.Value.ToQueryString());
            if (expiry != null)
                queryParameters = queryParameters.AddSingleValue("expiry", expiry.ToQueryString());
            if (reason != null)
                queryParameters = queryParameters.AddSingleValue("reason", reason.ToQueryString());
            if (cascade != null)
                queryParameters = queryParameters.AddSingleValue("cascade", cascade.Value.ToQueryString());
            if (watchlist != null)
                queryParameters = queryParameters.AddSingleValue("watchlist", watchlist.ToQueryString());
            return new QueryProcessor<protectResult>(m_wiki, protectProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<purgeResult> purgeProperties = new QueryTypeProperties<purgeResult>("purge", "", null, null, new TupleList<string, string>() { { "action", "purge" } }, null, purgeResult.Parse);

        ///<summary>
        ///Purge the cache for the given titles.
        ///Requires a POST request if the user is not logged in.
        ///</summary>
        ///<param name="forcelinkupdate">
        ///Update the links tables
        ///</param >
        ///<param name="forcerecursivelinkupdate">
        ///Update the links table, and update the links tables for any page that uses this page as a template
        ///</param >
        ///<param name="titles">
        ///A list of titles to work on
        ///</param >
        ///<param name="pageids">
        ///A list of page IDs to work on
        ///</param >
        ///<param name="revids">
        ///A list of revision IDs to work on
        ///</param >
        ///<param name="redirects">
        ///Automatically resolve redirects
        ///</param >
        ///<param name="converttitles">
        ///Convert titles to other variants if necessary. Only works if the wiki's content language supports variant conversion.
        ///Languages that support variant conversion include gan, iu, kk, ku, shi, sr, tg, uz, zh
        ///</param >
        ///<param name="generator">
        ///Get the list of pages to work on by executing the specified query module.
        ///NOTE: generator parameter names must be prefixed with a 'g', see examples
        ///</param >
        public IEnumerable<purgeResult> purge(bool? forcelinkupdate = null, bool? forcerecursivelinkupdate = null, IEnumerable<string> titles = null, IEnumerable<int> pageids = null, IEnumerable<int> revids = null, bool? redirects = null, bool? converttitles = null, purgegenerator generator = null)
        {
            var queryParameters = QueryParameters.Create<purgeResult>();
            if (forcelinkupdate != null)
                queryParameters = queryParameters.AddSingleValue("forcelinkupdate", forcelinkupdate.Value.ToQueryString());
            if (forcerecursivelinkupdate != null)
                queryParameters = queryParameters.AddSingleValue("forcerecursivelinkupdate", forcerecursivelinkupdate.Value.ToQueryString());
            if (titles != null)
                queryParameters = queryParameters.AddSingleValue("titles", titles.ToQueryString());
            if (pageids != null)
                queryParameters = queryParameters.AddSingleValue("pageids", pageids.ToQueryString());
            if (revids != null)
                queryParameters = queryParameters.AddSingleValue("revids", revids.ToQueryString());
            if (redirects != null)
                queryParameters = queryParameters.AddSingleValue("redirects", redirects.Value.ToQueryString());
            if (converttitles != null)
                queryParameters = queryParameters.AddSingleValue("converttitles", converttitles.Value.ToQueryString());
            if (generator != null)
                queryParameters = queryParameters.AddSingleValue("generator", generator.ToQueryString());
            return new QueryProcessor<purgeResult>(m_wiki, purgeProperties).ExecuteList(queryParameters);
        }

        private static readonly QueryTypeProperties<rollbackResult> rollbackProperties = new QueryTypeProperties<rollbackResult>("rollback", "", null, null, new TupleList<string, string>() { { "action", "rollback" } }, null, rollbackResult.Parse);

        ///<summary>
        ///Undo the last edit to the page. If the last user who edited the page made multiple edits in a row,
        ///they will all be rolled back
        ///</summary>
        ///<param name="title">
        ///Title of the page you want to rollback.
        ///</param >
        ///<param name="user">
        ///Name of the user whose edits are to be rolled back. If set incorrectly, you'll get a badtoken error.
        ///</param >
        ///<param name="token">
        ///A rollback token previously retrieved through prop=revisions
        ///</param >
        ///<param name="summary">
        ///Custom edit summary. If empty, default summary will be used
        ///</param >
        ///<param name="markbot">
        ///Mark the reverted edits and the revert as bot edits
        ///</param >
        ///<param name="watchlist">
        ///Unconditionally add or remove the page from your watchlist, use preferences or do not change watch
        ///</param >
        public rollbackResult rollback(string title, string user, string token, string summary = null, bool? markbot = null, rollbackwatchlist watchlist = null)
        {
            var queryParameters = QueryParameters.Create<rollbackResult>();
            queryParameters = queryParameters.AddSingleValue("title", title.ToQueryString());
            queryParameters = queryParameters.AddSingleValue("user", user.ToQueryString());
            queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            if (summary != null)
                queryParameters = queryParameters.AddSingleValue("summary", summary.ToQueryString());
            if (markbot != null)
                queryParameters = queryParameters.AddSingleValue("markbot", markbot.Value.ToQueryString());
            if (watchlist != null)
                queryParameters = queryParameters.AddSingleValue("watchlist", watchlist.ToQueryString());
            return new QueryProcessor<rollbackResult>(m_wiki, rollbackProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<setnotificationtimestampResult> setnotificationtimestampProperties = new QueryTypeProperties<setnotificationtimestampResult>("setnotificationtimestamp", "", null, null, new TupleList<string, string>() { { "action", "setnotificationtimestamp" } }, null, setnotificationtimestampResult.Parse);

        ///<summary>
        ///Update the notification timestamp for watched pages.
        ///This affects the highlighting of changed pages in the watchlist and history,
        ///and the sending of email when the "Email me when a page on my watchlist is
        ///changed" preference is enabled.
        ///</summary>
        ///<param name="entirewatchlist">
        ///Work on all watched pages
        ///</param >
        ///<param name="token">
        ///A token previously acquired via prop=info
        ///</param >
        ///<param name="timestamp">
        ///Timestamp to which to set the notification timestamp
        ///</param >
        ///<param name="torevid">
        ///Revision to set the notification timestamp to (one page only)
        ///</param >
        ///<param name="newerthanrevid">
        ///Revision to set the notification timestamp newer than (one page only)
        ///</param >
        ///<param name="titles">
        ///A list of titles to work on
        ///</param >
        ///<param name="pageids">
        ///A list of page IDs to work on
        ///</param >
        ///<param name="revids">
        ///A list of revision IDs to work on
        ///</param >
        ///<param name="redirects">
        ///Automatically resolve redirects
        ///</param >
        ///<param name="converttitles">
        ///Convert titles to other variants if necessary. Only works if the wiki's content language supports variant conversion.
        ///Languages that support variant conversion include gan, iu, kk, ku, shi, sr, tg, uz, zh
        ///</param >
        ///<param name="generator">
        ///Get the list of pages to work on by executing the specified query module.
        ///NOTE: generator parameter names must be prefixed with a 'g', see examples
        ///</param >
        public IEnumerable<setnotificationtimestampResult> setnotificationtimestamp(bool? entirewatchlist = null, string token = null, DateTime? timestamp = null, long? torevid = null, long? newerthanrevid = null, IEnumerable<string> titles = null, IEnumerable<int> pageids = null, IEnumerable<int> revids = null, bool? redirects = null, bool? converttitles = null, setnotificationtimestampgenerator generator = null)
        {
            var queryParameters = QueryParameters.Create<setnotificationtimestampResult>();
            if (entirewatchlist != null)
                queryParameters = queryParameters.AddSingleValue("entirewatchlist", entirewatchlist.Value.ToQueryString());
            if (token != null)
                queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            if (timestamp != null)
                queryParameters = queryParameters.AddSingleValue("timestamp", timestamp.Value.ToQueryString());
            if (torevid != null)
                queryParameters = queryParameters.AddSingleValue("torevid", torevid.Value.ToQueryString());
            if (newerthanrevid != null)
                queryParameters = queryParameters.AddSingleValue("newerthanrevid", newerthanrevid.Value.ToQueryString());
            if (titles != null)
                queryParameters = queryParameters.AddSingleValue("titles", titles.ToQueryString());
            if (pageids != null)
                queryParameters = queryParameters.AddSingleValue("pageids", pageids.ToQueryString());
            if (revids != null)
                queryParameters = queryParameters.AddSingleValue("revids", revids.ToQueryString());
            if (redirects != null)
                queryParameters = queryParameters.AddSingleValue("redirects", redirects.Value.ToQueryString());
            if (converttitles != null)
                queryParameters = queryParameters.AddSingleValue("converttitles", converttitles.Value.ToQueryString());
            if (generator != null)
                queryParameters = queryParameters.AddSingleValue("generator", generator.ToQueryString());
            return new QueryProcessor<setnotificationtimestampResult>(m_wiki, setnotificationtimestampProperties).ExecuteList(queryParameters);
        }

        private static readonly QueryTypeProperties<tokensResult> tokensProperties = new QueryTypeProperties<tokensResult>("tokens", "", null, null, new TupleList<string, string>() { { "action", "tokens" } }, null, tokensResult.Parse);

        ///<summary>
        ///Gets tokens for data-modifying actions
        ///</summary>
        ///<param name="type">
        ///Type of token(s) to request
        ///</param >
        public tokensResult tokens(IEnumerable<tokenstype> type = null)
        {
            var queryParameters = QueryParameters.Create<tokensResult>();
            if (type != null)
                queryParameters = queryParameters.AddSingleValue("type", type.ToQueryString());
            return new QueryProcessor<tokensResult>(m_wiki, tokensProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<unblockResult> unblockProperties = new QueryTypeProperties<unblockResult>("unblock", "", null, null, new TupleList<string, string>() { { "action", "unblock" } }, null, unblockResult.Parse);

        ///<summary>
        ///Unblock a user
        ///</summary>
        ///<param name="id">
        ///ID of the block you want to unblock (obtained through list=blocks). Cannot be used together with user
        ///</param >
        ///<param name="user">
        ///Username, IP address or IP range you want to unblock. Cannot be used together with id
        ///</param >
        ///<param name="token">
        ///An unblock token previously obtained through prop=info
        ///</param >
        ///<param name="reason">
        ///Reason for unblock
        ///</param >
        public unblockResult unblock(long? id = null, string user = null, string token = null, string reason = null)
        {
            var queryParameters = QueryParameters.Create<unblockResult>();
            if (id != null)
                queryParameters = queryParameters.AddSingleValue("id", id.Value.ToQueryString());
            if (user != null)
                queryParameters = queryParameters.AddSingleValue("user", user.ToQueryString());
            if (token != null)
                queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            if (reason != null)
                queryParameters = queryParameters.AddSingleValue("reason", reason.ToQueryString());
            return new QueryProcessor<unblockResult>(m_wiki, unblockProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<undeleteResult> undeleteProperties = new QueryTypeProperties<undeleteResult>("undelete", "", null, null, new TupleList<string, string>() { { "action", "undelete" } }, null, undeleteResult.Parse);

        ///<summary>
        ///Restore certain revisions of a deleted page. A list of deleted revisions (including timestamps) can be
        ///retrieved through list=deletedrevs
        ///</summary>
        ///<param name="title">
        ///Title of the page you want to restore
        ///</param >
        ///<param name="token">
        ///An undelete token previously retrieved through list=deletedrevs
        ///</param >
        ///<param name="reason">
        ///Reason for restoring
        ///</param >
        ///<param name="timestamps">
        ///Timestamps of the revisions to restore. If not set, all revisions will be restored.
        ///</param >
        ///<param name="watchlist">
        ///Unconditionally add or remove the page from your watchlist, use preferences or do not change watch
        ///</param >
        public undeleteResult undelete(string title, string token, string reason = null, IEnumerable<DateTime> timestamps = null, undeletewatchlist watchlist = null)
        {
            var queryParameters = QueryParameters.Create<undeleteResult>();
            queryParameters = queryParameters.AddSingleValue("title", title.ToQueryString());
            queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            if (reason != null)
                queryParameters = queryParameters.AddSingleValue("reason", reason.ToQueryString());
            if (timestamps != null)
                queryParameters = queryParameters.AddSingleValue("timestamps", timestamps.ToQueryString());
            if (watchlist != null)
                queryParameters = queryParameters.AddSingleValue("watchlist", watchlist.ToQueryString());
            return new QueryProcessor<undeleteResult>(m_wiki, undeleteProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<uploadResult> uploadProperties = new QueryTypeProperties<uploadResult>("upload", "", null, null, new TupleList<string, string>() { { "action", "upload" } }, null, uploadResult.Parse);

        ///<summary>
        ///Upload a file, or get the status of pending uploads. Several methods are available:
        /// * Upload file contents directly, using the "file" parameter
        /// * Have the MediaWiki server fetch a file from a URL, using the "url" parameter
        /// * Complete an earlier upload that failed due to warnings, using the "filekey" parameter
        ///Note that the HTTP POST must be done as a file upload (i.e. using multipart/form-data) when
        ///sending the "file". Also you must get and send an edit token before doing any upload stuff
        ///</summary>
        ///<param name="token">
        ///Edit token. You can get one of these through prop=info
        ///</param >
        ///<param name="filename">
        ///Target filename
        ///</param >
        ///<param name="comment">
        ///Upload comment. Also used as the initial page text for new files if "text" is not specified
        ///</param >
        ///<param name="text">
        ///Initial page text for new files
        ///</param >
        ///<param name="watchlist">
        ///Unconditionally add or remove the page from your watchlist, use preferences or do not change watch
        ///</param >
        ///<param name="ignorewarnings">
        ///Ignore any warnings
        ///</param >
        ///<param name="file">
        ///File contents
        ///</param >
        ///<param name="url">
        ///URL to fetch the file from
        ///</param >
        ///<param name="filekey">
        ///Key that identifies a previous upload that was stashed temporarily.
        ///</param >
        ///<param name="stash">
        ///If set, the server will not add the file to the repository and stash it temporarily.
        ///</param >
        ///<param name="filesize">
        ///Filesize of entire upload
        ///</param >
        ///<param name="offset">
        ///Offset of chunk in bytes
        ///</param >
        ///<param name="chunk">
        ///Chunk contents
        ///</param >
        ///<param name="async">
        ///Make potentially large file operations asynchronous when possible
        ///</param >
        ///<param name="asyncdownload">
        ///Make fetching a URL asynchronous
        ///</param >
        ///<param name="leavemessage">
        ///If asyncdownload is used, leave a message on the user talk page if finished
        ///</param >
        ///<param name="statuskey">
        ///Fetch the upload status for this file key (upload by URL)
        ///</param >
        ///<param name="checkstatus">
        ///Only fetch the upload status for the given file key
        ///</param >
        public uploadResult upload(string token, string filename = null, string comment = null, string text = null, uploadwatchlist watchlist = null, bool? ignorewarnings = null, System.IO.Stream file = null, string url = null, string filekey = null, bool? stash = null, string filesize = null, string offset = null, System.IO.Stream chunk = null, bool? async = null, bool? asyncdownload = null, bool? leavemessage = null, string statuskey = null, bool? checkstatus = null)
        {
            var queryParameters = QueryParameters.Create<uploadResult>();
            queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            if (filename != null)
                queryParameters = queryParameters.AddSingleValue("filename", filename.ToQueryString());
            if (comment != null)
                queryParameters = queryParameters.AddSingleValue("comment", comment.ToQueryString());
            if (text != null)
                queryParameters = queryParameters.AddSingleValue("text", text.ToQueryString());
            if (watchlist != null)
                queryParameters = queryParameters.AddSingleValue("watchlist", watchlist.ToQueryString());
            if (ignorewarnings != null)
                queryParameters = queryParameters.AddSingleValue("ignorewarnings", ignorewarnings.Value.ToQueryString());
            if (file != null)
                queryParameters = queryParameters.AddFile("file", file);
            if (url != null)
                queryParameters = queryParameters.AddSingleValue("url", url.ToQueryString());
            if (filekey != null)
                queryParameters = queryParameters.AddSingleValue("filekey", filekey.ToQueryString());
            if (stash != null)
                queryParameters = queryParameters.AddSingleValue("stash", stash.Value.ToQueryString());
            if (filesize != null)
                queryParameters = queryParameters.AddSingleValue("filesize", filesize.ToQueryString());
            if (offset != null)
                queryParameters = queryParameters.AddSingleValue("offset", offset.ToQueryString());
            if (chunk != null)
                queryParameters = queryParameters.AddFile("chunk", chunk);
            if (async != null)
                queryParameters = queryParameters.AddSingleValue("async", async.Value.ToQueryString());
            if (asyncdownload != null)
                queryParameters = queryParameters.AddSingleValue("asyncdownload", asyncdownload.Value.ToQueryString());
            if (leavemessage != null)
                queryParameters = queryParameters.AddSingleValue("leavemessage", leavemessage.Value.ToQueryString());
            if (statuskey != null)
                queryParameters = queryParameters.AddSingleValue("statuskey", statuskey.ToQueryString());
            if (checkstatus != null)
                queryParameters = queryParameters.AddSingleValue("checkstatus", checkstatus.Value.ToQueryString());
            return new QueryProcessor<uploadResult>(m_wiki, uploadProperties).ExecuteSingle(queryParameters);
        }

        private static readonly QueryTypeProperties<watchResult> watchProperties = new QueryTypeProperties<watchResult>("watch", "", null, null, new TupleList<string, string>() { { "action", "watch" } }, null, watchResult.Parse);

        ///<summary>
        ///Add or remove a page from/to the current user's watchlist
        ///</summary>
        ///<param name="title">
        ///The page to (un)watch
        ///</param >
        ///<param name="token">
        ///A token previously acquired via prop=info
        ///</param >
        ///<param name="unwatch">
        ///If set the page will be unwatched rather than watched
        ///</param >
        ///<param name="uselang">
        ///Language to show the message in
        ///</param >
        public watchResult watch(string title, string token, bool? unwatch = null, string uselang = null)
        {
            var queryParameters = QueryParameters.Create<watchResult>();
            queryParameters = queryParameters.AddSingleValue("title", title.ToQueryString());
            queryParameters = queryParameters.AddSingleValue("token", token.ToQueryString());
            if (unwatch != null)
                queryParameters = queryParameters.AddSingleValue("unwatch", unwatch.Value.ToQueryString());
            if (uselang != null)
                queryParameters = queryParameters.AddSingleValue("uselang", uselang.ToQueryString());
            return new QueryProcessor<watchResult>(m_wiki, watchProperties).ExecuteSingle(queryParameters);
        }
    }
}