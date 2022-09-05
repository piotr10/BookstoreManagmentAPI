namespace BookstoreManagement.Domain.Entities.Customer;

public class CustomerContactDetailType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<CustomerContactDetail> CustomerContactDetails { get; set; }
}