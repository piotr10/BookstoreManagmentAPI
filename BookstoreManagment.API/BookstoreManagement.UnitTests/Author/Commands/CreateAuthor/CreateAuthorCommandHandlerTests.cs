using BookstoreManagement.Application.Author.Commands.CreateAuthor;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Common;
using BookstoreManagement.UnitTests.Common;
using Microsoft.EntityFrameworkCore;
using Shouldly;

namespace BookstoreManagement.UnitTests.Author.Commands.CreateAuthor;

public class CreateAuthorCommandHandlerTests : CommandTestBase
{
    
    private readonly CreateAuthorCommandHandler _handler;

    public CreateAuthorCommandHandlerTests() : base()
    {
        _handler = new CreateAuthorCommandHandler(_context);
    }

    [Fact]
    public async Task Handle_GivenValidRequest_ShouldInsertAuthor()
    {
        var command = new CreateAuthorCommand()
        {
            FirstName = "Fake",
            LastName = "Name",
            AuthorDateOfBirth = new DateTime(1999, 1, 1),
            AuthorPlaceOfBirth = "Warsaw",
            Country = "Poland",
            Contact = "111 111 111",
            AuthorContactDetailTypeId = 4,
            AuthorId = 3
        };

        var result = await _handler.Handle(command, CancellationToken.None);

        var author = await _context.Authors.FirstAsync(x => x.Id == result, CancellationToken.None);
        author.ShouldNotBeNull();
    }
}