namespace BookstoreManagement.Domain.Entities.Book;

public class BookDetail
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime PublishedBookDate { get; set; }
    public decimal Price { get; set; }
    public int BookId { get; set; }
    public Book Book { get; set; }
    public int GenreId { get; set; }
    public Genre Genre { get; set; }

}