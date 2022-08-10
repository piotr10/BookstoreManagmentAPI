namespace BookstoreManagement.Domain.Entities.Order;

public class PaymentMethod
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int OrderId { get; set; }
    public Order Order { get; set; }
}