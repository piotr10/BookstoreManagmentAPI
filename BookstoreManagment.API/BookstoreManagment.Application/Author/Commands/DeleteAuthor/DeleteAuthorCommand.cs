using MediatR;

namespace BookstoreManagement.Application.Author.Commands.DeleteAuthor;

public class DeleteAuthorCommand : IRequest
{
    public int AuthorId { get; set; }
}