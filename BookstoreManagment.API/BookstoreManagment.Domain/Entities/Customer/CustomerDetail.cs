using BookstoreManagement.Domain.Common;
using BookstoreManagement.Domain.ValueObjects;

namespace BookstoreManagement.Domain.Entities.Customer;

public class CustomerDetail : AuditableEntity
{
    public PersonName CustomerName { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public ICollection<CustomerAddress> CustomerAddresses { get; set; }
    public ICollection<CustomerDetailType> CustomerDetailTypes { get; set; }
}