namespace Dars_37_C30.Practic;

public interface IEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime CreatedDateTime { get; set; }
    public DateTime UpdatedDateTime { get; set; }
}