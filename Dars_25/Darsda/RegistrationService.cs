namespace Dars_25.Darsda;

public class RegistrationService
{
    public List<User> _users;

    public RegistrationService()
    {
        _users = new List<User>();
    }

    public void Register(string email, string password)
    {
        var newUser = new User(email, password);
        var isExitsEmail =  _users.Any(u => u.Email == newUser.Email);
       
       if (!isExitsEmail)
       {
           _users.Add(newUser);
           Console.WriteLine("User added successfully!");
       }
       else
       {
           Console.WriteLine("This user is already registered!");
       }
    }
}