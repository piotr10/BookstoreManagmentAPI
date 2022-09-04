using System.Text.Json.Serialization;
using BookstoreManagement.Domain.Common;
using BookstoreManagement.Domain.ValueObjects;

namespace BookstoreManagement.Domain.Entities.Customer;

public class CustomerDetail : AuditableEntity
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string DetailContact { get; set; }
    public int CustomerId { get; set; }
    [JsonIgnore]
    public Customer Customer { get; set; }
    public Adres Adres { get; set; }
    public int CustomerDetailTypeId { get; set; }
    [JsonIgnore]
    public CustomerDetailType CustomerDetailType { get; set; }
    public int CustomerAddressTypeId { get; set; }
    [JsonIgnore]
    public CustomerAddressType CustomerAddressType { get; set; }
}