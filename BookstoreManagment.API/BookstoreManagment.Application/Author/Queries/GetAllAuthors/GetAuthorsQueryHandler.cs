using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Author.Queries.GetAllAuthors;

public class GetAuthorsQueryHandler : IRequestHandler<GetAuthorsQuery, AuthorsVm>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;

    public GetAuthorsQueryHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
    }
    public async Task<AuthorsVm> Handle(GetAuthorsQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var authors = await _bookstoreDbContext.Authors.Where(x => x.StatusId == 1).AsNoTracking().ProjectTo<AuthorDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            if (authors == null)
            {
                throw new ThisObjectNotExistInDbException("Authors");
            }

            return new AuthorsVm() { Authors = authors };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}