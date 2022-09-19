using AutoMapper;
using BookstoreManagement.Application.Book.Queries.GetBookDetail;
using BookstoreManagement.Persistance;
using BookstoreManagement.UnitTests.Common;
using Shouldly;

namespace BookstoreManagement.UnitTests.Book.Queries.GetBookDetail;

[Collection("QueryCollection")]
public class GetBookDetailQueryHandlerTests
{
    private readonly BookstoreDbContext _context;
    private readonly IMapper _mapper;

    public GetBookDetailQueryHandlerTests(QueryTestFixtures fixtures)
    {
        _context = fixtures.Context;
        _mapper = fixtures.Mapper;
    }

    [Fact]
    public async Task CanGetBookDetailById()
    {
        var handler = new GetBookQueryHandler(_context, _mapper);
        var bookId = 9;

        var result = await handler.Handle(new GetBookQuery() { BookId = bookId }, CancellationToken.None);

        result.ShouldBeOfType<BookVm>();
        result.AuthorFullName.ShouldBe("Person Test");
        result.BookName.ShouldBe("400 Bad Request");
        result.PublishedBookDate.ShouldBe(new DateTime(1900, 1, 1));
        result.Price.ShouldBe(222);
    }
}