using BookstoreManagement.Domain.ValueObjects;

namespace BookstoreManagement.Domain.Entities.Author;

public class Author
{
    public int Id { get; set; }
    public PersonName AuthorName { get; set; }
    public AuthorBiography AuthorBiography { get; set; }
    public ICollection<AuthorContactDetail> AuthorContactDetails { get; set; }
    public ICollection<Book.Book> Books { get; set; }
}