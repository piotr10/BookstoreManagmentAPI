using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
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
        var book = await _bookstoreDbContext.Books
            .Where(x => x.Id == request.BookId && x.StatusId == 1)
            .FirstOrDefaultAsync(cancellationToken);

        _bookstoreDbContext.Books.Remove(book);
        await _bookstoreDbContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}