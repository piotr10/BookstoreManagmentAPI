using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Book.Queries.GetBookDetail;

public class GetBookDetailQueryHandler : IRequestHandler<GetBookDetailQuery, BookDetailVm>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;

    public GetBookDetailQueryHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
    }

    public async Task<BookDetailVm> Handle(GetBookDetailQuery request, CancellationToken cancellationToken)
    {
        /*
        var book = await _bookstoreDbContext.Books
            .Include(p => p.BookDetails)
            .ThenInclude(p => p.Genre)
            .Include(p=>p.Author)
            .Where(p => p.Id == request.BookDetailId)
            .FirstOrDefaultAsync(cancellationToken);
        */

        var bookDetail = await _bookstoreDbContext.BookDetails
            .Include(p=>p.Book)
            .ThenInclude(p=>p.Author)
            .Include(p=>p.Genre)
            .Where(p => p.Id == request.BookDetailId)
            .FirstOrDefaultAsync(cancellationToken);

        var bookVm = _mapper.Map<BookDetailVm>(bookDetail);
        return bookVm;
    }
}