using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Author.Commands.DeleteAuthor;

public class DeleteAuthorCommandHandler : IRequestHandler<DeleteAuthorCommand>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;

    public DeleteAuthorCommandHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
    {
        try
        {
            //Remove author all books
            var book = await _bookstoreDbContext.Books
                .Where(x => x.AuthorId == request.AuthorId && x.StatusId == 1)
                .ToListAsync(cancellationToken);
            if (book == null)
            {
                throw new ObjectNotExistInDbException(request.AuthorId, "Book");
            }

            foreach (var detail in book)
            {
                _bookstoreDbContext.Books.Remove(detail);
            }

            //Remove author
            var author = await _bookstoreDbContext.Authors
                .Where(x => x.Id == request.AuthorId && x.StatusId == 1)
                .FirstOrDefaultAsync(cancellationToken);
            if (author == null)
            {
                throw new ObjectNotExistInDbException(request.AuthorId, "Author");
            }
            _bookstoreDbContext.Authors.Remove(author);

            //Remove author details
            var authorDetail = await _bookstoreDbContext.AuthorContactDetails
                .Where(x => x.AuthorId == request.AuthorId && x.StatusId == 1)
                .ToListAsync(cancellationToken);
            if (authorDetail == null)
            {
                throw new ObjectNotExistInDbException(request.AuthorId, "Author Detail");
            }

            foreach (var authorContactDetail in authorDetail)
            {
                _bookstoreDbContext.AuthorContactDetails.Remove(authorContactDetail);
            }

            //Remove author biography
            var authorBiography = await _bookstoreDbContext.AuthorBiographies
                .Where(x => x.AuthorId == request.AuthorId && x.StatusId == 1)
                .FirstOrDefaultAsync(cancellationToken);
            if (authorBiography == null)
            {
                throw new ObjectNotExistInDbException(request.AuthorId, "Author Biography");
            }
            _bookstoreDbContext.AuthorBiographies.Remove(authorBiography);

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