﻿using BookstoreManagement.Domain.Common;

namespace BookstoreManagement.Domain.Entities.Book;

public class Book : AuditableEntity
{
    public int AuthorId { get; set; }
    public Author.Author Author { get; set; }
    public ICollection<BookDetail> BookDetails { get; set; }
    public ICollection<Order.Order> Orders { get; set; }
}