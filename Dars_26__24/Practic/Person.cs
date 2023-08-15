namespace Dars_26__24.Practic;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Gender { get; set; }
    public string PhoneNumber { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}\n" +
               $"FirstName: {FirstName}\n" +
               $"LastName: {LastName}\n" +
               $"Email: {Email}\n" +
               $"Gender: {Gender}\n" +
               $"PhoneNumber: {PhoneNumber}\n";
    }
}
