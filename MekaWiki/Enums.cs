using LinqToWiki.Internals;

namespace TrksRecipeDoc.MekaWiki
{
    public sealed class deletewatchlist : StringValue
    {
        internal deletewatchlist(string value) : base(value)
        {
        }

        public static bool operator ==(deletewatchlist first, deletewatchlist second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(deletewatchlist first, deletewatchlist second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly deletewatchlist watch = new deletewatchlist("watch");
        public static readonly deletewatchlist unwatch = new deletewatchlist("unwatch");
        public static readonly deletewatchlist preferences = new deletewatchlist("preferences");
        public static readonly deletewatchlist nochange = new deletewatchlist("nochange");
    }

    public sealed class editresult : StringValue
    {
        internal editresult(string value) : base(value)
        {
        }

        public static bool operator ==(editresult first, editresult second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(editresult first, editresult second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly editresult Success = new editresult("Success");
        public static readonly editresult Failure = new editresult("Failure");
    }

    public sealed class editwatchlist : StringValue
    {
        internal editwatchlist(string value) : base(value)
        {
        }

        public static bool operator ==(editwatchlist first, editwatchlist second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(editwatchlist first, editwatchlist second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly editwatchlist watch = new editwatchlist("watch");
        public static readonly editwatchlist unwatch = new editwatchlist("unwatch");
        public static readonly editwatchlist preferences = new editwatchlist("preferences");
        public static readonly editwatchlist nochange = new editwatchlist("nochange");
    }

    public sealed class editcontentformat : StringValue
    {
        internal editcontentformat(string value) : base(value)
        {
        }

        public static bool operator ==(editcontentformat first, editcontentformat second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(editcontentformat first, editcontentformat second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly editcontentformat text_x_wiki = new editcontentformat("text/x-wiki");
        public static readonly editcontentformat text_javascript = new editcontentformat("text/javascript");
        public static readonly editcontentformat text_css = new editcontentformat("text/css");
        public static readonly editcontentformat text_plain = new editcontentformat("text/plain");
    }

    public sealed class editcontentmodel : StringValue
    {
        internal editcontentmodel(string value) : base(value)
        {
        }

        public static bool operator ==(editcontentmodel first, editcontentmodel second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(editcontentmodel first, editcontentmodel second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly editcontentmodel wikitext = new editcontentmodel("wikitext");
        public static readonly editcontentmodel javascript = new editcontentmodel("javascript");
        public static readonly editcontentmodel css = new editcontentmodel("css");
        public static readonly editcontentmodel text = new editcontentmodel("text");
    }

    public sealed class emailuserresult : StringValue
    {
        internal emailuserresult(string value) : base(value)
        {
        }

        public static bool operator ==(emailuserresult first, emailuserresult second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(emailuserresult first, emailuserresult second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly emailuserresult Success = new emailuserresult("Success");
        public static readonly emailuserresult Failure = new emailuserresult("Failure");
    }

    public sealed class filerevertresult : StringValue
    {
        internal filerevertresult(string value) : base(value)
        {
        }

        public static bool operator ==(filerevertresult first, filerevertresult second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(filerevertresult first, filerevertresult second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly filerevertresult Success = new filerevertresult("Success");
        public static readonly filerevertresult Failure = new filerevertresult("Failure");
    }

    public sealed class importinterwikisource : StringValue
    {
        internal importinterwikisource(string value) : base(value)
        {
        }

        public static bool operator ==(importinterwikisource first, importinterwikisource second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(importinterwikisource first, importinterwikisource second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

    public sealed class loginresult : StringValue
    {
        internal loginresult(string value) : base(value)
        {
        }

        public static bool operator ==(loginresult first, loginresult second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(loginresult first, loginresult second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly loginresult Success = new loginresult("Success");
        public static readonly loginresult NeedToken = new loginresult("NeedToken");
        public static readonly loginresult WrongToken = new loginresult("WrongToken");
        public static readonly loginresult NoName = new loginresult("NoName");
        public static readonly loginresult Illegal = new loginresult("Illegal");
        public static readonly loginresult WrongPluginPass = new loginresult("WrongPluginPass");
        public static readonly loginresult NotExists = new loginresult("NotExists");
        public static readonly loginresult WrongPass = new loginresult("WrongPass");
        public static readonly loginresult EmptyPass = new loginresult("EmptyPass");
        public static readonly loginresult CreateBlocked = new loginresult("CreateBlocked");
        public static readonly loginresult Throttled = new loginresult("Throttled");
        public static readonly loginresult Blocked = new loginresult("Blocked");
        public static readonly loginresult Aborted = new loginresult("Aborted");
    }

    public sealed class movewatchlist : StringValue
    {
        internal movewatchlist(string value) : base(value)
        {
        }

        public static bool operator ==(movewatchlist first, movewatchlist second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(movewatchlist first, movewatchlist second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly movewatchlist watch = new movewatchlist("watch");
        public static readonly movewatchlist unwatch = new movewatchlist("unwatch");
        public static readonly movewatchlist preferences = new movewatchlist("preferences");
        public static readonly movewatchlist nochange = new movewatchlist("nochange");
    }

    public sealed class optionsvalue : StringValue
    {
        internal optionsvalue(string value) : base(value)
        {
        }

        public static bool operator ==(optionsvalue first, optionsvalue second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(optionsvalue first, optionsvalue second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly optionsvalue success = new optionsvalue("success");
    }

    public sealed class optionsresetkinds : StringValue
    {
        internal optionsresetkinds(string value) : base(value)
        {
        }

        public static bool operator ==(optionsresetkinds first, optionsresetkinds second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(optionsresetkinds first, optionsresetkinds second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly optionsresetkinds registered = new optionsresetkinds("registered");
        public static readonly optionsresetkinds registered_multiselect = new optionsresetkinds("registered-multiselect");
        public static readonly optionsresetkinds registered_checkmatrix = new optionsresetkinds("registered-checkmatrix");
        public static readonly optionsresetkinds userjs = new optionsresetkinds("userjs");
        public static readonly optionsresetkinds unused = new optionsresetkinds("unused");
        public static readonly optionsresetkinds all = new optionsresetkinds("all");
    }

    public sealed class protectwatchlist : StringValue
    {
        internal protectwatchlist(string value) : base(value)
        {
        }

        public static bool operator ==(protectwatchlist first, protectwatchlist second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(protectwatchlist first, protectwatchlist second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly protectwatchlist watch = new protectwatchlist("watch");
        public static readonly protectwatchlist unwatch = new protectwatchlist("unwatch");
        public static readonly protectwatchlist preferences = new protectwatchlist("preferences");
        public static readonly protectwatchlist nochange = new protectwatchlist("nochange");
    }

    public sealed class purgegenerator : StringValue
    {
        internal purgegenerator(string value) : base(value)
        {
        }

        public static bool operator ==(purgegenerator first, purgegenerator second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(purgegenerator first, purgegenerator second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly purgegenerator allcategories = new purgegenerator("allcategories");
        public static readonly purgegenerator allfileusages = new purgegenerator("allfileusages");
        public static readonly purgegenerator allimages = new purgegenerator("allimages");
        public static readonly purgegenerator alllinks = new purgegenerator("alllinks");
        public static readonly purgegenerator allpages = new purgegenerator("allpages");
        public static readonly purgegenerator alltransclusions = new purgegenerator("alltransclusions");
        public static readonly purgegenerator backlinks = new purgegenerator("backlinks");
        public static readonly purgegenerator categories = new purgegenerator("categories");
        public static readonly purgegenerator categorymembers = new purgegenerator("categorymembers");
        public static readonly purgegenerator duplicatefiles = new purgegenerator("duplicatefiles");
        public static readonly purgegenerator embeddedin = new purgegenerator("embeddedin");
        public static readonly purgegenerator exturlusage = new purgegenerator("exturlusage");
        public static readonly purgegenerator images = new purgegenerator("images");
        public static readonly purgegenerator imageusage = new purgegenerator("imageusage");
        public static readonly purgegenerator iwbacklinks = new purgegenerator("iwbacklinks");
        public static readonly purgegenerator langbacklinks = new purgegenerator("langbacklinks");
        public static readonly purgegenerator links = new purgegenerator("links");
        public static readonly purgegenerator pageswithprop = new purgegenerator("pageswithprop");
        public static readonly purgegenerator protectedtitles = new purgegenerator("protectedtitles");
        public static readonly purgegenerator querypage = new purgegenerator("querypage");
        public static readonly purgegenerator random = new purgegenerator("random");
        public static readonly purgegenerator recentchanges = new purgegenerator("recentchanges");
        public static readonly purgegenerator search = new purgegenerator("search");
        public static readonly purgegenerator templates = new purgegenerator("templates");
        public static readonly purgegenerator watchlist = new purgegenerator("watchlist");
        public static readonly purgegenerator watchlistraw = new purgegenerator("watchlistraw");
    }

    public sealed class rollbackwatchlist : StringValue
    {
        internal rollbackwatchlist(string value) : base(value)
        {
        }

        public static bool operator ==(rollbackwatchlist first, rollbackwatchlist second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(rollbackwatchlist first, rollbackwatchlist second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly rollbackwatchlist watch = new rollbackwatchlist("watch");
        public static readonly rollbackwatchlist unwatch = new rollbackwatchlist("unwatch");
        public static readonly rollbackwatchlist preferences = new rollbackwatchlist("preferences");
        public static readonly rollbackwatchlist nochange = new rollbackwatchlist("nochange");
    }

    public sealed class setnotificationtimestampgenerator : StringValue
    {
        internal setnotificationtimestampgenerator(string value) : base(value)
        {
        }

        public static bool operator ==(setnotificationtimestampgenerator first, setnotificationtimestampgenerator second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(setnotificationtimestampgenerator first, setnotificationtimestampgenerator second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly setnotificationtimestampgenerator allcategories = new setnotificationtimestampgenerator("allcategories");
        public static readonly setnotificationtimestampgenerator allfileusages = new setnotificationtimestampgenerator("allfileusages");
        public static readonly setnotificationtimestampgenerator allimages = new setnotificationtimestampgenerator("allimages");
        public static readonly setnotificationtimestampgenerator alllinks = new setnotificationtimestampgenerator("alllinks");
        public static readonly setnotificationtimestampgenerator allpages = new setnotificationtimestampgenerator("allpages");
        public static readonly setnotificationtimestampgenerator alltransclusions = new setnotificationtimestampgenerator("alltransclusions");
        public static readonly setnotificationtimestampgenerator backlinks = new setnotificationtimestampgenerator("backlinks");
        public static readonly setnotificationtimestampgenerator categories = new setnotificationtimestampgenerator("categories");
        public static readonly setnotificationtimestampgenerator categorymembers = new setnotificationtimestampgenerator("categorymembers");
        public static readonly setnotificationtimestampgenerator duplicatefiles = new setnotificationtimestampgenerator("duplicatefiles");
        public static readonly setnotificationtimestampgenerator embeddedin = new setnotificationtimestampgenerator("embeddedin");
        public static readonly setnotificationtimestampgenerator exturlusage = new setnotificationtimestampgenerator("exturlusage");
        public static readonly setnotificationtimestampgenerator images = new setnotificationtimestampgenerator("images");
        public static readonly setnotificationtimestampgenerator imageusage = new setnotificationtimestampgenerator("imageusage");
        public static readonly setnotificationtimestampgenerator iwbacklinks = new setnotificationtimestampgenerator("iwbacklinks");
        public static readonly setnotificationtimestampgenerator langbacklinks = new setnotificationtimestampgenerator("langbacklinks");
        public static readonly setnotificationtimestampgenerator links = new setnotificationtimestampgenerator("links");
        public static readonly setnotificationtimestampgenerator pageswithprop = new setnotificationtimestampgenerator("pageswithprop");
        public static readonly setnotificationtimestampgenerator protectedtitles = new setnotificationtimestampgenerator("protectedtitles");
        public static readonly setnotificationtimestampgenerator querypage = new setnotificationtimestampgenerator("querypage");
        public static readonly setnotificationtimestampgenerator random = new setnotificationtimestampgenerator("random");
        public static readonly setnotificationtimestampgenerator recentchanges = new setnotificationtimestampgenerator("recentchanges");
        public static readonly setnotificationtimestampgenerator search = new setnotificationtimestampgenerator("search");
        public static readonly setnotificationtimestampgenerator templates = new setnotificationtimestampgenerator("templates");
        public static readonly setnotificationtimestampgenerator watchlist = new setnotificationtimestampgenerator("watchlist");
        public static readonly setnotificationtimestampgenerator watchlistraw = new setnotificationtimestampgenerator("watchlistraw");
    }

    public sealed class tokenstype : StringValue
    {
        internal tokenstype(string value) : base(value)
        {
        }

        public static bool operator ==(tokenstype first, tokenstype second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(tokenstype first, tokenstype second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly tokenstype block = new tokenstype("block");
        public static readonly tokenstype delete = new tokenstype("delete");
        public static readonly tokenstype edit = new tokenstype("edit");
        public static readonly tokenstype email = new tokenstype("email");
        public static readonly tokenstype import = new tokenstype("import");
        public static readonly tokenstype move = new tokenstype("move");
        public static readonly tokenstype options = new tokenstype("options");
        public static readonly tokenstype patrol = new tokenstype("patrol");
        public static readonly tokenstype protect = new tokenstype("protect");
        public static readonly tokenstype unblock = new tokenstype("unblock");
        public static readonly tokenstype watch = new tokenstype("watch");
    }

    public sealed class undeletewatchlist : StringValue
    {
        internal undeletewatchlist(string value) : base(value)
        {
        }

        public static bool operator ==(undeletewatchlist first, undeletewatchlist second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(undeletewatchlist first, undeletewatchlist second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly undeletewatchlist watch = new undeletewatchlist("watch");
        public static readonly undeletewatchlist unwatch = new undeletewatchlist("unwatch");
        public static readonly undeletewatchlist preferences = new undeletewatchlist("preferences");
        public static readonly undeletewatchlist nochange = new undeletewatchlist("nochange");
    }

    public sealed class uploadresult : StringValue
    {
        internal uploadresult(string value) : base(value)
        {
        }

        public static bool operator ==(uploadresult first, uploadresult second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(uploadresult first, uploadresult second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly uploadresult Success = new uploadresult("Success");
        public static readonly uploadresult Warning = new uploadresult("Warning");
        public static readonly uploadresult Continue = new uploadresult("Continue");
        public static readonly uploadresult Queued = new uploadresult("Queued");
    }

    public sealed class uploadwatchlist : StringValue
    {
        internal uploadwatchlist(string value) : base(value)
        {
        }

        public static bool operator ==(uploadwatchlist first, uploadwatchlist second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(uploadwatchlist first, uploadwatchlist second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly uploadwatchlist watch = new uploadwatchlist("watch");
        public static readonly uploadwatchlist preferences = new uploadwatchlist("preferences");
        public static readonly uploadwatchlist nochange = new uploadwatchlist("nochange");
    }

    public sealed class allimagesfilterbots : StringValue
    {
        internal allimagesfilterbots(string value) : base(value)
        {
        }

        public static bool operator ==(allimagesfilterbots first, allimagesfilterbots second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(allimagesfilterbots first, allimagesfilterbots second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly allimagesfilterbots all = new allimagesfilterbots("all");
        public static readonly allimagesfilterbots bots = new allimagesfilterbots("bots");
        public static readonly allimagesfilterbots nobots = new allimagesfilterbots("nobots");
    }

    public sealed class allmessagescustomised : StringValue
    {
        internal allmessagescustomised(string value) : base(value)
        {
        }

        public static bool operator ==(allmessagescustomised first, allmessagescustomised second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(allmessagescustomised first, allmessagescustomised second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly allmessagescustomised all = new allmessagescustomised("all");
        public static readonly allmessagescustomised modified = new allmessagescustomised("modified");
        public static readonly allmessagescustomised unmodified = new allmessagescustomised("unmodified");
    }

    public sealed class allpagesfilterredir : StringValue
    {
        internal allpagesfilterredir(string value) : base(value)
        {
        }

        public static bool operator ==(allpagesfilterredir first, allpagesfilterredir second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(allpagesfilterredir first, allpagesfilterredir second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly allpagesfilterredir all = new allpagesfilterredir("all");
        public static readonly allpagesfilterredir redirects = new allpagesfilterredir("redirects");
        public static readonly allpagesfilterredir nonredirects = new allpagesfilterredir("nonredirects");
    }

    public sealed class allpagesprtype : StringValue
    {
        internal allpagesprtype(string value) : base(value)
        {
        }

        public static bool operator ==(allpagesprtype first, allpagesprtype second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(allpagesprtype first, allpagesprtype second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly allpagesprtype edit = new allpagesprtype("edit");
        public static readonly allpagesprtype move = new allpagesprtype("move");
        public static readonly allpagesprtype upload = new allpagesprtype("upload");
    }

    public sealed class allpagesprlevel : StringValue
    {
        internal allpagesprlevel(string value) : base(value)
        {
        }

        public static bool operator ==(allpagesprlevel first, allpagesprlevel second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(allpagesprlevel first, allpagesprlevel second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly allpagesprlevel none = new allpagesprlevel("");
        public static readonly allpagesprlevel autoconfirmed = new allpagesprlevel("autoconfirmed");
        public static readonly allpagesprlevel sysop = new allpagesprlevel("sysop");
    }

    public sealed class allpagesprfiltercascade : StringValue
    {
        internal allpagesprfiltercascade(string value) : base(value)
        {
        }

        public static bool operator ==(allpagesprfiltercascade first, allpagesprfiltercascade second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(allpagesprfiltercascade first, allpagesprfiltercascade second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly allpagesprfiltercascade cascading = new allpagesprfiltercascade("cascading");
        public static readonly allpagesprfiltercascade noncascading = new allpagesprfiltercascade("noncascading");
        public static readonly allpagesprfiltercascade all = new allpagesprfiltercascade("all");
    }

    public sealed class allpagesfilterlanglinks : StringValue
    {
        internal allpagesfilterlanglinks(string value) : base(value)
        {
        }

        public static bool operator ==(allpagesfilterlanglinks first, allpagesfilterlanglinks second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(allpagesfilterlanglinks first, allpagesfilterlanglinks second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly allpagesfilterlanglinks withlanglinks = new allpagesfilterlanglinks("withlanglinks");
        public static readonly allpagesfilterlanglinks withoutlanglinks = new allpagesfilterlanglinks("withoutlanglinks");
        public static readonly allpagesfilterlanglinks all = new allpagesfilterlanglinks("all");
    }

    public sealed class allpagesprexpiry : StringValue
    {
        internal allpagesprexpiry(string value) : base(value)
        {
        }

        public static bool operator ==(allpagesprexpiry first, allpagesprexpiry second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(allpagesprexpiry first, allpagesprexpiry second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly allpagesprexpiry indefinite = new allpagesprexpiry("indefinite");
        public static readonly allpagesprexpiry definite = new allpagesprexpiry("definite");
        public static readonly allpagesprexpiry all = new allpagesprexpiry("all");
    }

    public sealed class allusersgroup : StringValue
    {
        internal allusersgroup(string value) : base(value)
        {
        }

        public static bool operator ==(allusersgroup first, allusersgroup second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(allusersgroup first, allusersgroup second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly allusersgroup bot = new allusersgroup("bot");
        public static readonly allusersgroup sysop = new allusersgroup("sysop");
        public static readonly allusersgroup bureaucrat = new allusersgroup("bureaucrat");
    }

    public sealed class allusersrights : StringValue
    {
        internal allusersrights(string value) : base(value)
        {
        }

        public static bool operator ==(allusersrights first, allusersrights second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(allusersrights first, allusersrights second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly allusersrights apihighlimits = new allusersrights("apihighlimits");
        public static readonly allusersrights autoconfirmed = new allusersrights("autoconfirmed");
        public static readonly allusersrights autopatrol = new allusersrights("autopatrol");
        public static readonly allusersrights bigdelete = new allusersrights("bigdelete");
        public static readonly allusersrights block = new allusersrights("block");
        public static readonly allusersrights blockemail = new allusersrights("blockemail");
        public static readonly allusersrights bot = new allusersrights("bot");
        public static readonly allusersrights browsearchive = new allusersrights("browsearchive");
        public static readonly allusersrights createaccount = new allusersrights("createaccount");
        public static readonly allusersrights createpage = new allusersrights("createpage");
        public static readonly allusersrights createtalk = new allusersrights("createtalk");
        public static readonly allusersrights delete = new allusersrights("delete");
        public static readonly allusersrights deletedhistory = new allusersrights("deletedhistory");
        public static readonly allusersrights deletedtext = new allusersrights("deletedtext");
        public static readonly allusersrights deletelogentry = new allusersrights("deletelogentry");
        public static readonly allusersrights deleterevision = new allusersrights("deleterevision");
        public static readonly allusersrights edit = new allusersrights("edit");
        public static readonly allusersrights editinterface = new allusersrights("editinterface");
        public static readonly allusersrights editprotected = new allusersrights("editprotected");
        public static readonly allusersrights editmyoptions = new allusersrights("editmyoptions");
        public static readonly allusersrights editmyprivateinfo = new allusersrights("editmyprivateinfo");
        public static readonly allusersrights editmyusercss = new allusersrights("editmyusercss");
        public static readonly allusersrights editmyuserjs = new allusersrights("editmyuserjs");
        public static readonly allusersrights editmywatchlist = new allusersrights("editmywatchlist");
        public static readonly allusersrights editsemiprotected = new allusersrights("editsemiprotected");
        public static readonly allusersrights editusercssjs = new allusersrights("editusercssjs");
        public static readonly allusersrights editusercss = new allusersrights("editusercss");
        public static readonly allusersrights edituserjs = new allusersrights("edituserjs");
        public static readonly allusersrights hideuser = new allusersrights("hideuser");
        public static readonly allusersrights import = new allusersrights("import");
        public static readonly allusersrights importupload = new allusersrights("importupload");
        public static readonly allusersrights ipblock_exempt = new allusersrights("ipblock-exempt");
        public static readonly allusersrights markbotedits = new allusersrights("markbotedits");
        public static readonly allusersrights mergehistory = new allusersrights("mergehistory");
        public static readonly allusersrights minoredit = new allusersrights("minoredit");
        public static readonly allusersrights move = new allusersrights("move");
        public static readonly allusersrights movefile = new allusersrights("movefile");
        public static readonly allusersrights move_rootuserpages = new allusersrights("move-rootuserpages");
        public static readonly allusersrights move_subpages = new allusersrights("move-subpages");
        public static readonly allusersrights nominornewtalk = new allusersrights("nominornewtalk");
        public static readonly allusersrights noratelimit = new allusersrights("noratelimit");
        public static readonly allusersrights override_export_depth = new allusersrights("override-export-depth");
        public static readonly allusersrights passwordreset = new allusersrights("passwordreset");
        public static readonly allusersrights patrol = new allusersrights("patrol");
        public static readonly allusersrights patrolmarks = new allusersrights("patrolmarks");
        public static readonly allusersrights protect = new allusersrights("protect");
        public static readonly allusersrights proxyunbannable = new allusersrights("proxyunbannable");
        public static readonly allusersrights purge = new allusersrights("purge");
        public static readonly allusersrights read = new allusersrights("read");
        public static readonly allusersrights reupload = new allusersrights("reupload");
        public static readonly allusersrights reupload_own = new allusersrights("reupload-own");
        public static readonly allusersrights reupload_shared = new allusersrights("reupload-shared");
        public static readonly allusersrights rollback = new allusersrights("rollback");
        public static readonly allusersrights sendemail = new allusersrights("sendemail");
        public static readonly allusersrights siteadmin = new allusersrights("siteadmin");
        public static readonly allusersrights suppressionlog = new allusersrights("suppressionlog");
        public static readonly allusersrights suppressredirect = new allusersrights("suppressredirect");
        public static readonly allusersrights suppressrevision = new allusersrights("suppressrevision");
        public static readonly allusersrights unblockself = new allusersrights("unblockself");
        public static readonly allusersrights undelete = new allusersrights("undelete");
        public static readonly allusersrights unwatchedpages = new allusersrights("unwatchedpages");
        public static readonly allusersrights upload = new allusersrights("upload");
        public static readonly allusersrights upload_by_url = new allusersrights("upload_by_url");
        public static readonly allusersrights userrights = new allusersrights("userrights");
        public static readonly allusersrights userrights_interwiki = new allusersrights("userrights-interwiki");
        public static readonly allusersrights viewmyprivateinfo = new allusersrights("viewmyprivateinfo");
        public static readonly allusersrights viewmywatchlist = new allusersrights("viewmywatchlist");
        public static readonly allusersrights writeapi = new allusersrights("writeapi");
        public static readonly allusersrights nuke = new allusersrights("nuke");
    }

    public sealed class backlinksfilterredir : StringValue
    {
        internal backlinksfilterredir(string value) : base(value)
        {
        }

        public static bool operator ==(backlinksfilterredir first, backlinksfilterredir second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(backlinksfilterredir first, backlinksfilterredir second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly backlinksfilterredir all = new backlinksfilterredir("all");
        public static readonly backlinksfilterredir redirects = new backlinksfilterredir("redirects");
        public static readonly backlinksfilterredir nonredirects = new backlinksfilterredir("nonredirects");
    }

    public sealed class blocksshow : StringValue
    {
        internal blocksshow(string value) : base(value)
        {
        }

        public static bool operator ==(blocksshow first, blocksshow second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(blocksshow first, blocksshow second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly blocksshow account = new blocksshow("account");
        public static readonly blocksshow not_account = new blocksshow("!account");
        public static readonly blocksshow temp = new blocksshow("temp");
        public static readonly blocksshow not_temp = new blocksshow("!temp");
        public static readonly blocksshow ip = new blocksshow("ip");
        public static readonly blocksshow not_ip = new blocksshow("!ip");
        public static readonly blocksshow range = new blocksshow("range");
        public static readonly blocksshow not_range = new blocksshow("!range");
    }

    public sealed class categoriesshow : StringValue
    {
        internal categoriesshow(string value) : base(value)
        {
        }

        public static bool operator ==(categoriesshow first, categoriesshow second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(categoriesshow first, categoriesshow second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly categoriesshow hidden = new categoriesshow("hidden");
        public static readonly categoriesshow not_hidden = new categoriesshow("!hidden");
    }

    public sealed class categorymemberstype : StringValue
    {
        internal categorymemberstype(string value) : base(value)
        {
        }

        public static bool operator ==(categorymemberstype first, categorymemberstype second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(categorymemberstype first, categorymemberstype second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly categorymemberstype page = new categorymemberstype("page");
        public static readonly categorymemberstype subcat = new categorymemberstype("subcat");
        public static readonly categorymemberstype file = new categorymemberstype("file");
    }

    public sealed class embeddedinfilterredir : StringValue
    {
        internal embeddedinfilterredir(string value) : base(value)
        {
        }

        public static bool operator ==(embeddedinfilterredir first, embeddedinfilterredir second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(embeddedinfilterredir first, embeddedinfilterredir second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly embeddedinfilterredir all = new embeddedinfilterredir("all");
        public static readonly embeddedinfilterredir redirects = new embeddedinfilterredir("redirects");
        public static readonly embeddedinfilterredir nonredirects = new embeddedinfilterredir("nonredirects");
    }

    public sealed class extlinksprotocol : StringValue
    {
        internal extlinksprotocol(string value) : base(value)
        {
        }

        public static bool operator ==(extlinksprotocol first, extlinksprotocol second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(extlinksprotocol first, extlinksprotocol second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly extlinksprotocol none = new extlinksprotocol("");
        public static readonly extlinksprotocol http = new extlinksprotocol("http");
        public static readonly extlinksprotocol https = new extlinksprotocol("https");
        public static readonly extlinksprotocol ftp = new extlinksprotocol("ftp");
        public static readonly extlinksprotocol ftps = new extlinksprotocol("ftps");
        public static readonly extlinksprotocol ssh = new extlinksprotocol("ssh");
        public static readonly extlinksprotocol sftp = new extlinksprotocol("sftp");
        public static readonly extlinksprotocol irc = new extlinksprotocol("irc");
        public static readonly extlinksprotocol ircs = new extlinksprotocol("ircs");
        public static readonly extlinksprotocol xmpp = new extlinksprotocol("xmpp");
        public static readonly extlinksprotocol sip = new extlinksprotocol("sip");
        public static readonly extlinksprotocol sips = new extlinksprotocol("sips");
        public static readonly extlinksprotocol gopher = new extlinksprotocol("gopher");
        public static readonly extlinksprotocol telnet = new extlinksprotocol("telnet");
        public static readonly extlinksprotocol nntp = new extlinksprotocol("nntp");
        public static readonly extlinksprotocol worldwind = new extlinksprotocol("worldwind");
        public static readonly extlinksprotocol mailto = new extlinksprotocol("mailto");
        public static readonly extlinksprotocol tel = new extlinksprotocol("tel");
        public static readonly extlinksprotocol sms = new extlinksprotocol("sms");
        public static readonly extlinksprotocol news = new extlinksprotocol("news");
        public static readonly extlinksprotocol svn = new extlinksprotocol("svn");
        public static readonly extlinksprotocol git = new extlinksprotocol("git");
        public static readonly extlinksprotocol mms = new extlinksprotocol("mms");
        public static readonly extlinksprotocol bitcoin = new extlinksprotocol("bitcoin");
        public static readonly extlinksprotocol magnet = new extlinksprotocol("magnet");
        public static readonly extlinksprotocol urn = new extlinksprotocol("urn");
        public static readonly extlinksprotocol geo = new extlinksprotocol("geo");
    }

    public sealed class exturlusageprotocol : StringValue
    {
        internal exturlusageprotocol(string value) : base(value)
        {
        }

        public static bool operator ==(exturlusageprotocol first, exturlusageprotocol second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(exturlusageprotocol first, exturlusageprotocol second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly exturlusageprotocol none = new exturlusageprotocol("");
        public static readonly exturlusageprotocol http = new exturlusageprotocol("http");
        public static readonly exturlusageprotocol https = new exturlusageprotocol("https");
        public static readonly exturlusageprotocol ftp = new exturlusageprotocol("ftp");
        public static readonly exturlusageprotocol ftps = new exturlusageprotocol("ftps");
        public static readonly exturlusageprotocol ssh = new exturlusageprotocol("ssh");
        public static readonly exturlusageprotocol sftp = new exturlusageprotocol("sftp");
        public static readonly exturlusageprotocol irc = new exturlusageprotocol("irc");
        public static readonly exturlusageprotocol ircs = new exturlusageprotocol("ircs");
        public static readonly exturlusageprotocol xmpp = new exturlusageprotocol("xmpp");
        public static readonly exturlusageprotocol sip = new exturlusageprotocol("sip");
        public static readonly exturlusageprotocol sips = new exturlusageprotocol("sips");
        public static readonly exturlusageprotocol gopher = new exturlusageprotocol("gopher");
        public static readonly exturlusageprotocol telnet = new exturlusageprotocol("telnet");
        public static readonly exturlusageprotocol nntp = new exturlusageprotocol("nntp");
        public static readonly exturlusageprotocol worldwind = new exturlusageprotocol("worldwind");
        public static readonly exturlusageprotocol mailto = new exturlusageprotocol("mailto");
        public static readonly exturlusageprotocol tel = new exturlusageprotocol("tel");
        public static readonly exturlusageprotocol sms = new exturlusageprotocol("sms");
        public static readonly exturlusageprotocol news = new exturlusageprotocol("news");
        public static readonly exturlusageprotocol svn = new exturlusageprotocol("svn");
        public static readonly exturlusageprotocol git = new exturlusageprotocol("git");
        public static readonly exturlusageprotocol mms = new exturlusageprotocol("mms");
        public static readonly exturlusageprotocol bitcoin = new exturlusageprotocol("bitcoin");
        public static readonly exturlusageprotocol magnet = new exturlusageprotocol("magnet");
        public static readonly exturlusageprotocol urn = new exturlusageprotocol("urn");
        public static readonly exturlusageprotocol geo = new exturlusageprotocol("geo");
    }

    public sealed class imageusagefilterredir : StringValue
    {
        internal imageusagefilterredir(string value) : base(value)
        {
        }

        public static bool operator ==(imageusagefilterredir first, imageusagefilterredir second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(imageusagefilterredir first, imageusagefilterredir second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly imageusagefilterredir all = new imageusagefilterredir("all");
        public static readonly imageusagefilterredir redirects = new imageusagefilterredir("redirects");
        public static readonly imageusagefilterredir nonredirects = new imageusagefilterredir("nonredirects");
    }

    public sealed class logeventstype : StringValue
    {
        internal logeventstype(string value) : base(value)
        {
        }

        public static bool operator ==(logeventstype first, logeventstype second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(logeventstype first, logeventstype second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly logeventstype none = new logeventstype("");
        public static readonly logeventstype block = new logeventstype("block");
        public static readonly logeventstype protect = new logeventstype("protect");
        public static readonly logeventstype rights = new logeventstype("rights");
        public static readonly logeventstype delete = new logeventstype("delete");
        public static readonly logeventstype upload = new logeventstype("upload");
        public static readonly logeventstype move = new logeventstype("move");
        public static readonly logeventstype import = new logeventstype("import");
        public static readonly logeventstype patrol = new logeventstype("patrol");
        public static readonly logeventstype merge = new logeventstype("merge");
        public static readonly logeventstype suppress = new logeventstype("suppress");
        public static readonly logeventstype newusers = new logeventstype("newusers");
    }

    public sealed class logeventsaction : StringValue
    {
        internal logeventsaction(string value) : base(value)
        {
        }

        public static bool operator ==(logeventsaction first, logeventsaction second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(logeventsaction first, logeventsaction second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly logeventsaction block_block = new logeventsaction("block/block");
        public static readonly logeventsaction block_unblock = new logeventsaction("block/unblock");
        public static readonly logeventsaction block_reblock = new logeventsaction("block/reblock");
        public static readonly logeventsaction protect_protect = new logeventsaction("protect/protect");
        public static readonly logeventsaction protect_modify = new logeventsaction("protect/modify");
        public static readonly logeventsaction protect_unprotect = new logeventsaction("protect/unprotect");
        public static readonly logeventsaction protect_move_prot = new logeventsaction("protect/move_prot");
        public static readonly logeventsaction upload_upload = new logeventsaction("upload/upload");
        public static readonly logeventsaction upload_overwrite = new logeventsaction("upload/overwrite");
        public static readonly logeventsaction upload_revert = new logeventsaction("upload/revert");
        public static readonly logeventsaction import_upload = new logeventsaction("import/upload");
        public static readonly logeventsaction import_interwiki = new logeventsaction("import/interwiki");
        public static readonly logeventsaction merge_merge = new logeventsaction("merge/merge");
        public static readonly logeventsaction suppress_block = new logeventsaction("suppress/block");
        public static readonly logeventsaction suppress_reblock = new logeventsaction("suppress/reblock");
        public static readonly logeventsaction move_move = new logeventsaction("move/move");
        public static readonly logeventsaction move_move_redir = new logeventsaction("move/move_redir");
        public static readonly logeventsaction delete_delete = new logeventsaction("delete/delete");
        public static readonly logeventsaction delete_restore = new logeventsaction("delete/restore");
        public static readonly logeventsaction delete_revision = new logeventsaction("delete/revision");
        public static readonly logeventsaction delete_event = new logeventsaction("delete/event");
        public static readonly logeventsaction suppress_revision = new logeventsaction("suppress/revision");
        public static readonly logeventsaction suppress_event = new logeventsaction("suppress/event");
        public static readonly logeventsaction suppress_delete = new logeventsaction("suppress/delete");
        public static readonly logeventsaction patrol_patrol = new logeventsaction("patrol/patrol");
        public static readonly logeventsaction rights_rights = new logeventsaction("rights/rights");
        public static readonly logeventsaction rights_autopromote = new logeventsaction("rights/autopromote");
        public static readonly logeventsaction newusers_newusers = new logeventsaction("newusers/newusers");
        public static readonly logeventsaction newusers_create = new logeventsaction("newusers/create");
        public static readonly logeventsaction newusers_create2 = new logeventsaction("newusers/create2");
        public static readonly logeventsaction newusers_byemail = new logeventsaction("newusers/byemail");
        public static readonly logeventsaction newusers_autocreate = new logeventsaction("newusers/autocreate");
    }

    public sealed class protectedtitleslevel : StringValue
    {
        internal protectedtitleslevel(string value) : base(value)
        {
        }

        public static bool operator ==(protectedtitleslevel first, protectedtitleslevel second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(protectedtitleslevel first, protectedtitleslevel second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly protectedtitleslevel autoconfirmed = new protectedtitleslevel("autoconfirmed");
        public static readonly protectedtitleslevel sysop = new protectedtitleslevel("sysop");
    }

    public sealed class querypagepage : StringValue
    {
        internal querypagepage(string value) : base(value)
        {
        }

        public static bool operator ==(querypagepage first, querypagepage second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(querypagepage first, querypagepage second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly querypagepage Ancientpages = new querypagepage("Ancientpages");
        public static readonly querypagepage BrokenRedirects = new querypagepage("BrokenRedirects");
        public static readonly querypagepage Deadendpages = new querypagepage("Deadendpages");
        public static readonly querypagepage DoubleRedirects = new querypagepage("DoubleRedirects");
        public static readonly querypagepage Listredirects = new querypagepage("Listredirects");
        public static readonly querypagepage Lonelypages = new querypagepage("Lonelypages");
        public static readonly querypagepage Longpages = new querypagepage("Longpages");
        public static readonly querypagepage Mostcategories = new querypagepage("Mostcategories");
        public static readonly querypagepage Mostimages = new querypagepage("Mostimages");
        public static readonly querypagepage Mostinterwikis = new querypagepage("Mostinterwikis");
        public static readonly querypagepage Mostlinkedcategories = new querypagepage("Mostlinkedcategories");
        public static readonly querypagepage Mostlinkedtemplates = new querypagepage("Mostlinkedtemplates");
        public static readonly querypagepage Mostlinked = new querypagepage("Mostlinked");
        public static readonly querypagepage Mostrevisions = new querypagepage("Mostrevisions");
        public static readonly querypagepage Fewestrevisions = new querypagepage("Fewestrevisions");
        public static readonly querypagepage Shortpages = new querypagepage("Shortpages");
        public static readonly querypagepage Uncategorizedcategories = new querypagepage("Uncategorizedcategories");
        public static readonly querypagepage Uncategorizedpages = new querypagepage("Uncategorizedpages");
        public static readonly querypagepage Uncategorizedimages = new querypagepage("Uncategorizedimages");
        public static readonly querypagepage Uncategorizedtemplates = new querypagepage("Uncategorizedtemplates");
        public static readonly querypagepage Unusedcategories = new querypagepage("Unusedcategories");
        public static readonly querypagepage Unusedimages = new querypagepage("Unusedimages");
        public static readonly querypagepage Wantedcategories = new querypagepage("Wantedcategories");
        public static readonly querypagepage Wantedfiles = new querypagepage("Wantedfiles");
        public static readonly querypagepage Wantedpages = new querypagepage("Wantedpages");
        public static readonly querypagepage Wantedtemplates = new querypagepage("Wantedtemplates");
        public static readonly querypagepage Unwatchedpages = new querypagepage("Unwatchedpages");
        public static readonly querypagepage Unusedtemplates = new querypagepage("Unusedtemplates");
        public static readonly querypagepage Withoutinterwiki = new querypagepage("Withoutinterwiki");
        public static readonly querypagepage Popularpages = new querypagepage("Popularpages");
    }

    public sealed class recentchangestype : StringValue
    {
        internal recentchangestype(string value) : base(value)
        {
        }

        public static bool operator ==(recentchangestype first, recentchangestype second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(recentchangestype first, recentchangestype second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly recentchangestype edit = new recentchangestype("edit");
        public static readonly recentchangestype @new = new recentchangestype("new");
        public static readonly recentchangestype move = new recentchangestype("move");
        public static readonly recentchangestype log = new recentchangestype("log");
        public static readonly recentchangestype move_over_redirect = new recentchangestype("move over redirect");
    }

    public sealed class recentchangeslogtype : StringValue
    {
        internal recentchangeslogtype(string value) : base(value)
        {
        }

        public static bool operator ==(recentchangeslogtype first, recentchangeslogtype second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(recentchangeslogtype first, recentchangeslogtype second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly recentchangeslogtype none = new recentchangeslogtype("");
        public static readonly recentchangeslogtype block = new recentchangeslogtype("block");
        public static readonly recentchangeslogtype protect = new recentchangeslogtype("protect");
        public static readonly recentchangeslogtype rights = new recentchangeslogtype("rights");
        public static readonly recentchangeslogtype delete = new recentchangeslogtype("delete");
        public static readonly recentchangeslogtype upload = new recentchangeslogtype("upload");
        public static readonly recentchangeslogtype move = new recentchangeslogtype("move");
        public static readonly recentchangeslogtype import = new recentchangeslogtype("import");
        public static readonly recentchangeslogtype patrol = new recentchangeslogtype("patrol");
        public static readonly recentchangeslogtype merge = new recentchangeslogtype("merge");
        public static readonly recentchangeslogtype suppress = new recentchangeslogtype("suppress");
        public static readonly recentchangeslogtype newusers = new recentchangeslogtype("newusers");
    }

    public sealed class recentchangestoken : StringValue
    {
        internal recentchangestoken(string value) : base(value)
        {
        }

        public static bool operator ==(recentchangestoken first, recentchangestoken second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(recentchangestoken first, recentchangestoken second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly recentchangestoken patrol = new recentchangestoken("patrol");
    }

    public sealed class recentchangesshow : StringValue
    {
        internal recentchangesshow(string value) : base(value)
        {
        }

        public static bool operator ==(recentchangesshow first, recentchangesshow second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(recentchangesshow first, recentchangesshow second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly recentchangesshow minor = new recentchangesshow("minor");
        public static readonly recentchangesshow not_minor = new recentchangesshow("!minor");
        public static readonly recentchangesshow bot = new recentchangesshow("bot");
        public static readonly recentchangesshow not_bot = new recentchangesshow("!bot");
        public static readonly recentchangesshow anon = new recentchangesshow("anon");
        public static readonly recentchangesshow not_anon = new recentchangesshow("!anon");
        public static readonly recentchangesshow redirect = new recentchangesshow("redirect");
        public static readonly recentchangesshow not_redirect = new recentchangesshow("!redirect");
        public static readonly recentchangesshow patrolled = new recentchangesshow("patrolled");
        public static readonly recentchangesshow not_patrolled = new recentchangesshow("!patrolled");
    }

    public sealed class recentchangestype2 : StringValue
    {
        internal recentchangestype2(string value) : base(value)
        {
        }

        public static bool operator ==(recentchangestype2 first, recentchangestype2 second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(recentchangestype2 first, recentchangestype2 second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly recentchangestype2 edit = new recentchangestype2("edit");
        public static readonly recentchangestype2 external = new recentchangestype2("external");
        public static readonly recentchangestype2 @new = new recentchangestype2("new");
        public static readonly recentchangestype2 log = new recentchangestype2("log");
    }

    public sealed class revisionstoken : StringValue
    {
        internal revisionstoken(string value) : base(value)
        {
        }

        public static bool operator ==(revisionstoken first, revisionstoken second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(revisionstoken first, revisionstoken second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly revisionstoken rollback = new revisionstoken("rollback");
    }

    public sealed class revisionscontentformat : StringValue
    {
        internal revisionscontentformat(string value) : base(value)
        {
        }

        public static bool operator ==(revisionscontentformat first, revisionscontentformat second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(revisionscontentformat first, revisionscontentformat second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly revisionscontentformat text_x_wiki = new revisionscontentformat("text/x-wiki");
        public static readonly revisionscontentformat text_javascript = new revisionscontentformat("text/javascript");
        public static readonly revisionscontentformat text_css = new revisionscontentformat("text/css");
        public static readonly revisionscontentformat text_plain = new revisionscontentformat("text/plain");
    }

    public sealed class searchwhat : StringValue
    {
        internal searchwhat(string value) : base(value)
        {
        }

        public static bool operator ==(searchwhat first, searchwhat second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(searchwhat first, searchwhat second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly searchwhat title = new searchwhat("title");
        public static readonly searchwhat text = new searchwhat("text");
        public static readonly searchwhat nearmatch = new searchwhat("nearmatch");
    }

    public sealed class searchinfo : StringValue
    {
        internal searchinfo(string value) : base(value)
        {
        }

        public static bool operator ==(searchinfo first, searchinfo second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(searchinfo first, searchinfo second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly searchinfo totalhits = new searchinfo("totalhits");
        public static readonly searchinfo suggestion = new searchinfo("suggestion");
    }

    public sealed class usercontribsshow : StringValue
    {
        internal usercontribsshow(string value) : base(value)
        {
        }

        public static bool operator ==(usercontribsshow first, usercontribsshow second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(usercontribsshow first, usercontribsshow second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly usercontribsshow minor = new usercontribsshow("minor");
        public static readonly usercontribsshow not_minor = new usercontribsshow("!minor");
        public static readonly usercontribsshow patrolled = new usercontribsshow("patrolled");
        public static readonly usercontribsshow not_patrolled = new usercontribsshow("!patrolled");
    }

    public sealed class usersgender : StringValue
    {
        internal usersgender(string value) : base(value)
        {
        }

        public static bool operator ==(usersgender first, usersgender second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(usersgender first, usersgender second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly usersgender male = new usersgender("male");
        public static readonly usersgender female = new usersgender("female");
        public static readonly usersgender unknown = new usersgender("unknown");
    }

    public sealed class userstoken : StringValue
    {
        internal userstoken(string value) : base(value)
        {
        }

        public static bool operator ==(userstoken first, userstoken second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(userstoken first, userstoken second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly userstoken userrights = new userstoken("userrights");
    }

    public sealed class watchlisttype : StringValue
    {
        internal watchlisttype(string value) : base(value)
        {
        }

        public static bool operator ==(watchlisttype first, watchlisttype second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(watchlisttype first, watchlisttype second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly watchlisttype edit = new watchlisttype("edit");
        public static readonly watchlisttype @new = new watchlisttype("new");
        public static readonly watchlisttype move = new watchlisttype("move");
        public static readonly watchlisttype log = new watchlisttype("log");
        public static readonly watchlisttype move_over_redirect = new watchlisttype("move over redirect");
    }

    public sealed class watchlistlogtype : StringValue
    {
        internal watchlistlogtype(string value) : base(value)
        {
        }

        public static bool operator ==(watchlistlogtype first, watchlistlogtype second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(watchlistlogtype first, watchlistlogtype second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly watchlistlogtype none = new watchlistlogtype("");
        public static readonly watchlistlogtype block = new watchlistlogtype("block");
        public static readonly watchlistlogtype protect = new watchlistlogtype("protect");
        public static readonly watchlistlogtype rights = new watchlistlogtype("rights");
        public static readonly watchlistlogtype delete = new watchlistlogtype("delete");
        public static readonly watchlistlogtype upload = new watchlistlogtype("upload");
        public static readonly watchlistlogtype move = new watchlistlogtype("move");
        public static readonly watchlistlogtype import = new watchlistlogtype("import");
        public static readonly watchlistlogtype patrol = new watchlistlogtype("patrol");
        public static readonly watchlistlogtype merge = new watchlistlogtype("merge");
        public static readonly watchlistlogtype suppress = new watchlistlogtype("suppress");
        public static readonly watchlistlogtype newusers = new watchlistlogtype("newusers");
    }

    public sealed class watchlistshow : StringValue
    {
        internal watchlistshow(string value) : base(value)
        {
        }

        public static bool operator ==(watchlistshow first, watchlistshow second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(watchlistshow first, watchlistshow second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly watchlistshow minor = new watchlistshow("minor");
        public static readonly watchlistshow not_minor = new watchlistshow("!minor");
        public static readonly watchlistshow bot = new watchlistshow("bot");
        public static readonly watchlistshow not_bot = new watchlistshow("!bot");
        public static readonly watchlistshow anon = new watchlistshow("anon");
        public static readonly watchlistshow not_anon = new watchlistshow("!anon");
        public static readonly watchlistshow patrolled = new watchlistshow("patrolled");
        public static readonly watchlistshow not_patrolled = new watchlistshow("!patrolled");
    }

    public sealed class watchlisttype2 : StringValue
    {
        internal watchlisttype2(string value) : base(value)
        {
        }

        public static bool operator ==(watchlisttype2 first, watchlisttype2 second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(watchlisttype2 first, watchlisttype2 second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly watchlisttype2 edit = new watchlisttype2("edit");
        public static readonly watchlisttype2 external = new watchlisttype2("external");
        public static readonly watchlisttype2 @new = new watchlisttype2("new");
        public static readonly watchlisttype2 log = new watchlisttype2("log");
    }

    public sealed class watchlistrawshow : StringValue
    {
        internal watchlistrawshow(string value) : base(value)
        {
        }

        public static bool operator ==(watchlistrawshow first, watchlistrawshow second)
        {
            return Equals(first, second);
        }

        public static bool operator !=(watchlistrawshow first, watchlistrawshow second)
        {
            return !Equals(first, second);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static readonly watchlistrawshow changed = new watchlistrawshow("changed");
        public static readonly watchlistrawshow not_changed = new watchlistrawshow("!changed");
    }
}