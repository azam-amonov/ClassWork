namespace Dars_18.Amaliyot;

public abstract class AbstractCar
{
    public string Brand { get; init; }
    public int Year { get; init; }
    public string Color { get; set; }

    public virtual void Show()
    {
        Console.WriteLine($"Brand : {Brand}\n" +
                          $"Year: {Year}\n" +
                          $"Color: {Color}\n");
    }

    public abstract void Drive();

    public AbstractCar(string brand, string color, int year)
    {
        Brand = brand;
        Color = color;
        Year = year;
    }
}

