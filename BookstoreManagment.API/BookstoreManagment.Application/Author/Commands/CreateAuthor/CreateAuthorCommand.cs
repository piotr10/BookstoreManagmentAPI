using AutoMapper;
using BookstoreManagement.Application.Common.Mappings;
using BookstoreManagement.Domain.Entities.Author;
using MediatR;

namespace BookstoreManagement.Application.Author.Commands.CreateAuthor;

public class CreateAuthorCommand : IRequest<int>
{
    //Author
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    //Biography
    public int AuthorId { get; set; }
    //ContactDetail
    public int AuthorContactDetailTypeId { get; set; }
    public DateTime AuthorDateOfBirth { get; set; }
    public string? AuthorPlaceOfBirth { get; set; }
    public string? Country { get; set; }
    public string? Contact { get; set; }

    #region mapowanie

    //public int ContactDetailTypeId { get; set; }
    /*
    public void Mapping(Profile profile)
    {
        profile.CreateMap<CreateAuthorCommand, Domain.Entities.Author.Author>()
            .ForMember(x => x.AuthorName, map
                => map.MapFrom(src => src.FirstName.ToString()))
            .ForMember(x => x.AuthorName.LastName, map
                => map.MapFrom(src => src.LastName.ToString()))
            .ForAllOtherMembers(d => d.Ignore());

        profile.CreateMap<CreateAuthorCommand, AuthorBiography>()
                .ForMember(x => x.DateOfBirth, map
                    => map.MapFrom(src => src.AuthorDateOfBirth))
                .ForMember(x => x.PlaceOfBirth, map
                    => map.MapFrom(src => src.AuthorPlaceOfBirth))
                .ForMember(x => x.Country, map
                    => map.MapFrom(src => src.Country))
                .ForMember(x => x.AuthorId, map
                    => map.MapFrom(src => src.AuthorId))
                .ForAllOtherMembers(d => d.Ignore());

        profile.CreateMap<CreateAuthorCommand, AuthorContactDetail>()
            .ForMember(x => x.Name, map
                => map.MapFrom(src => src.Contact))
            .ForMember(x => x.AuthorId, map
                => map.MapFrom(src => src.AuthorId))
            .ForMember(x => x.AuthorContactDetailTypeId, map
                => map.MapFrom(src => src.AuthorContactDetailTypeId))
            .ForAllOtherMembers(d => d.Ignore());
    }
    */

    #endregion
}