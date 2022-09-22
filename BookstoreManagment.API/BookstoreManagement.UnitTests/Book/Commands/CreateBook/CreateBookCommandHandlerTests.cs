using BookstoreManagement.Application.Book.Commands.CreateBook;
using BookstoreManagement.UnitTests.Common;
using Microsoft.EntityFrameworkCore;
using Shouldly;

namespace BookstoreManagement.UnitTests.Book.Commands.CreateBook;

public class CreateBookCommandHandlerTests : CommandTestBase
{
    private readonly CreateBookCommandHandler _handler;
    public CreateBookCommandHandlerTests() : base()
    {
        _handler = new CreateBookCommandHandler(_context);
    }

    [Fact]
    public async Task Handle_GivenValidRequest_ShouldInsertBook()
    {
        var command = new CreateBookCommand
        {
            BookId = 9,
            AuthorId = 3,
            Name = "About Bad Request",
            PublishedBookDate = new DateTime(1901, 1, 1),
            Price = 100,
            GenreId = 4
        };

        var result = await _handler.Handle(command, CancellationToken.None);

        var book = await _context.Books.FirstAsync(x => x.Id == result, CancellationToken.None);
        book.ShouldNotBeNull();
    }
}