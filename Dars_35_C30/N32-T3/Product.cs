namespace Dars_35_C30.N32_T3;

public class Product
{
    private readonly string _name;
    private readonly string _description;
    
    public int Id { get; init; }
    public string Name
    {
        get => string.IsNullOrWhiteSpace(_name) ? _name : "Not validated Name";
        private set
        {
        }
    }

    public string Description
    {
        get => string.IsNullOrWhiteSpace(_description) ? _description : "Not validated Description";
        private set
        {
            
        }
    }

    public Product(int id, string name, string description)
    {
        Id = id;
        _name = name;
        _description = description;
    }

    public Product (Product product)
    {
        this.Id = product.Id;
        this.Name = product.Name;
        this.Description = product.Description;
    }
    
}