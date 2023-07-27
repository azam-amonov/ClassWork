namespace Dars_13.N13_T3;

// 1.
// - bank akkounti uchun BankAccount modelidan foydalaning
// - BankAccount modelida - firstname, lastname, deposit 
// - depozit ni boshlang'ich qiymati -20 bo'lsin
// - BankAccount dan object yaratishni 2 ta yo'li bo'lsin 
// - faqat firstname va lastname bilan
// - firstname va lastname va depozit bilan - bunda depozit 0 dan katta ekanligi tekshirilsin
// - BankAccountdan 2 xil usulda object yaratib, ekranga chiqaring

public class BankAccount
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public decimal Deposit { get; set; } = -20;

    public BankAccount(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public BankAccount(string firstName, string lastName, decimal deposit)
        : this(firstName, lastName)
    {
        Deposit = deposit;
    }
}