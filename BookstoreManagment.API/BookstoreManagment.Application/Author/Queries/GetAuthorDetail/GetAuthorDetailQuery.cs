using MediatR;

namespace BookstoreManagement.Application.Author.Queries.GetAuthorDetail;

public class GetAuthorDetailQuery : IRequest<AuthorDetailVm>
{
    public int AuthorId { get; set; }
    public int ContactDetailId { get; set; }
}