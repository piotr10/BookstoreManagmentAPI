using System.Text.Json.Serialization;
using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Book;

public class BookDetail : AuditableEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime PublishedBookDate { get; set; }
    public decimal Price { get; set; }
    public int BookId { get; set; }
    [JsonIgnore]
    public Book Book { get; set; }
    public int GenreId { get; set; }
    [JsonIgnore]
    public Genre Genre { get; set; }

}