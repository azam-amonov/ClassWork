namespace Dars_35_C30.N32_T2;

public class ChatMessage: AuditableEntity
{
    public int Id { get; set; }
    public int ChatId { get; set; }
    public string Subject { get; set;}
    public string Message { get; set;}

    public ChatMessage(int id, int chatId, DateTime createDateTime, DateTime modifyDateTime, string subject, string message) 
                    : base(createDateTime, modifyDateTime)
    {
        Id = id;
        ChatId = chatId;
        Subject = subject;
        Message = message;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode() + ChatId.GetHashCode() + Subject.GetHashCode() + Message.GetHashCode();
    }

    public override bool Equals(object obj)
    {
        return this.GetHashCode() == obj.GetHashCode();
    }
}