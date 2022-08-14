using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Order;

public class Order : AuditableEntity
{
    public DateTime DeliveryDate { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal OrderPrice { get; set; }
    public int Quantity { get; set; }
    public int CustomerId { get; set; }
    public Customer.Customer Customer { get; set; }
    public ICollection<OrderTransportType> OrderTransportTypes { get; set; }
    public ICollection<PaymentMethod> PaymentMethods { get; set; }
}