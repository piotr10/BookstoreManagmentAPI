using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Entities.Author;
using BookstoreManagement.Domain.ValueObjects;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BookstoreManagement.Application.Author.Commands.CreateAuthor;

public class CreateAuthorCommandHandler : IRequestHandler<CreateAuthorCommand, int>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;

    public CreateAuthorCommandHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
    }

    public async Task<int> Handle(CreateAuthorCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.Author.Author author = new()
        {
            AuthorName = new PersonName()
            {
                FirstName = request.FirstName,
                LastName = request.LastName
            }
        };

        _bookstoreDbContext.Authors.Add(author);
        await _bookstoreDbContext.SaveChangesAsync(cancellationToken);

        var authorId = await _bookstoreDbContext.Authors.FindAsync(request.AuthorId);

        AuthorBiography authorBiography = new()
        {
            Country = request.Country,
            DateOfBirth = request.AuthorDateOfBirth,
            PlaceOfBirth = request.AuthorPlaceOfBirth,
            Author = authorId
        };

        _bookstoreDbContext.AuthorBiographies.Add(authorBiography);

        AuthorContactDetail contactDetail = new()
        {
            Name = request.Contact,
            AuthorContactDetailTypeId = request.AuthorContactDetailTypeId,
            Author = authorId
        };

        _bookstoreDbContext.AuthorContactDetails.Add(contactDetail);
        await _bookstoreDbContext.SaveChangesAsync(cancellationToken);

        return author.Id;
    }
}