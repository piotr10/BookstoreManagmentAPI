using System.ComponentModel.DataAnnotations;

namespace BookstoreManagement.Client.Models;

public class AuthorsForm
{
    [Required]
    public string? FirstName { get; set; }
    [Required]
    public string? LastName { get; set; }
    [Required]
    public DateTime AuthorDateOfBirth { get; set; }
    [Required]
    public string? AuthorPlaceOfBirth { get; set; }
    [Required]
    public string? Country { get; set; }
    [Required]
    public string? Contact { get; set; }
}