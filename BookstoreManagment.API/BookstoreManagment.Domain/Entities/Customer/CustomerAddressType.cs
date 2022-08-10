namespace BookstoreManagement.Domain.Entities.Customer;

public class CustomerAddressType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int CustomerAddressId { get; set; }
    public CustomerAddress CustomerAddress { get; set; }
}