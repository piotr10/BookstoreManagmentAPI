using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookstoreManagement.Application.Common.Interfaces;
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
        var authors = await _bookstoreDbContext.Authors.AsNoTracking().ProjectTo<AuthorDto>(_mapper.ConfigurationProvider).ToListAsync();

        return new AuthorsVm() { Authors = authors};
    }
}