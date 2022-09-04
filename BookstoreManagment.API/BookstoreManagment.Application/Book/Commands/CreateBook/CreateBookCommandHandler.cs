﻿using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Entities.Book;
using MediatR;

namespace BookstoreManagement.Application.Book.Commands.CreateBook;

public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, int>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;

    public CreateBookCommandHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
        var authorId = await _bookstoreDbContext.Authors.FindAsync(request.AuthorId);
        Domain.Entities.Book.Book book = new Domain.Entities.Book.Book()
        {
            Author = authorId
        };

        _bookstoreDbContext.Books.Add(book);
        await _bookstoreDbContext.SaveChangesAsync(cancellationToken);

        var bookId = await _bookstoreDbContext.Books.FindAsync(request.BookId);

        BookDetail bookDetail = new BookDetail()
        {
            Name = request.Name,
            PublishedBookDate =request.PublishedBookDate,
            Price = request.Price,
            GenreId = request.GenreId,
            Book = bookId
        };

        _bookstoreDbContext.BookDetails.Add(bookDetail);
        await _bookstoreDbContext.SaveChangesAsync(cancellationToken);

        return book.Id;
    }
}