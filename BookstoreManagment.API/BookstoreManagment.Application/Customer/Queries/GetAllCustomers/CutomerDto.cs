using AutoMapper;
using BookstoreManagement.Application.Common.Mappings;
using BookstoreManagement.Domain.Entities.Customer;

namespace BookstoreManagement.Application.Customer.Queries.GetAllCustomers;

public class CutomerDto : IMapFrom<CustomerDetail>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string DetailContact { get; set; }
    public string DetailType { get; set; }

    //Adress
    public int ApartmentNumber { get; set; }
    public string City { get; set; }
    public string Country { get; set; }
    public int HouseNumber { get; set; }
    public string StreetName { get; set; }
    public string PostCode { get; set; }
    public string AddressTypeName { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<CustomerDetail, CutomerDto>()
            .ForMember(x => x.Name, map
                => map.MapFrom(src => src.FirstName))
            .ForMember(x => x.Surname, map
                => map.MapFrom(src => src.LastName))
            .ForMember(x => x.DetailContact, map
                => map.MapFrom(src => src.DetailContact))
            .ForMember(x => x.DetailType, map
                => map.MapFrom(src => src.CustomerDetailType.Name.ToString()))

            .ForMember(x => x.ApartmentNumber, map
                => map.MapFrom(src => src.Adres.ApartmentNumber))
            .ForMember(x => x.City, map
                => map.MapFrom(src => src.Adres.City))
            .ForMember(x => x.Country, map
                => map.MapFrom(src => src.Adres.Country))
            .ForMember(x => x.HouseNumber, map
                => map.MapFrom(src => src.Adres.HouseNumber))
            .ForMember(x => x.StreetName, map
                => map.MapFrom(src => src.Adres.Street))
            .ForMember(x => x.PostCode, map
                => map.MapFrom(src => src.Adres.ZipCode))
            .ForMember(x => x.AddressTypeName, map
                => map.MapFrom(src => src.CustomerAddressType.Name.ToString()))
            .ForAllOtherMembers(d => d.Ignore());
    }
}