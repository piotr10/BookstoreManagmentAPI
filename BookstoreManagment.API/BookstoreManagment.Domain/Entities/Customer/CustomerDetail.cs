namespace BookstoreManagement.Domain.Entities.Customer;

public class CustomerDetail
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public ICollection<CustomerAddress> CustomerAddresses { get; set; }
    public ICollection<CustomerDetailType> CustomerDetailTypes { get; set; }
}