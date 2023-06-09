namespace BookLibrary;

public class BookObj
{
    public List<Book> books { get; set; }

    public BookObj()
    {
        List<Book> books = new List<Book>();
    }
}

public class Book
{
    public int id { get; set; }
    public string display_name { get; set; }
    public string? abbr { get; set; }
    public string source_name { get; set; }
    public MetaObj meta { get; set; }
    public string? parent_name { get; set; }
    public int? book_parent_id { get; set; }
    public int? affiliate_id { get; set; }
    


    public Book()
    {
        id = 0;
        display_name = string.Empty;
        abbr = string.Empty;
        source_name = string.Empty;
        meta = null;
        parent_name = string.Empty;
        book_parent_id = 0;
        affiliate_id = 0;

    }
}

public class MetaObj
{
    public LogosObj logos { get; set; }
    public List<string> states { get; set; }
    public string? website { get; set; }
    public DeeplinkObj deeplink { get; set; }
    public bool is_legal { get; set; }
    public int? betsync_type { get; set; }
    public bool is_preferred { get; set; }
    public bool is_promoted { get; set; }
    public string? primary_color { get; set; }
    public int? betsync_status { get; set; }
    public string? secondary_color { get; set; }
    public bool is_fastbet_enabled_app { get; set; }
    public bool is_fastbet_enabled_web { get; set; }

    public MetaObj()
    {
        logos = new LogosObj();
        states = new List<string>();
        website = null;
        deeplink = new DeeplinkObj();
        is_legal = false;
        betsync_type = 0;
        is_preferred = false;
        is_promoted = false;
        primary_color = string.Empty;
        betsync_status = 0;
        secondary_color = null;
        is_fastbet_enabled_app = false;
        is_fastbet_enabled_web = false;
    }

}

public class LogosObj
{

    public string? promo { get; set; }
    public string? primary { get; set; }
    public string? thumbnail { get; set; }
    public string? betslip_carousel { get; set; }
    public string? brand_dark { get; set; }
    public string? brand_light { get; set; }
    public string? transparent { get; set; }
    
    public LogosObj()
    {
        promo = null;
        primary = null;
        thumbnail = null;
        betslip_carousel = null;
        brand_dark = null;
        brand_light = null;
        transparent = null;
    }
}

public class DeeplinkObj
{
    public bool has_multi { get; set; }
    public bool is_supported { get; set; }

    public DeeplinkObj()
    {
        has_multi = false;
        is_supported = false;
    }
}

