namespace Dars_26__24.N24_T2;

public class Movie
{
    public uint Id { get; set; }
    public string Name { get; set; }
    public string Author { get; set; }
    public uint Rating { get; set; }

    public Movie(uint id, string name, string author, uint rating)
    {
        Id = id;
        Name = name;
        Author = author;
        Rating = rating;
    }
}