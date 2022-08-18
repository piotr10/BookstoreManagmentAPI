using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Customer;

public class CustomerDetailType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<CustomerDetail> CustomerDetails { get; set; }
}