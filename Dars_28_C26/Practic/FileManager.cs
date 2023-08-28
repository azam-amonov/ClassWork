using Newtonsoft.Json;

namespace Dars_28_C26.Practic;

public class FileManager
{
    
    const string _dataTaskPath = "/Users/azamamonov/RiderProjects/ClassWork/Dars_28_C26/Practic/Tasks.txt";

    public void FileManagerMethode()
    {
        var taskService = new MiniTaskService();

        taskService.AddTask("Do something", Priority.High, DateTime.Now);
        taskService.AddTask("Do something", Priority.Low, DateTime.Now.AddDays(3));
        taskService.AddTask("Do something", Priority.Medium, DateTime.Now.AddDays(3));
        taskService.AddTask("Sleep", Priority.High, DateTime.Now.AddHours(8));

// taskService.DisplayAllTasks();
        var allTasks = taskService.GetTasksList();
        var json = JsonConvert.SerializeObject(allTasks, Formatting.Indented);
        File.WriteAllText(_dataTaskPath, json);

// var source = File.ReadAllText(_dataTaskPath);
// Console.WriteLine(source);
// var tasksFromFile = JsonConvert.DeserializeObject<List<MiniTask>>(source);
// tasksFromFile?.ForEach(Console.WriteLine);
    }
}