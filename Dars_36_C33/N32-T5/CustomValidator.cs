using System.Text.RegularExpressions;

namespace Dars_36_C33.N32_T5;

public static class CustomValidator
{
    private static readonly string EmailValidator = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
    
    public static string? IsValidEmailAddress(string? emailAddress)
    {
        if (emailAddress!.Length < 5 )
            return "Minimum length is 5";
        
        if (!Regex.IsMatch(emailAddress,EmailValidator ))
            return "Email address is required.";

        return null;
    } 
}