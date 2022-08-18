using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Customer;

public class CustomerAddressType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<CustomerAddress> CustomerAddresses { get; set; }
}