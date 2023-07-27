namespace Dars_13.N13_T2;

// Task
// - EventManager servicedan foydalaning
//     - unda quydagi methodlar bo'lsin
//     - Add ( name, DateTime ) - bunda aniq kunda bo'ladigan eventlar qo'shilsin
//     - Add ( name, TimeOnly ) - bunda har kuni bajariladigan eventlar qo'shilsin
//     - Display - oldin har kunlik eventlarni va keyingi 3 kundagi eventlar ro'yxati chiqarilsin


// Logic 
// Event Manager da name va datetime property yarataman
// Event Manager uchun contructor yrataman
// Add nomli method yataraman unda name va datetime bo'ladi
// Add nomli methodni overload qilaman name va timeonly bo'ladi
// Display method yataraman un evenlar ro'yxatnini chiqaradi
// Event dictionary yrataman unda ma'lumotlar bo'ladi

public class EventManager
{
    public string Name { get; set;}
    public DateTime Date { get; set;}
    public TimeOnly Time { get; set;}
    
    public Dictionary<string, DateTime> Events = new Dictionary<string, DateTime>();
    public Dictionary<string, TimeOnly> Events2 = new Dictionary<string, TimeOnly>();

  
    

    public void AddEvent(string name, DateTime date)
    {
        Events.Add(Name = name, Date = date);
        
    }

    public void AddEvent(string name, TimeOnly date)
    {
        Events2.Add(Name = name, Time = date);
    }

    public void Display()
    {
        foreach (var name in Events)
        {
            Console.WriteLine($"{name.Key}:  {name.Value}");
        }
    }
    
}