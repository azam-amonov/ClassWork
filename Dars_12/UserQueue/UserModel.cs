namespace Dars_12.UserQueue;

public class UserModel
{
    public string FirstName;
    public string MiddleName;
    public string LastName;
    
    public override bool Equals(object obj)
    {
        if (obj is UserModel user)
        {
            return obj.GetHashCode() == user.FirstName.GetHashCode() ? true : false;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return this.FirstName.GetHashCode() + this.MiddleName.GetHashCode() + this.LastName.GetHashCode();
    }
}