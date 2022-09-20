using AutoMapper;
using BookstoreManagement.Application.Author.Queries.GetAllAuthors;
using BookstoreManagement.Persistance;
using BookstoreManagement.UnitTests.Common;
using Shouldly;

namespace BookstoreManagement.UnitTests.Author.Queries.GetAuthors;

[Collection("QueryCollection")]
public class GetAuthorsQueryHandlerTests
{
    private readonly BookstoreDbContext _context;
    private readonly IMapper _mapper;

    public GetAuthorsQueryHandlerTests(QueryTestFixtures fixtures)
    {
        _context = fixtures.Context;
        _mapper = fixtures.Mapper;
    }

    [Fact]
    public async Task CanGetAuthors()
    {
        var handler = new GetAuthorsQueryHandler(_context, _mapper);
        var result = await handler.Handle(new GetAuthorsQuery(), CancellationToken.None);

        result.ShouldBeOfType<AuthorsVm>();
        result.Authors.Count.ShouldBe(3);
        result.Authors.ShouldNotBeNull();
    }
}