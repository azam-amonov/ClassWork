using TestBackend.Files;
using TestBackend.Models;

namespace TestBackend.Service;

public class UserService : IUserService
{
    private readonly IFileContext _fileContext; 
    
    public UserService(IFileContext fileContext)
    {
        _fileContext = fileContext;
    }
    public User CreateUser(User user)
    {
        return _fileContext.AddUser(user);
    }

    public bool DeleteUser(int id)
    {
    }
}