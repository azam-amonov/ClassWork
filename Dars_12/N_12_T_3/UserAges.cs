namespace Dars_12.N_12_T_3;

public class UserAges
{
    public void UserAge()
    {
        int[] ages = new int[] { 12, 12, 23, 12, 35, 15, 17, 17, 16, 13, 45, 32 };
        
        Dictionary<int, int> dct = new Dictionary<int, int>();
        foreach (var a in ages)
        {
            if (dct.ContainsKey(a))
                dct[a]++;
            else
                dct[a] = 1;
        }

        foreach (var age in dct)
        {
            Console.WriteLine($"{age.Key} - {age.Value}");
        }

    }
}