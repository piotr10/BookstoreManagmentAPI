using MediatR;

namespace BookstoreManagement.Application.Book.Queries.GetBookDetail;

public class GetBookQuery : IRequest<BookVm>
{
    public int BookId { get; set; }
}