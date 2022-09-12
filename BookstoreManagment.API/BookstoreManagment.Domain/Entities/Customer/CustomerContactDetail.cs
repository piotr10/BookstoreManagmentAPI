using System.Text.Json.Serialization;
using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Customer;

public class CustomerContactDetail : AuditableEntity
{
    public string ContactName { get; set; }
    public int CustomerId { get; set; }
    [JsonIgnore]
    public Customer Customer { get; set; }
    public int CustomerContactDetailTypeId { get; set; }
    [JsonIgnore]
    public CustomerContactDetailType CustomerContactDetailType { get; set; }
}