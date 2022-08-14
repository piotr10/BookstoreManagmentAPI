using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Author;

public class AuthorContactDetail : AuditableEntity
{
    public string Name { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    public ICollection<AuthorContactDetailType> AuthorContactDetailTypes { get; set; }
}