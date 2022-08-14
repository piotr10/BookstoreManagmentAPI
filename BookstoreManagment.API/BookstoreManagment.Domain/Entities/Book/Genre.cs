using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Book;

public class Genre : AuditableEntity
{
    public string Name { get; set; }
    public ICollection<Book> Books { get; set; }
}