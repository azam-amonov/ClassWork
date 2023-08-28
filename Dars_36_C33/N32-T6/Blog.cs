namespace Dars_36_C33.N32_T6;

public class Blog
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }

    public Blog( string title, string body)
    {
        Id = Guid.NewGuid();
        Title = title;
        Body = body;
    }
}