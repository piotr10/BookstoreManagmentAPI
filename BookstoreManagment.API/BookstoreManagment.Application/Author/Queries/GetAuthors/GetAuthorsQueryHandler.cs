using BookstoreManagement.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Author.Queries.GetAuthors;

public class GetAuthorsQueryHandler : IRequestHandler<GetAuthorsQuery, AuthorsVm>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;

    public GetAuthorsQueryHandler(IBookstoreDbContext bookstoreDbContext)
    {
        _bookstoreDbContext = bookstoreDbContext;
    }
    public async Task<AuthorsVm> Handle(GetAuthorsQuery request, CancellationToken cancellationToken)
    {
        //var authors = await _bookstoreDbContext.Authors.Where(p => p.StatusId == 1).ToListAsync(cancellationToken);
        //var author = await _bookstoreDbContext.Authors.Where(p => p.Id == request.AuthorId).FirstOrDefaultAsync(cancellationToken);
       
        var authors = await _bookstoreDbContext.Authors.Where(p => p.Id == request.AuthorsId)
            .FirstOrDefaultAsync(cancellationToken);
        var contactDetails = await _bookstoreDbContext.AuthorContactDetails.Where(p => p.Id == request.ContactDetailsId)
            .FirstOrDefaultAsync(cancellationToken);
        var authorsVm = new AuthorDto()
        {
            AuthorDateOfBirth = authors.AuthorBiography.DateOfBirth,
            AuthorPlaceOfBirth = authors.AuthorBiography.PlaceOfBirth,
            AuthorFullName = authors.AuthorName.ToString(),
            HomeCountry = authors.AuthorBiography.Country,
            Contact = authors.AuthorContactDetails.Select(p => p.Name).ToString(),
            ContactDetailType = authors.AuthorContactDetails.Select(p => p.AuthorContactDetailType.Name).ToString(),
            //Contact = contactDetails.Name, TEST
            //ContactDetailType = contactDetails.AuthorContactDetailType.Name TEST
        };
        return new AuthorsVm();
    }
}