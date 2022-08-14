using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Customer;

public class CustomerDetailType : AuditableEntity
{
    public string Name { get; set; }
    public int CustomerDetailId { get; set; }
    public CustomerDetail CustomerDetail { get; set; }
}