namespace Dars_12.N_12_T_3;

public class Hakaton
{
    public void Coders()
    {
        string[] codes1 = new string[] { "John", "Tim", "Bob" };
        string[] codes2 = new string[] { "John", "Bob", "Tim"};
        Array.Sort(codes1);
        Array.Sort(codes2);

        Console.WriteLine(codes1.SequenceEqual(codes2));
        Console.WriteLine(codes1.GetHashCode() == codes2.GetHashCode());
    }
}