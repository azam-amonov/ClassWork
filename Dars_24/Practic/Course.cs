namespace Dars_24.Practic;

public class Course
{
    public Guid CourseId { get; set; }
    public string Title { get; set; }

    public Course(Guid courseId, string title)
    {
        CourseId = courseId;
        Title = title;
    }
}