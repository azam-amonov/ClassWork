namespace Dars_14.N14_T2;
// - barcha eventlarni plan qiladigan UltimatePlanner servise dan foydalaning
//     - unda parentdagi Add methodi override qilinsin - bitta soat ga to'g'ri keladigan 2 ta event kiritilganda - "You have conflict in daily plan" yozuvi chiqsin
//     - unda yangi Add methodi bo'lsin - u kalendar eventlarni kolleksiyaga qo'shsin
//     - Display methodi override qiling va unda oldin kalendar va keyin kunlik eventlar ekranga chiqarilsin
//     - object oling, 3 ta daily event ( 2 tasi bitta soatda ) qo'shing, 3 ta kalendar event qo'shing va display qiling

public class UltimatePlanner : Planner
{
    public TimeOnly Time { get; set; }
    
    public List<Event> Events = new List<Event>();

    public void AddEvent(string description, TimeOnly time)
    {
        Events.Add(new Event(description, time));
    }

    public  void Display()
    {
        foreach (var ev in Events)
        {
            Console.WriteLine(ev.Description, ev.Time);
        }
    }
}