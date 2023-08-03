namespace Dars_18.Amaliyot;

public class Malibu: AbstractCar
{
    public static int passengers;
    public readonly int maxSpeed;
    
    public override void Drive()
    {
        Console.WriteLine("Cor is moving!");
    }


    public Malibu(string brand, int year, string color, int maxSpeed, int passengers) 
                    : base(brand, color, year)
    {
        this.maxSpeed = maxSpeed;
        Malibu.passengers = passengers;
    }
  
}