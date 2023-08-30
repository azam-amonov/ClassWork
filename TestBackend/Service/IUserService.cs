using TestBackend.Models;

namespace TestBackend.Service;

public interface IUserService
{
    public User CreateUser(User user);
}