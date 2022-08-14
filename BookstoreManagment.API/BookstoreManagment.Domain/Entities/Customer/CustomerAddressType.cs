using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Customer;

public class CustomerAddressType : AuditableEntity
{
    public string Name { get; set; }
    public int CustomerAddressId { get; set; }
    public CustomerAddress CustomerAddress { get; set; }
}