namespace Dars_28_C26.Practic;

public class MiniTask
{
    public int Id { get; set; }
    public string Description { get; set; }
    public Priority Priority {get; set; }
    public DateTime Deadline { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime CreatedTime { get; set; }

    public MiniTask()
    {
    }
    public MiniTask(string description, Priority priority, DateTime deadline, bool isCompleted = false)
    {
        Id = Id;
        Description = description;
        Priority = priority;
        Deadline = deadline;
        IsCompleted = isCompleted;
        CreatedTime = DateTime.Now;
    }
    

    public override string ToString()
    {
        return $"{Id}\n" +
               $"{Description}\n" +
               $"{Priority}\n" +
               $"{CreatedTime}\n" +
               $"{Deadline}\n" +
               $"{IsCompleted}\n";
    }
}