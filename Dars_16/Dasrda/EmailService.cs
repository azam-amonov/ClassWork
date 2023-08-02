using System.Net;
using System.Net.Mail;

namespace Dars_16.Dasrda;

public class EmailService
{
    private string CredentialAddress { get; init; }
    private string CredentialPassword { get; init; }

    public EmailService(string email, string password)
    {
        CredentialAddress = email;
        CredentialPassword = password;
    }
    public void SendEmail(string receiverEmail, string user)
    {
        var mail = new MailMessage(CredentialAddress, receiverEmail);
        mail.Subject = "";
        mail.Body = $" {user},  ";

        var smtpClient = new SmtpClient("smtp.gmail.com", 587); // Replace with your SMTP server address and port
        smtpClient.Credentials = new NetworkCredential(CredentialAddress, CredentialPassword);
        smtpClient.EnableSsl = true;

        smtpClient.Send(mail);
    }
}