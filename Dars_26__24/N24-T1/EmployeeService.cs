namespace Dars_26__24.N24_T1;

public class EmployeeService
{
    private List<Employee> _employees;

    public EmployeeService()
    {
        _employees = new List<Employee>();
        
        _employees.Add(new Employee (1,"John","Dolor", 1000, 10));
        _employees.Add(new Employee(2,"Jane", "Smith", 1200, 8));
        _employees.Add(new Employee(3,"Michael", "Johnson", 950, 12));
        _employees.Add(new Employee(4,"Emily", "Williams", 1100, 9));
        _employees.Add(new Employee(5,"Robert", "Brown", 1050, 11));
        _employees.Add(new Employee( 6,"Jessica", "Davis", 1300, 72));
        _employees.Add(new Employee( 7,"William", "Miller", 900, 14));
        _employees.Add(new Employee( 8,"Olivia", "Martinez", 1150, 100));
        _employees.Add(new Employee( 9,"James", "Garcia", 980, 13));
       
        _employees.Add(new Employee(10,"Sophia", "Anderson", 1020, 30));
        _employees.Add(new Employee(11,"David", "Lopez", 1250, 88));
        _employees.Add(new Employee(12,"Ethan", "Hernandez", 1075, 10));
        _employees.Add(new Employee(13,"Ava", "Wilson", 1125, 9));
        _employees.Add(new Employee(14,"Liam", "Gonzalez", 980, 11));
        _employees.Add(new Employee(15,"Mia", "Taylor", 1180, 8));
        _employees.Add(new Employee(16,"Noah", "Lee", 1035, 12));
        _employees.Add(new Employee(17,"Isabella", "Moore", 1000, 10));
        _employees.Add(new Employee(18,"Lucas", "Jackson", 1225, 7));
        _employees.Add(new Employee(19,"Sophie", "White", 1070, 9));
        _employees.Add(new Employee(20,"Alexander", "Adams", 990, 11));
        _employees.Add(new Employee(21,"Charlotte", "Hall", 1155, 8));
    }
    public List<Employee> GetBySalary(int pageSize, int pageToken = 1)
    {
            var response = _employees.Skip((pageToken - 1)* pageSize).Take(pageSize).ToList();
            var sortedBySalary = response.OrderByDescending(e => e.Salary).ToList();
            
            return sortedBySalary;
    }

}