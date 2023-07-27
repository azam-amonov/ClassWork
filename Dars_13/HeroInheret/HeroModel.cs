// Task
//     - hero lar uchun Hero modelidan foydalaning ( id, name )
//     - Hero modelida string ga aylantirish methodidni override qiling
//     - o'yin uchun GameEngine servicidan foydalaning
//     - unda Hero lar list kolleksiyasida tursin
//     - GameEngine da Display methodi bo'lsin - u hamma hero larni ekranga chiqarsin
//     - GameEnginedagi konstruktor ichida kolleksiyaga 3 ta hero ni qo'shing
//     - GameEngine dan voris olgan OptimizedGameEngine servisini yarating
//     - undagi konstruktorda listga yana 3 ta hero qo'shing
//     - OptimizedGameEngine dan object olib Display methodini chaqiring

// Logic
// Hero model yarataman(Id int , Name String)
// Hero model uchun tostring metodini overriding qilaman
// GameEngineService yarataman 
// Serviceda Hero list collection yrataman 
// GameEngineService-da Display methodini yrataman u o'ziga hero list qabul qiladi
// GameEngineService-da kontructor yrataman un hero name va id oladi
// So'ngra unga uch ta object qo'shaman
// GameEngineService-dan OptimazedGameEngine class yarataman
// Uning konstruktorda yana 3 ta hero qo'shaman

namespace Dars_13.Hero;

public class HeroModel
{
    public HeroModel( string name)
    {
        Name = name;
        Id = Guid.NewGuid();
    }
    public Guid Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return $"{Name}: ____________________ {Id}";
    }
}

