using PracticBackend.Model;

namespace PracticBackend.Service;

public interface IUserService
{
    void Add(User user);
    User GetById(int id);
    List<User> GetAll();
    void Update(User user);
    void Delete(int id);
    
}