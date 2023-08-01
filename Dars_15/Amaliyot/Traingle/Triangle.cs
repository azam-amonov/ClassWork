namespace Dars_15.BurchakYuziniTopish.Traingle;

public class Triangle
{
    public Triangle(double a, double b, double c)
    {
        if (!IsValidArgs(a, b, c))
            throw new ArgumentException("Invalid arguments");
        A = a;
        B = b;
        C = c;
    }
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    
    public double Perimeter { get => A + B + C;}

    public double Area
    {
        get
        {
            var p = Perimeter / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }

    private bool IsValidArgs(double a, double b, double c)
    {
        return a < b + c && b < a + c && c < a + b;
    }

}