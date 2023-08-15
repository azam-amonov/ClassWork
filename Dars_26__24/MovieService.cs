using Dars_26__24.N24_T2;

namespace Dars_26__24;

public class MovieService
{
    private List<Movie> _moviesList;

    public MovieService()
    {
        _moviesList = new List<Movie>();
    }

    public List<Movie> Search(string searchKeyword)
    {
        var searchedMovie = 
                        _moviesList.Where(m => 
                                          m.Name.Contains(searchKeyword) ||
                                          m.Author.Contains(searchKeyword)).ToList();
        return searchedMovie;
    }

    public void Add(Movie movie)
    {
        _moviesList.Add(movie);
    }
    
}