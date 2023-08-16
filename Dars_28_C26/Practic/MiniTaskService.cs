namespace Dars_28_C26.Practic;

public class MiniTaskService
{
    private List<MiniTask> _miniTasks;

    public MiniTaskService()
    {
        _miniTasks = new List<MiniTask>();
    }

    public void AddTask(string description, Priority priority, DateTime deadline)
    {
        _miniTasks.Add(new MiniTask {
                Id  = GenerateId(),
                Description = description,
                Priority = priority,
                Deadline = deadline,
                CreatedTime = DateTime.Now,
                IsCompleted = false,
                
        });
    }

    public void CompleteTask(int taskId)
    {
        _miniTasks.FirstOrDefault(t => t.Id == taskId)!.IsCompleted = true;
    }

    public List<MiniTask> GetTasks(Priority priority)
    {
        var tasksByPriority = _miniTasks.Where(t => t.Priority == priority).ToList();
        return tasksByPriority;
    }

    public void DisplayAllTasks()
    {
        _miniTasks.ForEach(Console.WriteLine);
    }

    public List<MiniTask> GetTasksList()
    {
        return _miniTasks;
    }
    private int GenerateId()
    {
        if (_miniTasks.Count == 0)
            return 1;
        
        var nextId =  _miniTasks.Last().Id;
        return nextId + 1;
    }
}