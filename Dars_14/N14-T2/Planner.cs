namespace Dars_14.N14_T2;

// - plan qiladigan Planner service dan foydalaning
//     - unda Add methodi bo'lsin - u kunlik eventlarni nomi bilan kolleksiyaga qo'shib borsin
//     - Display - display methodi barcha eventlarni ekranga chiqarsin
//     - object oling, 3 ta daily event qo'shing va display qiling 
//
//     

public class Event
{
    public string Description { get; set; }
    public DateOnly Date { get; set;}
    public TimeOnly Time { get; set; }
    

    public Event(string description, DateOnly date)
    {
        Description = description;
        Date = date;
    }

    public Event(string description, TimeOnly time)
    {
        Description = description;
        Time = time;
    }
}

public class Planner
{
    public List<Event> Events = new List<Event>();

    public Planner()
    {
        Events = new List<Event>();
    }

    public virtual void AddEvent(string name, DateOnly date)
    {
        Events.Add(new Event(name, date));
    }

    public void Display()
    {
        foreach (var ev in Events)
        {
            Console.WriteLine($"{ev.Description}, {ev.Date}");
        }
    }
}