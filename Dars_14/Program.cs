// See https://aka.ms/new-console-template for more information

using Dars_14.N14_T1;
using Dars_14.N14_T2;

Console.WriteLine("Success!");

// Animal horse = new Horse("Mustang");
// Animal carrot = new Carrot("Blue");
// Animal fish = new Fish("Nemo");
//
// horse.FunFact();
// carrot.FunFact();
// fish.FunFact();

Planner planner = new Planner();

planner.AddEvent("Do something", new DateOnly(2003, 12, 12));
planner.AddEvent("Do nothing", new DateOnly(2003, 11, 12));
planner.AddEvent("Do anything", new DateOnly(2003, 11, 10));

planner.Display();

UltimatePlanner exporter = new UltimatePlanner();
exporter.AddEvent("Do something", new TimeOnly(12, 20));
exporter.AddEvent("Do something", new TimeOnly(12, 20));
exporter.AddEvent("Do something", new TimeOnly(12, 20));

exporter.Display();