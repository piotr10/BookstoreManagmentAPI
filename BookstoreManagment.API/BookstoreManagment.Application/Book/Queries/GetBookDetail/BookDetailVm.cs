namespace BookstoreManagement.Application.Book.Queries.GetBookDetail;

public class BookDetailVm
{
    public string BookName { get; set; } //BookDetail>Name
    public string PublishedBookDate { get; set; } //BookDetail>PublishedBookDate
    public decimal Price { get; set; } //BookDetail>Price
    public string Genre { get; set; } //Genre>Name
    public string AuthorFullName { get; set; } //Author>AuthorName
}