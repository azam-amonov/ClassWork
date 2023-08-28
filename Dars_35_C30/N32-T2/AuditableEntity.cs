namespace Dars_35_C30.N32_T2;

public abstract class AuditableEntity
{
    public DateTime CreateDateTime{ get; set; }
    public DateTime ModifyDateTime{ get; set; }

    protected AuditableEntity(DateTime createDateTime, DateTime modifyDateTime)
    {
        CreateDateTime = createDateTime;
        ModifyDateTime = modifyDateTime;
    }
}