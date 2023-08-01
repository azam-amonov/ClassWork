namespace Dars_15.BurchakYuziniTopish.Rectangle;

public class Rectangle
{
    public Rectangle(Point a, Point b, Point c, Point d)
    {
        A = a;
        B = b;
        C = c;
        D = d;
    }
    
    public Point A { get; set; }
    public Point B { get; set; }
    public Point C { get; set;}
    public Point D { get; set; }
    
    public double AB { get => GetLength(A,B); }
    public double BC { get => GetLength(B, C); }
    public double CD { get => GetLength(C, D); }
    public double AD { get => GetLength(A, D);}
    
    public double Perimetr { get => AB + BC + CD + AD; }
    
    

    private double GetLength(Point a, Point b)
    {
        return Math.Sqrt(Math.Pow(a.X - b.X, 2) + Math.Pow(b.Y - a.Y, 2));
    }
}