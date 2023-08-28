namespace Dars_36_C33.N32_T6;

public interface IBlogService
{
    public void Create (Blog blog);
    public Blog Get (Guid id);
    public Blog Update(Blog blog);
    public bool Delete (Guid id);
}