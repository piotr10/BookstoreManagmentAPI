using MediatR;

namespace BookstoreManagement.Application.Order.Queries.GetAllBooks;

public class GetBookDetailsQuery : IRequest<BookDetailsVm>
{
    public int BookDetailId { get; set; }
}