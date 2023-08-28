namespace Dars_35_C30.N32_T1;

public class ShortenedLink
{
    public int Id {get; set; }
    public string OriginalUrl {get; set; }
    public string ShortenedUrl {get; set; }

    public ShortenedLink(int id, string originalUrl, string shortenedUrl)
    {
        Id = id;
        OriginalUrl = originalUrl;
        ShortenedUrl = shortenedUrl;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode() + OriginalUrl.GetHashCode() + ShortenedUrl.GetHashCode();
    }

    public override bool Equals(object obj )
    {
        return obj.GetHashCode() == this.GetHashCode();
    }
}