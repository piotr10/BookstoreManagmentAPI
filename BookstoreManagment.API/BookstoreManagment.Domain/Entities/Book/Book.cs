using System.Text.Json.Serialization;
using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Book;

public class Book : AuditableEntity
{
    public int AuthorId { get; set; }
    [JsonIgnore]
    public Author.Author Author { get; set; }
    public ICollection<Order.Order> Orders { get; set; }

    //BookDetail
    public string Name { get; set; }
    public DateTime PublishedBookDate { get; set; }
    public decimal Price { get; set; }
    public int GenreId { get; set; }
    [JsonIgnore]
    public Genre Genre { get; set; }
}