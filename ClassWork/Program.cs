// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

// Console.Write("Enter your age: ");
//
// int age = int.Parse(Console.ReadLine());
//
// string Message(int age) => age switch
// {
//     < 18 => "You are to young",
//     >= 18 and < 90 => "You are welcome", 
//     _  => throw new ArgumentException("Invalid age")
// };
// Console.Write($"{Message(age)}");
// List<int> numList = new List<int>{1,2,3,4,5,6,7,8,9,10};
Random rand = new Random();
bool found = true;
int randNum = rand.Next(0, 10);

while (found)
{
    Console.Write("Enter number: ");
    try
    {
        int num = int.Parse(Console.ReadLine());
        if (num == randNum)
        {
            Console.WriteLine("Congratulations you guessed it!");
            found = false;
        }
    }
    catch (ArgumentOutOfRangeException)
    {
        throw new ArgumentOutOfRangeException("You couldn't guess the it");
    }
    catch (FormatException e)
    {
        Console.WriteLine("You're not entered the number");
    }
    
}



