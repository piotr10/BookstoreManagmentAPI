namespace BookstoreManagement.Domain.Entities.Customer;

public class CustomerDetailType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CustomerDetailId { get; set; }
    public CustomerDetail CustomerDetail { get; set; }
}