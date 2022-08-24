namespace BookstoreManagement.Application.Author.Queries.GetAuthors;

public class AuthorDto
{
    public DateTime AuthorDateOfBirth { get; set; } //AuthorBiography>DateOfBirth
    public string AuthorPlaceOfBirth { get; set; } //AuthorBiography>PlaceOfBirth
    public string AuthorFullName { get; set; } //Author>AuthorName
    public string HomeCountry { get; set; } //AuthorBiography>Country
    public string? Contact { get; set; } //AuthorContactDetail>Name
    public string? ContactDetailType { get; set; } //AuthorContactDetailType>Name
}