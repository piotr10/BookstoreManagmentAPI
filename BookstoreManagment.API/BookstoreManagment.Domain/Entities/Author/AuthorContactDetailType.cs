namespace BookstoreManagement.Domain.Entities.Author;

public class AuthorContactDetailType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int AuthorContactDetailId { get; set; }
    public AuthorContactDetail AuthorContactDetail { get; set; }
}