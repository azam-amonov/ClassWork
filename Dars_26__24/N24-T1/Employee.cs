namespace Dars_26__24.N24_T1;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Salary { get; set; }
    public byte KPI { get; set; }

    public Employee(int id, string firstName, string lastName, decimal salary, byte kpi)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
        KPI = kpi;
    }

    public override string ToString()
    {
        return $"Id: {Id} FullName: {FirstName} {LastName} " +
               $"Salary: {Salary} " +
               $"KPI: {KPI} ";
    }
}