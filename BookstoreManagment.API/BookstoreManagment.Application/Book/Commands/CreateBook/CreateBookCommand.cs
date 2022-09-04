using MediatR;

namespace BookstoreManagement.Application.Book.Commands.CreateBook;

public class CreateBookCommand : IRequest<int>
{
    //Book
    public int BookId { get; set; }
    public int AuthorId { get; set; }
    //BookDetail
    public string Name { get; set; }
    public DateTime PublishedBookDate { get; set; }
    public decimal Price { get; set; }
    //Genre
    public int GenreId { get; set; }
}