using AutoMapper;
using BookstoreManagement.Application.Common.Mappings;
using BookstoreManagement.Domain.Entities.Author;
using MediatR;

namespace BookstoreManagement.Application.Author.Commands.CreateAuthor;

public class CreateAuthorCommand : IRequest<int>//, IMapFrom<CreateAuthorCommand>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    //public int AuthorContactDetailId { get; set; }
    public int AuthorContactDetailTypeId { get; set; }
    //public string? AuthorFullName { get; set; }
    public DateTime AuthorDateOfBirth { get; set; }
    public string? AuthorPlaceOfBirth { get; set; }
    public string? Country { get; set; }
    public string? Contact { get; set; }
    //public int ContactDetailTypeId { get; set; }
    /*
    public void Mapping(Profile profile)
    {
        profile.CreateMap<CreateAuthorCommand, Domain.Entities.Author.Author>()
            .ForMember(x => x.AuthorName, map => map.MapFrom(src => src.FirstName.ToString()))
            .ForMember(x => x.AuthorName.LastName, map => map.MapFrom(src => src.LastName.ToString()));
            //.ForMember(x => x.AuthorBiography.DateOfBirth, map => map.MapFrom(src => src.AuthorDateOfBirth))
            //.ForMember(x => x.AuthorBiography.PlaceOfBirth.ToString(),
             //   map => map.MapFrom(src => src.AuthorPlaceOfBirth))
            //.ForMember(x => x.AuthorBiography.Country.ToString(), map => map.MapFrom(src => src.Country))
            //.ForMember(x => x.AuthorContactDetails.FirstOrDefault().Name.ToString(),
            //    map => map.MapFrom(src => src.Contact))
            //.ForMember(x => x.AuthorContactDetails.FirstOrDefault().AuthorContactDetailType.Name.ToString(),
            //    map => map.MapFrom(src => src.ContactDetailType));

            profile.CreateMap<CreateAuthorCommand, AuthorBiography>()
                .ForMember(x => x.DateOfBirth, map => map.MapFrom(src => src.AuthorDateOfBirth))
                .ForMember(x => x.PlaceOfBirth, map => map.MapFrom(src => src.AuthorPlaceOfBirth))
                .ForMember(x => x.Country, map => map.MapFrom(src => src.Country))
                .ForMember(x => x.AuthorId, map => map.MapFrom(src => src.AuthorBiographyId));

        profile.CreateMap<CreateAuthorCommand, AuthorContactDetail>()
            .ForMember(x => x.Name, map => map.MapFrom(src => src.Contact))
            .ForMember(x => x.AuthorId, map => map.MapFrom(src => src.AuthorContactDetailId))
            .ForMember(x => x.AuthorContactDetailTypeId, map => map.MapFrom(src => src.ContactDetailTypeId));
    }*/
}