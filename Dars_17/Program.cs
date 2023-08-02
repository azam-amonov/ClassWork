// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices.ComTypes;
using Dars_17.Darsda.N17_T1;

Console.WriteLine(">>>>>");
EmailTemplateService emailTemplateService = new EmailTemplateService();
emailTemplateService.Add("Success Registration","Humratli {{User}} siz muvofiqqiyatli ro'yxatdan o'tdingiz! ");
emailTemplateService.Add("Blocked","Hurman {{User}} sizning accountiongiz blocklandi");

var s = emailTemplateService.GetRegisteredTemplate("Hoshim");
var b = emailTemplateService.GetBlockedTemplate("Haydar");

Console.WriteLine(s);
Console.WriteLine(b);