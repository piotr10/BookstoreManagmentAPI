using AutoMapper;
using BookstoreManagement.Application.Book.Queries.GetAllBooks;
using BookstoreManagement.Persistance;
using BookstoreManagement.UnitTests.Common;
using Shouldly;

namespace BookstoreManagement.UnitTests.Book.Queries.GetBooks;

[Collection("QueryCollection")]
public class GetBooksQueryHandlerTests
{
    private readonly BookstoreDbContext _context;
    private readonly IMapper _mapper;

    public GetBooksQueryHandlerTests(QueryTestFixtures fixtures)
    {
        _context = fixtures.Context;
        _mapper = fixtures.Mapper;
    }

    [Fact]
    public async Task CanGetBooks()
    {
        var handler = new GetBooksHandler(_context, _mapper);
        var result = await handler.Handle(new GetBooksQuery(), CancellationToken.None);

        result.ShouldBeOfType<BooksVm>();
        result.Books.Count.ShouldBe(9);
    }
}