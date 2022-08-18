using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Customer;

public class Customer : AuditableEntity
{
    public ICollection<CustomerDetail> CustomerDetails { get; set; }
    public ICollection<Order.Order> Orders { get; set; }
}