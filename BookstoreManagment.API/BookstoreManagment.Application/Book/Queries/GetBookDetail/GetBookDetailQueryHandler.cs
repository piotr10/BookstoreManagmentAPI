using BookstoreManagement.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Book.Queries.GetBookDetail;

public class GetBookDetailQueryHandler : IRequestHandler<GetBookDetailQuery, BookDetailVm>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;

    public GetBookDetailQueryHandler(IBookstoreDbContext bookstoreDbContext)
    {
        _bookstoreDbContext = bookstoreDbContext;
    }

    public async Task<BookDetailVm> Handle(GetBookDetailQuery request, CancellationToken cancellationToken)
    {
        var book = await _bookstoreDbContext.Books.Where(p => p.Id == request.BookId)
            .FirstOrDefaultAsync(cancellationToken);

        var bookVm = new BookDetailVm()
        {

        };
        return bookVm;
    }
}