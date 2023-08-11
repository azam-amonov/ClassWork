namespace Dars_21.Practic;

public class Practice
{
    public void GetArea(int a, int b, out int  P , out int S)
    {
        P = 2 * (a + b);
        S = a * b;
    }

    public void FindMinMax(out int min, out int max, params int[] nums)
    {
        min = nums[0];
        max = nums[0];
        foreach (var n in nums)
        {
            if (n < min)   min = n;
            if (n > max) max = n;
        }
    }

    public void DisplayInfo(string name, int age, bool isMerried = false)
    {
        Console.WriteLine($"Name: {name} Age: {age} Merried {isMerried}");
    }
    
}