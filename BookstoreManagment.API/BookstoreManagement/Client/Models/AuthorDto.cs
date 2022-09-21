namespace BookstoreManagement.Client.Models;

public class AuthorDto
{
    public int AuthorDetailId { get; set; }
    public string? AuthorFullName { get; set; }
    public DateTime AuthorDateOfBirth { get; set; }
    public string? AuthorPlaceOfBirth { get; set; }
    public string? HomeCountry { get; set; }
    public string? Contact { get; set; }
    public string? AuthorContactType { get; set; }
}