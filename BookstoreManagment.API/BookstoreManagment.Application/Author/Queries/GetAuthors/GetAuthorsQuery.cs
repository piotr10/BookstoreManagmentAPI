using MediatR;

namespace BookstoreManagement.Application.Author.Queries.GetAuthors;

public class GetAuthorsQuery : IRequest<AuthorsVm>
{
    public int AuthorsId { get; set; }
    public int ContactDetailsId { get; set; }

}