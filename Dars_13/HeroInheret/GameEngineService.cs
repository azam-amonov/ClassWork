namespace Dars_13.Hero;
// GameEngineService yarataman 
// Serviceda Hero list collection yrataman 
// GameEngineService-da Display methodini yrataman u o'ziga hero list qabul qiladi
// GameEngineService-da kontructor yrataman un hero name va id oladi
// So'ngra unga uch ta object qo'shaman
// GameEngineService-dan OptimazedGameEngine class yarataman
// Uning konstruktorda yana 3 ta hero qo'shaman

public class GameEngineService
{
     public List<HeroModel> _heroList = new List<HeroModel>();

    public GameEngineService()
    {
        _heroList.Add(new HeroModel("Nimadur"));
        _heroList.Add(new HeroModel("Hero"));
        _heroList.Add(new HeroModel("H"));
    }
    
    public void Display()
    {
        foreach (var item in _heroList)
        {
            Console.WriteLine(item);
        }
    }

}