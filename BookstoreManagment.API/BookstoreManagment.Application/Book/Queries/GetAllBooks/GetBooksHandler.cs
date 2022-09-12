using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookstoreManagement.Application.Book.Queries.GetAllBooks;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Book.Queries.GetAllBooks;

public class GetBooksHandler : IRequestHandler<GetBooksQuery, BooksVm>
{
    private readonly IBookstoreDbContext _context;
    private IMapper _mapper;
    public GetBooksHandler(IBookstoreDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<BooksVm> Handle(GetBooksQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var books = await _context.Books.Where(x => x.StatusId == 1).AsNoTracking().ProjectTo<BooksDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            if (books == null)
            {
                throw new ThisObjectNotExistInDbException("Books");
            }

            return new BooksVm() { Books = books };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}