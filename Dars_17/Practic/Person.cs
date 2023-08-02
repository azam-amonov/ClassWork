namespace Dars_17.Practic;

public class Person
{
    private string _name;
    private string _fullName;
    private string _dateOfBirth;
    
    public string Name { get; set; }
    public string FullName { get; set; }
    public DateOnly DateOfBirth { get; init; }
    public string Details { get; set; }
    public string Address { get; set; }
    public decimal Money { get; set; }
}