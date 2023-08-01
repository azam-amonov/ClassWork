// See https://aka.ms/new-console-template for more information

using Dars_16.Dasrda;

// var senderEmail = "sultonbek.rakhimov.recovery@gmail.com";
// var senderPassword = "szabguksrhwsbtie";
//
// EmailService emailService = new EmailService(senderEmail, senderPassword);
// emailService.SendEmail("eiscocyber@gmail.com", "Iskandar Qodirov sizni yil mazgisi b'lganingiz bilan tabriklamymiz");


TemperatureSensorService sensorService = new TemperatureSensorService(23);
sensorService.Display();