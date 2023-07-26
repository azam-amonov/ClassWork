namespace Dars_12.N_12_T_3;

public class FindUser
{
    public void Search()
    {
        string[] names = new string[]
        {
            "Peter Michael Brown",
            "John David Smith",
            "John Johns Jones",
            "G`ishtmat G`ishtmatov G`ishtmatovich"
        };
        string name;
        
        Console.WriteLine("Enter names: ");
        name = Console.ReadLine();

        foreach (string n in names)
        {
            if(n.ToLower().Contains(name.ToLower()))
                Console.WriteLine("{0}", n);
        }
        
    }
    
}