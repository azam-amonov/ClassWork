namespace ClassWork_22.Practic_TaskManager;

public class Task
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsCompleted { get; set; }
    public List<string> Comments { get; set; } 
}