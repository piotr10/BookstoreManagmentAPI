using MediatR;

namespace BookstoreManagement.Application.Book.Queries.GetBookDetail;

public class GetBookDetailQuery : IRequest<BookDetailVm>
{
    public int BookId { get; set; }
}