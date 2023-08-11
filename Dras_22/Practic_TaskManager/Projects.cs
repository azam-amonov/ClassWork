namespace ClassWork_22.Practic_TaskManager;

public class Projects
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public List<Task> Tasks { get; set; }
    
    public void Add(Task task){}
}