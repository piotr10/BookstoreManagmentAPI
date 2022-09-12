using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Entities.Book;
using BookstoreManagement.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

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
        try
        {
            var authorId = await _bookstoreDbContext.Authors.FindAsync(request.AuthorId);
            if (authorId == null)
            {
                throw new ObjectNotExistInDbException(request.AuthorId, "Author");
            }

            Domain.Entities.Book.Book book = new Domain.Entities.Book.Book()
            {
                Author = authorId,
                Name = request.Name,
                PublishedBookDate = request.PublishedBookDate,
                Price = request.Price,
                GenreId = request.GenreId
            };
            await _bookstoreDbContext.Books.AddAsync(book, cancellationToken);

            try
            {
                await _bookstoreDbContext.SaveChangesAsync(cancellationToken);
            }
            catch (Exception e)
            {
                throw new DbUpdateException("Saving to database error!");
            }

            return book.Id;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}