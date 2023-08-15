namespace Dars_25.Darsda;

public class User
{
    public string Email { get; set; }
    public string Password { get; set; }
    public bool IsEmailVerified { get; set; }
    public bool IsPhoneNumberVerified { get; set; }
    

    public User(string email, string password, bool isEmailVerified = false, bool isPhoneNumberVerified = false)
    {
        Email = email;
        Password = password;
        IsEmailVerified = isEmailVerified;
        IsPhoneNumberVerified = isPhoneNumberVerified;
    }
    
}