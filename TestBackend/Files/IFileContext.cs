using TestBackend.Models;

namespace TestBackend.Files;

public interface IFileContext
{
    User AddUser(User user);
}