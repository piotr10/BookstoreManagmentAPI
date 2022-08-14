using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Author;

public class AuthorContactDetailType : AuditableEntity
{
    public string Name { get; set; }
    public int AuthorContactDetailId { get; set; }
    public AuthorContactDetail AuthorContactDetail { get; set; }
}