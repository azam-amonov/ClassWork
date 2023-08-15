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

    public void Login(string email, string password)
    {
        var verifiedUser = _users.FirstOrDefault(u => u.Email == email && u.Password == password);
        
        if (verifiedUser is not null && verifiedUser.IsEmailVerified)
        {
            Console.WriteLine("User verified!");
        }
        else
        {
            Console.WriteLine("User not verified!");
        }
    }
}