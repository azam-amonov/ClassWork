namespace Dars_19.Amaliyot;

public class Person
{
    private int _age;
    private string _name;
    private string _city;
    private readonly string _nationality;
    
    public int Age
    {
        get => _age;
        set => _age = value;
    }
    
    public string Name { 
        get => _name;
        set => _name = value; }

    public string City
    {
        get => _city;
        set => _city = value;
    }

    public string Nationality
    {
        get => _nationality;
        
    }

    public Person()
    {
        
    }

    public Person(int age, string name, string city, string nationality)
    {
        Name = name;
        Age = age;
        City = city;
        _nationality = nationality;
    }

    public Person(Person person)
    {
        Name = person.Name;
        Age = person.Age;
        City = person.City;
        _nationality = person.Nationality;
    }
    
    static Person()
    {
        Console.WriteLine("Static constructor is working!");
    }

    public void Display()
    {
        Console.WriteLine($"Name{Name}\n" +
                          $"Age {Age}\n" +
                          $"Nationality {Nationality}\n" +
                          $"City {City}\n");
    }
}