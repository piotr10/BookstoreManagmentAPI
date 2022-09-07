using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Book.Commands.DeleteBook;

public class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;

    public DeleteBookCommandHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var book = await _bookstoreDbContext.Books
                .Where(x => x.Id == request.BookId && x.StatusId == 1)
                .FirstOrDefaultAsync(cancellationToken);
            if (book == null)
            {
                throw new ObjectNotExistInDbException(request.BookId, "Book");
            }
            _bookstoreDbContext.Books.Remove(book);

            try
            {
                await _bookstoreDbContext.SaveChangesAsync(cancellationToken);
            }
            catch (Exception e)
            {
                throw new DbUpdateException("Saving to database error!");
            }

            return Unit.Value;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}