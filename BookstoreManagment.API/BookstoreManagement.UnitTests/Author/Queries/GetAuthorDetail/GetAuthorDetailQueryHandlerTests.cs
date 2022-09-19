using AutoMapper;
using BookstoreManagement.Application.Author.Queries.GetAuthorDetail;
using BookstoreManagement.Persistance;
using BookstoreManagement.UnitTests.Common;
using Shouldly;

namespace BookstoreManagement.UnitTests.Author.Queries.GetAuthorDetail;

[Collection("QueryCollection")]
public class GetAuthorDetailQueryHandlerTests
{
    private readonly BookstoreDbContext _context;
    private readonly IMapper _mapper;

    public GetAuthorDetailQueryHandlerTests(QueryTestFixtures fixtures)
    {
        _context = fixtures.Context;
        _mapper = fixtures.Mapper;
    }

    [Fact]
    public async Task CanGetAuthorDetailById()
    {
        var handler = new GetAuthorDetailQueryHandler(_context, _mapper);
        var authorId = 3;

        var result = await handler.Handle(new GetAuthorDetailQuery() {AuthorId = authorId}, CancellationToken.None);

        result.ShouldBeOfType<AuthorDetailVm>();
        result.AuthorFullName.ShouldBe("Person Test");
    }
}