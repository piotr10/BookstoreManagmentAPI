namespace BookstoreManagement.Application.Author.Queries.GetAllAuthors;

public class AuthorsVm
{
    public ICollection<AuthorDto> Authors { get; set; }
}