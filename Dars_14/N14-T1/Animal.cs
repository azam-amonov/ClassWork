namespace Dars_14.N14_T1;

// N14-T1
//     - animal uchun Animal modelidan foydalaning unda FunFact methodi bo'lsin
//     - FunFact methodi parametersiz shunchaki qiziqarli faktni ekranga chiqarsin
//     - Animal dan 3 ta hayvon turi uchun tip yarating
//     - ularda FunFact methodini e'lon qliing
//     - 3 ta tipdan object e'lon qiling va 3 alasini ham Animal tipidagi o'zgaruvchida saqlang
//     - 3 ta objectdan FunFact methodini chaqiring


public class Animal
{
    public string Name { get; set; }
    
    public Animal(string name)
    {
        Name = name;
    }

    public virtual void FunFact()
    {
        Console.WriteLine("---");
    }
}

class Horse : Animal
{
    public Horse(string name) : base(name)
    {
    }

    public override void FunFact()
    {
        Console.WriteLine("Kan run very fast");
    }
}

class Carrot : Animal
{
    public Carrot(string name) : base(name)
    {
    }

    public override void FunFact()
    {
        Console.WriteLine("Can speak as a human!");
    }
}

class Fish : Animal
{
    public Fish(string name) : base(name)
    {
       
    }
    public override void FunFact()
    {
        Console.WriteLine("Can swim better than human!");
    }
}























