using AutoMapper;
using BookstoreManagement.Application.Common.Mappings;
using BookstoreManagement.Domain.Entities.Customer;

namespace BookstoreManagement.Application.Customer.Queries.GetCustomerDetail;

public class CustomerDetailVm : IMapFrom<Domain.Entities.Customer.Customer>
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string ContactName { get; set; }
    public string ContactType { get; set; }
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
        profile.CreateMap<Domain.Entities.Customer.Customer, CustomerDetailVm>()
            .ForMember(x => x.Name, map
                => map.MapFrom(src => src.CustomerDetails.FirstOrDefault().FirstName))
            .ForMember(x => x.Surname, map
                => map.MapFrom(src => src.CustomerDetails.FirstOrDefault().LastName))
            .ForMember(x => x.ContactName, map
                => map.MapFrom(src => src.CustomerContactDetails.FirstOrDefault().ContactName))
            .ForMember(x => x.ContactType, map
                => map.MapFrom(src => src.CustomerContactDetails.FirstOrDefault().CustomerContactDetailType.Name.ToString()))
            .ForMember(x => x.DetailType, map
                => map.MapFrom(src => src.CustomerDetails.FirstOrDefault().CustomerDetailType.Name.ToString()))

            .ForMember(x => x.ApartmentNumber, map
                => map.MapFrom(src => src.CustomerDetails.FirstOrDefault().Adres.ApartmentNumber))
            .ForMember(x => x.City, map
                => map.MapFrom(src => src.CustomerDetails.FirstOrDefault().Adres.City))
            .ForMember(x => x.Country, map
                => map.MapFrom(src => src.CustomerDetails.FirstOrDefault().Adres.Country))
            .ForMember(x => x.HouseNumber, map
                => map.MapFrom(src => src.CustomerDetails.FirstOrDefault().Adres.HouseNumber))
            .ForMember(x => x.StreetName, map
                => map.MapFrom(src => src.CustomerDetails.FirstOrDefault().Adres.Street))
            .ForMember(x => x.PostCode, map
                => map.MapFrom(src => src.CustomerDetails.FirstOrDefault().Adres.ZipCode))
            .ForMember(x => x.AddressTypeName, map
                => map.MapFrom(src => src.CustomerDetails.FirstOrDefault().CustomerAddressType.Name.ToString()))
            .ForAllOtherMembers(d => d.Ignore());
    }
    /*
    private class CustomerContactDetailResolver : IValueResolver<CustomerDetail, object, string>
    {
        public string Resolve(CustomerDetail source, object destination, string destMember, ResolutionContext context)
        {
            if (source.Customer is not null)
            {
                var contactDetail = source.Customer.CustomerContactDetails.FirstOrDefault()?.ContactName;
                if (contactDetail != null) return contactDetail.ToString();
            }
            return string.Empty;
        }
    }*/
}