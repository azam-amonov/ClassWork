namespace Dars_12.N_12_T_3;

public class TaskOne
{
    public void SortDisplay()
    {
        string[] MoviesNames = new string[] {"Inception","Dark Knight","Top Gun 2", "Don't Look Up", "Top Gun",};
        Array.Sort(MoviesNames);
        
        foreach (var movie in MoviesNames)
        {
            Console.WriteLine($"{movie}");
        }
        
    }
    public void SortReverceDisplay()
    {
        string[] MoviesNames = new string[] {"Inception","Dark Knight","Top Gun 2", "Don't Look Up", "Top Gun",};
        Array.Sort(MoviesNames);
        Array.Reverse(MoviesNames);
        foreach (var movie in MoviesNames)
        {
            Console.WriteLine($"{movie}");
        }
        
    }
}