namespace Dars_33_C29_2.Class;

public class Order
{
    public int Id { get; set; }
    public int Amount { get; set; }
    public int CustomerId { get; set; }
    public DateTime OrderDate { get; set; }

    public Order(int id, int customerId, int amount, DateTime orderDate)
    {
        Id = id;
        Amount = amount;
        CustomerId = customerId;
        OrderDate = orderDate;
    }
}