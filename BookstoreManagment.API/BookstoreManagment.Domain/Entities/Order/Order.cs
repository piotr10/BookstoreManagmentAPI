using System.Text.Json.Serialization;
using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Order;

public class Order : AuditableEntity
{
    public DateTime DeliveryDate { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal OrderPrice { get; set; }
    public int Quantity { get; set; }
    public string Name { get; set; }
    public decimal BookPrice { get; set; }
    public int CustomerId { get; set; }
    [JsonIgnore]
    public Customer.Customer Customer { get; set; }

    public int BookId { get; set; }
    [JsonIgnore]
    public Book.Book Book { get; set; }

    public int OrderTransportTypeId { get; set; }
    [JsonIgnore]
    public OrderTransportType OrderTransportType { get; set; }
    public int PaymentMethodId { get; set; }
    [JsonIgnore]
    public PaymentMethod PaymentMethod { get; set; }
}