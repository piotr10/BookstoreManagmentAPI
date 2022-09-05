using MediatR;

namespace BookstoreManagement.Application.Book.Commands.DeleteBook;

public class DeleteBookCommand : IRequest
{
    public int BookId { get; set; }
}