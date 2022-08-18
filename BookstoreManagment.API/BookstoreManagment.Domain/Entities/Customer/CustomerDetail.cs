using BookstoreManagement.Domain.Common;
using BookstoreManagement.Domain.ValueObjects;

namespace BookstoreManagement.Domain.Entities.Customer;

public class CustomerDetail : AuditableEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public ICollection<CustomerAddress> CustomerAddresses { get; set; }
    public int CustomerDetailTypeId { get; set; }
    public CustomerDetailType CustomerDetailType { get; set; }
}