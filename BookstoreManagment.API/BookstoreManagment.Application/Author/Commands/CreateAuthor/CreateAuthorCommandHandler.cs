using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Entities.Author;
using BookstoreManagement.Domain.ValueObjects;
using MediatR;

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
        
        Domain.Entities.Author.Author author = new ()
        {
            AuthorName = new PersonName()
            {
                FirstName = request.FirstName,
                LastName = request.LastName
            }
        };

        _bookstoreDbContext.Authors.Add(author);

        AuthorBiography authorBiography = new ()
        {
            Country = request.Country,
            DateOfBirth = request.AuthorDateOfBirth,
            PlaceOfBirth = request.AuthorPlaceOfBirth,
            AuthorId = author.Id
        };

        _bookstoreDbContext.AuthorBiographies.Add(authorBiography);

        AuthorContactDetail contactDetail = new ()
        {
            Name = request.Contact,
            AuthorContactDetailTypeId = request.AuthorContactDetailTypeId,
            AuthorId = author.Id
        };

        _bookstoreDbContext.AuthorContactDetails.Add(contactDetail);

        await _bookstoreDbContext.SaveChangesAsync(cancellationToken);

        return author.Id;
        
        /*
        var author = _mapper.Map<Domain.Entities.Author.Author>(request);
        await _bookstoreDbContext.Authors.AddAsync(author, cancellationToken);

        var authorBiography = _mapper.Map<AuthorBiography>(request);
        authorBiography.AuthorId = author.Id;

        var authorContactDetail = _mapper.Map<AuthorContactDetail>(request);
        authorBiography.AuthorId = author.Id;

        await _bookstoreDbContext.SaveChangesAsync(cancellationToken);

        return author.Id;*/
    }
}