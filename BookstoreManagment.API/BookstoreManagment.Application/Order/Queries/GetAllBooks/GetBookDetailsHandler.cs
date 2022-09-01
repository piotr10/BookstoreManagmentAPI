using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookstoreManagement.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Order.Queries.GetAllBooks;

public class GetBookDetailsHandler : IRequestHandler<GetBookDetailsQuery, BookDetailsVm>
{
    private readonly IBookstoreDbContext _context;
    private IMapper _mapper;
    public GetBookDetailsHandler(IBookstoreDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<BookDetailsVm> Handle(GetBookDetailsQuery request, CancellationToken cancellationToken)
    {
        var books = await _context.BookDetails.AsNoTracking().ProjectTo<BookDetailDto>(_mapper.ConfigurationProvider).ToListAsync();

        return new BookDetailsVm() { BookDetails = books};
    }
}