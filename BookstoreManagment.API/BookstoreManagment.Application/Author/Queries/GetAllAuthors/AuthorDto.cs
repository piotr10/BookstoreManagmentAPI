using AutoMapper;
using BookstoreManagement.Application.Common.Mappings;

namespace BookstoreManagement.Application.Author.Queries.GetAllAuthors;

public class AuthorDto : IMapFrom<Domain.Entities.Author.Author>
{
    public int AuthorDetailId { get; set; }
    public DateTime AuthorDateOfBirth { get; set; }
    public string? AuthorPlaceOfBirth { get; set; }
    public string? AuthorFullName { get; set; }
    public string? HomeCountry { get; set; }
    public string? Contact { get; set; }
    public string? AuthorContactType { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Domain.Entities.Author.Author, AuthorDto>()
            .ForMember(d => d.AuthorDetailId, map => map.MapFrom(src => src.Id))
            .ForMember(d => d.AuthorDateOfBirth, map => map.MapFrom(src => src.AuthorBiography.DateOfBirth.Date))
              .ForMember(d => d.AuthorPlaceOfBirth, map => map.MapFrom(src => src.AuthorBiography.PlaceOfBirth))
            .ForMember(d => d.AuthorFullName, map => map.MapFrom(src => src.AuthorName.ToString()))
              .ForMember(d => d.HomeCountry, map => map.MapFrom(src => src.AuthorBiography.Country))
              .ForMember(d => d.Contact, map => map.MapFrom(src => src.AuthorContactDetails.FirstOrDefault().Name.ToString()))
              .ForMember(d => d.AuthorContactType, map => map.MapFrom(src => src.AuthorContactDetails.FirstOrDefault().AuthorContactDetailType.Name.ToString()))
            .ForAllOtherMembers(d => d.Ignore());
    }
}