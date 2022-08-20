using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Customer;

public class CustomerAddress : AuditableEntity
{
    public int ApartmentNumber { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public int HouseNumber { get; set; }
    public string Street { get; set; }
    public string ZipCode { get; set; }
    public int CustomerDetailId { get; set; }
    public CustomerDetail CustomerDetail { get; set; }
    public int CustomerAddressTypeId { get; set; }
    public CustomerAddressType CustomerAddressType { get; set; }
}