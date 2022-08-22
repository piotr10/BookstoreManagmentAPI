using BookstoreManagement.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Author.Queries.GetAuthorDetail;

public class GetAuthorDetailQueryHandler : IRequestHandler<GetAuthorDetailQuery, AuthorDetailVm>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;

    public GetAuthorDetailQueryHandler(IBookstoreDbContext bookstoreDbContext)
    {
        _bookstoreDbContext = bookstoreDbContext;
    }

    public async Task<AuthorDetailVm> Handle(GetAuthorDetailQuery request, CancellationToken cancellationToken)
    {
        var author = await _bookstoreDbContext.Authors.Where(p => p.Id == request.AuthorId)
            .FirstOrDefaultAsync(cancellationToken);

        var contactDetail = await _bookstoreDbContext.AuthorContactDetails.Where(p => p.Id == request.ContactDetailId)
            .FirstOrDefaultAsync(cancellationToken);

        var authorVm = new AuthorDetailVm()
        {
            AuthorDateOfBirth = author.AuthorBiography.DateOfBirth,
            AuthorPlaceOfBirth = author.AuthorBiography.PlaceOfBirth,
            AuthorFullName = author.AuthorName.ToString(),
            HomeCountry = author.AuthorBiography.Country,
            Contact = author.AuthorContactDetails.Select(p =>p.Name).ToString(),
            ContactDetailType = author.AuthorContactDetails.Select(p => p.AuthorContactDetailType.Name).ToString()

            //Contact = contactDetail.Name, TEST
            //ContactDetailType = contactDetail.AuthorContactDetailType.Name TEST

            // DO ZMIANY WSZYSTKIE ENTITIES, KTÓRE POSIADAJĄ ICollection
            //Ponieważ nie tworzy się lista i nie ma wyboru properties
            //i zrobić tak jak w projekcie
            //FoodStore + skoczyłeś na Lekcja 5 Queries czas: 12:26
            // + dodać migrację ponieważ dodałeś jedno entity w 
            //CustomreDetail > DetailContact
        };
        return authorVm;
    }
}