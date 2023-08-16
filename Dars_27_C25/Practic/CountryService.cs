// using System.Text.Json;
using Newtonsoft.Json;

namespace Dars_27_C25.Practic;

public class CountryService
{
    public void Test()
    {
        
        const string _sourcePath = "/Users/azamamonov/RiderProjects/ClassWork/Dars_27_C25/Practic/AllCountries.txt";

        string source = File.ReadAllText(_sourcePath);
        var countries = JsonConvert.DeserializeObject<List<Country>>(source);
        //var filteredData = countries.Where(x => x.Name.Common.Contains("u", StringComparison.OrdinalIgnoreCase));
        foreach (var f in countries)
        {
            Console.WriteLine(f.Name.Common);
        }

    }
}