namespace Dars_24.Practic;

public class University<TStudent, T, T2> where TStudent: Student<T, T2>
{   
    private List<TStudent> _students = new();
    private List<Course> _courses = new();

    public void EnrollStudent(TStudent student, Course course)
    {
        _students.Add(student);
        _courses.Add(course);
    }

    public void DisplayStudents()
    {
        _students.ForEach(Console.WriteLine);
    }
}