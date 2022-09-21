using BookstoreManagement.Application.Author.Queries.GetAllAuthors;

namespace BookstoreManagement.Client.Models;

public class ListAuthors
{
    public ICollection<AuthorDto> Authors { get; set; }
}