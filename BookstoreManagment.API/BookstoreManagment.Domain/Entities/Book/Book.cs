namespace BookstoreManagement.Domain.Entities.Book;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime PublishedBookDate { get; set; }
    public decimal Price { get; set; }
    public ICollection<Genre> Genres { get; set; }
    public int AuthorId { get; set; }
    public Author.Author Author { get; set; }
    public int CustomerId { get; set; }
    public Customer.Customer Customer { get; set; }
}