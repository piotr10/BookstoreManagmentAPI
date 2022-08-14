﻿using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Author;

public class AuthorBiography : AuditableEntity
{
    public string Country { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string PlaceOfBirth { get; set; }
    public int AuthorId { get; set; }
    public Author Author { get; set; }
}