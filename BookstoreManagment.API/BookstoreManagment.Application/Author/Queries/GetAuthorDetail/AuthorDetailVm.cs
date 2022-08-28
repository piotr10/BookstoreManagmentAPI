using AutoMapper;
using BookstoreManagement.Application.Common.Mappings;
using BookstoreManagement.Domain.Entities.Author;

namespace BookstoreManagement.Application.Author.Queries.GetAuthorDetail;

public class AuthorDetailVm : IMapFrom<Domain.Entities.Author.Author>
{
    public int AuthorDetailId { get; set; }
    public DateTime AuthorDateOfBirth { get; set; } //AuthorBiography>DateOfBirth
    // public string? AuthorPlaceOfBirth { get; set; } //AuthorBiography>PlaceOfBirth
    public string? AuthorFullName { get; set; } //Author>AuthorName
                                                // public string? HomeCountry { get; set; } //AuthorBiography>Country
    public string? Contact { get; set; } //AuthorContactDetail>Name
    public string? AuthorContactType { get; set; }


    public void Mapping(Profile profile)
    {
        profile.CreateMap<Domain.Entities.Author.Author, AuthorDetailVm>()
            .ForMember(d => d.AuthorDetailId, map
                => map.MapFrom(src => src.Id))
            .ForMember(d => d.AuthorDateOfBirth, map
                 => map.MapFrom(src => src.AuthorBiography.DateOfBirth))
            //  .ForMember(d => d.AuthorPlaceOfBirth, map
            //      => map.MapFrom(src => src.AuthorBiography.PlaceOfBirth))
            .ForMember(d => d.AuthorFullName, map
                => map.MapFrom(src => src.AuthorName.ToString()))
            //  .ForMember(d => d.HomeCountry, map
            //      => map.MapFrom(src => src.AuthorBiography.Country))
            .ForMember(d => d.Contact, map
                => map.MapFrom<ContactDetailResolver>())

            .ForMember(d => d.AuthorContactType, map
                => map.MapFrom<ContactDetailTypeResolver>())

            .ForAllOtherMembers(d => d.Ignore());
    }

    private class ContactDetailResolver : IValueResolver<Domain.Entities.Author.Author, object, string>
    {
        public string Resolve(Domain.Entities.Author.Author source, object destination, string destMember, ResolutionContext context)
        {
            if (source.AuthorContactDetails is not null && source.AuthorContactDetails.Any())
            {
                var contactDetail = source.AuthorContactDetails.FirstOrDefault()?.Name;
                if (contactDetail != null) return contactDetail.ToString();
            }
            return string.Empty;
        }
    }

    private class ContactDetailTypeResolver : IValueResolver<Domain.Entities.Author.Author, object, string>
    {
        public string Resolve(Domain.Entities.Author.Author source, object destination, string destMember, ResolutionContext context)
        {
            if (source.AuthorContactDetails is not null && source.AuthorContactDetails.Any())
            {
                var contactDetailType = source.AuthorContactDetails.FirstOrDefault()?.AuthorContactDetailType.Name;
                if (contactDetailType != null) return contactDetailType.ToString();
            }
            return string.Empty;
        }
    }
}

