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

    public int BookId { get; set; }
    public Book.Book Book { get; set; }

    public int OrderTransportTypeId { get; set; }
    public OrderTransportType OrderTransportType { get; set; }
    public int PaymentMethodId { get; set; }
    public PaymentMethod PaymentMethod { get; set; }
}