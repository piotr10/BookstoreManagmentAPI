using System.Text.Json.Serialization;
using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Author;

public class AuthorContactDetail : AuditableEntity
{
    public string Name { get; set; }
    public int AuthorId { get; set; }
    [JsonIgnore]
    public Author Author { get; set; }
    public int AuthorContactDetailTypeId { get; set; }
    [JsonIgnore]
    public AuthorContactDetailType AuthorContactDetailType { get; set; }
}