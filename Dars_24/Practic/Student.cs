namespace Dars_24.Practic;

public class Student<T, T2>
{
    public T Id { get; set; }
    public T2 Name { get; set; }
    public T2 Grade { get; set; }

    public Student(T studentId, T2 studentName, T2 studentGrade)
    {
        Id = studentId;
        Name = studentName;
        Grade = studentGrade;
    }

    public override string ToString() =>
                    $"{Name} " +
                    $"{Grade}\n";
}