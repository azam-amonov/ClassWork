namespace Dars_17.Darsda.N17_T1;
/*
EmailTemplateService service dan foydalaning unda quyidagi data member lar bo'lsin

- Templates - email shablonlari kolleksiyasi, buning uchun EmailTemplates modeli ishlating ( subject, content )
unda quyidagi methodlar bo'lsin

- Add ( subject, content ) - email shablonini validate qilib, kolleksiyaga qo'shsin
- GetRegistrationTemplate ( string username ) - shablonlar orasidan ro'yxatdan o'tganlik shablonini olib, message ga aylantirib jo'natsin
- GetAccountBlockedTemplate ( string username ) - shablonlar orasidan akkount bloklanganlik shablonini olib, message ga aylantirib jo'natsin

- MessageConstants - static modelda quyidagi tokenlar konstanta holatida saqlansin
- UserToken - {{UserToken}}

- EmailTemplateService dan object yarating, 2 ta template qo'shing
- ro'yxatdan o'tganlik va akkount bloklanganlik shablonlarini kerakli methodlar orqali olib, ekranga chiqaring
*/
#region 
/*
Example

Subject : Account Registration
Content : Hurmatli {{User}}, ushbu xabar sizni muvafaqqiyatli ro'yxatdan o'tganligingizni bildirish uchun yuborildi

Subject : Account Blocked
Content :  Hurmatli {{User}}, ushbu xabar sizni akkountingiz bloklanganini bildirish uchun yuborildi
 */
#endregion

#region Logic
/*
 * Template -> List bo'ladi
 * Add -> methos bo'ladi u listga EmailTemplateModel qo'shdi
 * GetRegistrationTemplate -> methos bo'ladi u shablonlar orasidan userni topib unga message jo'naradi (consolga chiqaradi)
 * GetAccountBlockedTemplate -> methos bo'ladi u blocklanglik haqida xabar jo'natadi
 * 
*/


#endregion

public class EmailTemplateService
{
    private List<EmailTemplateModel> _templates { get; set; }

    public EmailTemplateService()
    {
        _templates = new List<EmailTemplateModel>();
    }

    public void Add(string subject, string content)
    {
        _templates.Add(new EmailTemplateModel { Subject = subject, Content = content });
    }

    public string GetRegisteredTemplate(string username)
    {
        foreach (var u in _templates)
        {
            if (u.Subject.Contains("Success"))
                return u.Content.Replace("{{User}}", username);
        }

        return "Failed to register";
    }

    public string GetBlockedTemplate(string username)
    {
        foreach (var u in _templates)
        {
            if (u.Subject.Contains("block"))
                return u.Content.Replace("{{User}}", username);
        }
        return "Not blocked";
    }


}