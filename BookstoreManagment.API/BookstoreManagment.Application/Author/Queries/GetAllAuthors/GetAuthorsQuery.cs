using MediatR;

namespace BookstoreManagement.Application.Author.Queries.GetAllAuthors;

public class GetAuthorsQuery : IRequest<AuthorsVm>
{
}