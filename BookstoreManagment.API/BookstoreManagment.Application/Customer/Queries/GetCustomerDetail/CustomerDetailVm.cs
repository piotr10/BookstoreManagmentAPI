using AutoMapper;
using BookstoreManagement.Application.Common.Mappings;
using BookstoreManagement.Domain.Entities.Customer;

namespace BookstoreManagement.Application.Customer.Queries.GetCustomerDetail;

public class CustomerDetailVm : IMapFrom<CustomerDetail>
{
    public string Name { get; set; } //CustomerDetail>FirstName
    public string Surname { get; set; } //CustomerDetail>LastName
    public string DetailContact { get; set; } //CustomerDetail>DetailContact
    public string DetailType { get; set; } //CustomerDetailType>Name

    //Adress
    public int ApartmentNumber { get; set; } //CustomerAddress>ApartmentNumber
    public string City { get; set; } //CustomerAddress>City
    public string Country { get; set; } //CustomerAddress>Country
    public int HouseNumber { get; set; } //CustomerAddress>HouseNumber
    public string StreetName { get; set; } //CustomerAddress>Street
    public string PostCode { get; set; } //CustomerAddress>ZipCode
    public string AddressTypeName { get; set; } //CustomerAddressType>Name

    public void Mapping(Profile profile)
    {
        profile.CreateMap<CustomerDetail, CustomerDetailVm>()
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