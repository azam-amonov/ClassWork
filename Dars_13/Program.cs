// See https://aka.ms/new-console-template for more information

using Dars_13.Hero;
using Dars_13.HeroInheret;
using Dars_13.N13_T2;

Console.WriteLine("Starting");
// GameEngineService hero1 = new GameEngineService();
// OptimazedGameEngine hero2 = new OptimazedGameEngine();
//
// hero1.Display();
// Console.WriteLine("");
// hero2.Display();

// Event 
EventManager eventManager = new EventManager();
eventManager.AddEvent("bbb", date: DateTime.Now.AddHours(-3));
eventManager.AddEvent("bbc", new TimeOnly(12, 00));
eventManager.Display();
