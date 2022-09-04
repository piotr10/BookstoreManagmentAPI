using System.ComponentModel.DataAnnotations.Schema;
using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Author;

public class AuthorContactDetailType
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<AuthorContactDetail> AuthorContactDetails { get; set; }
}