using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Author.Queries.GetAuthorDetail;

public class GetAuthorDetailQueryHandler : IRequestHandler<GetAuthorDetailQuery, AuthorDetailVm>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;
    private readonly ICurrentUserService _userService;

    public GetAuthorDetailQueryHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper, ICurrentUserService userService)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
        _userService = userService;
    }

    public async Task<AuthorDetailVm> Handle(GetAuthorDetailQuery request, CancellationToken cancellationToken)
    {
        var author = await _bookstoreDbContext.Authors
            .Include(p => p.AuthorContactDetails)
            .ThenInclude(p=>p.AuthorContactDetailType)
            .Include(p=>p.AuthorBiography)
            .Where(p => p.Id == request.AuthorId && p.StatusId == 1)
            .FirstOrDefaultAsync(cancellationToken);

        if (author == null)
        {
            throw new ObjectNotExistInDbException(request.AuthorId, "Author");
        }

        var authorVm = _mapper.Map<AuthorDetailVm>(author);
        return authorVm;
    }
}
#region old method
/*var authorVm = new AuthorDetailVm()
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
};*/
#endregion
