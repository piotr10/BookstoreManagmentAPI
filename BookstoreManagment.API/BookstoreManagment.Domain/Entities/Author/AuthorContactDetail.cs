namespace BookstoreManagement.Domain.Entities.Author;

public class AuthorContactDetail
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    public ICollection<AuthorContactDetailType> AuthorContactDetailTypes { get; set; }
}