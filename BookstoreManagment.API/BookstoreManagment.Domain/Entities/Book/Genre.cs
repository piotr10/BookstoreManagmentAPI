using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Book;

public class Genre
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<BookDetail> BookDetails { get; set; }
}