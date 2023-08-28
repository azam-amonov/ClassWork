using System.ComponentModel.DataAnnotations;

namespace Dars_36_C33.N32_T6;

public class BlogService: IBlogService
{
    private List<Blog> _blogList;

    public BlogService()
    {
        _blogList = new List<Blog>();
    }
    
    public void Create(Blog blog)
    {
        if(ValidateOnCreate(blog))
            _blogList.Add(blog);

        throw new ValidationException("Blog content cannot be required!");
    }

    public Blog Get(Guid id)
    {
        var searchedBlog = _blogList.FirstOrDefault(b => b.Id == id);
        if (searchedBlog is null)
            throw new ArgumentOutOfRangeException();
        
        return searchedBlog;
    }

    public Blog Update(Blog blog)
    {
        var existingBlog = _blogList.Find(b => b.Id == blog.Id);

        if (!ValidateOnUpdate(blog) || existingBlog is null)
            throw new ValidationException("Blog content cannot be required!");
        
        existingBlog.Title = blog.Title;
        existingBlog.Body = blog.Body;
        
        return existingBlog;
    }

    public bool Delete(Guid id)
    {
        var blogToDelete = _blogList.FirstOrDefault(b => b.Id == id);
        
        if(blogToDelete is not null)
            _blogList.Remove(blogToDelete);
        
        throw new ArgumentOutOfRangeException();
    }

    private static bool ValidateOnCreate(Blog blog)
    {
        if(string.IsNullOrWhiteSpace(blog.Title) || string.IsNullOrWhiteSpace(blog.Body))
            return false;
        
        return true;
    }

    private static bool ValidateOnUpdate(Blog blog)
    {
        if(string.IsNullOrWhiteSpace(blog.Title) || string.IsNullOrWhiteSpace(blog.Body))
            return false;
        
        return true;
    }
}