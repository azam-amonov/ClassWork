namespace TestBackend.Models;

public class User
{
    public int Id { get; set; }
    public string FullName { get;  set; }
    public string Email { get; set; }

    public User(int id, string fullName, string email)
    {
        Id = id;
        FullName = fullName;
        Email = email;
    }
}