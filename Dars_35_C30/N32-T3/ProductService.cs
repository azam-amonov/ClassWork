namespace Dars_35_C30.N32_T3;

public class ProductService
{
    private List<Product> _products;

    public ProductService()
    {
        _products = new List<Product>
        {
            new Product(1, "Apple", ""),
            new Product(2, "Apple", "Fresh"),
            new Product(3, "WaterMelon", "Fresh"),
            new Product(4, "Laptop", ""),
            new Product(5, "", "Fresh"),
        };
    }

    public void Add(int id, string name, string description)
    {
        _products.Add(new Product(id, name, description));
    }
}