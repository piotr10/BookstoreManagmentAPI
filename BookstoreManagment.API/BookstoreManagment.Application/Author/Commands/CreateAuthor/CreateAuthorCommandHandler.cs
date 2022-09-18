using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Entities.Author;
using BookstoreManagement.Domain.Exceptions;
using BookstoreManagement.Domain.ValueObjects;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BookstoreManagement.Application.Author.Commands.CreateAuthor;

public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand, int>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly ICurrentUserService _userService;

    public CreateAuthorCommandHandler(IBookstoreDbContext bookstoreDbContext, ICurrentUserService userService)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _userService = userService;
    }

    public async Task<int> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
    {
        try
        {
            Domain.Entities.Author.Author author = new()
            {
                AuthorName = new PersonName()
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName
                }
            };
            await _bookstoreDbContext.Authors.AddAsync(author, cancellationToken);

            try
            {
                await _bookstoreDbContext.SaveChangesAsync(cancellationToken);
            }
            catch (Exception e)
            {
                throw new DbUpdateException("Saving to database error!");
            }
            
            var authorId = await _bookstoreDbContext.Authors.FindAsync(request.AuthorId);
            if (authorId == null)
            {
                throw new ObjectNotExistInDbException(request.AuthorId, "Author");
            }

            AuthorBiography authorBiography = new()
            {
                Country = request.Country,
                DateOfBirth = request.AuthorDateOfBirth,
                PlaceOfBirth = request.AuthorPlaceOfBirth,
                Author = authorId
            };
            await _bookstoreDbContext.AuthorBiographies.AddAsync(authorBiography, cancellationToken);

            AuthorContactDetail contactDetail = new()
            {
                Name = request.Contact,
                AuthorContactDetailTypeId = request.AuthorContactDetailTypeId,
                Author = authorId
            };
            await _bookstoreDbContext.AuthorContactDetails.AddAsync(contactDetail, cancellationToken);

            try
            {
                await _bookstoreDbContext.SaveChangesAsync(cancellationToken);
            }
            catch (Exception e)
            {
                throw new DbUpdateException("Saving to database error!");
            }

            return author.Id;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}