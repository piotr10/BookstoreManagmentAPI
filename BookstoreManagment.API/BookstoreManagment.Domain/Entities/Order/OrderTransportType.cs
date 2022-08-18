using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Order;

public class OrderTransportType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<Order> Orders { get; set; }
}