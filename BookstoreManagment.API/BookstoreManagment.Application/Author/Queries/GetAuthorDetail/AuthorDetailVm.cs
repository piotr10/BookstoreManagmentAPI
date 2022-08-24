using AutoMapper;
using BookstoreManagement.Application.Common.Mappings;

namespace BookstoreManagement.Application.Author.Queries.GetAuthorDetail;

public class AuthorDetailVm : IMapFrom<Domain.Entities.Author.Author>  
{
    public int AuthorDetailId { get; set; }
    public DateTime AuthorDateOfBirth { get; set; } //AuthorBiography>DateOfBirth
    public string AuthorPlaceOfBirth { get; set; } //AuthorBiography>PlaceOfBirth
    public string AuthorFullName { get; set; } //Author>AuthorName
    public string HomeCountry { get; set; } //AuthorBiography>Country
    public string? Contact { get; set; } //AuthorContactDetail>Name
    public string? ContactDetailType { get; set; } //AuthorContactDetailType>Name

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Domain.Entities.Author.Author, AuthorDetailVm>()
            .ForMember(d => d.AuthorDetailId, map
                => map.MapFrom(src => src.Id))
            .ForMember(d => d.AuthorFullName, map
                => map.MapFrom(src => src.AuthorName.ToString()))
            .ForMember(d => d.Contact, map
                => map.MapFrom<ContactResolver>())
            .ForAllOtherMembers(d=>d.Ignore());

        //.ForMember(d => d.Contact, map
        //    => map.MapFrom(src =>
        //        src.AuthorContactDetails.FirstOrDefault(x => x.Id == AuthorDetailId).Name));

    }

    private class ContactResolver : IValueResolver<Domain.Entities.Author.Author, object, string>
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
}