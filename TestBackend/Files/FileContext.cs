using System.Text.Json;
using TestBackend.Models;

namespace TestBackend.Files;

public class FileContext: IFileContext
{
    private const string _filePath = @"/Users/azamamonov/RiderProjects/ClassWork/TestBackend/DataFolder/data.txt";
    private List<User> _users = new List<User>();
    
    public User AddUser(User user)
    {
        _users.Add(user);
        var json = JsonSerializer.Serialize(_users);
        File.WriteAllText(_filePath, json);
        return user;
    }
    
    public void DeleteUser(int id)
}