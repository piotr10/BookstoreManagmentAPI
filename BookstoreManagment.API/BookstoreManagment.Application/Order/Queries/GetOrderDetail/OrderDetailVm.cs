using AutoMapper;
using BookstoreManagement.Application.Common.Mappings;

namespace BookstoreManagement.Application.Order.Queries.GetOrderDetail;

public class OrderDetailVm : IMapFrom<Domain.Entities.Order.Order>
{
    //Order
    public DateTime DayOfDelivery { get; set; } //Order>DeliveryDate
    public DateTime DayOfOrder { get; set; } //Order>OrderDate
    public decimal OrderPrice { get; set; } //Order>r
    public int OrderQuantity { get; set; } //Order>Quantity
    public string? OrderTransportType { get; set; } //OrderTransportType>Name
    public string? PaymentMethod { get; set; } //PaymentMethod>Name

    //Customer
    public string? CustomerName { get; set; } //CustomerDetail>FirstName
    public string? CustomerSurname { get; set; } //CustomerDetail>LastName
    //Customer Address
    public int ApartmentNumber { get; set; } //CustomerAddress>ApartmentNumber
    public string? City { get; set; } //CustomerAddress>City
    public string? Country { get; set; } //CustomerAddress>Country
    public int HouseNumber { get; set; } //CustomerAddress>HouseNumber
    public string? StreetName { get; set; } //CustomerAddress>Street
    public string? PostCode { get; set; } //CustomerAddress>ZipCode

    //Book
    public string? BookName { get; set; } //BookDetail>Name
    public decimal BookPrice { get; set; } //BookDetail>Price

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Domain.Entities.Order.Order, OrderDetailVm>()
            .ForMember(x => x.DayOfDelivery, map
                => map.MapFrom(src => src.DeliveryDate))
            .ForMember(x => x.DayOfOrder, map
                => map.MapFrom(src => src.OrderDate))
            .ForMember(x => x.OrderPrice, map
                => map.MapFrom(src => src.OrderPrice))
            .ForMember(x => x.OrderQuantity, map
                => map.MapFrom(src => src.Quantity))
            .ForMember(x => x.OrderTransportType, map
                => map.MapFrom(src => src.OrderTransportType.Name.ToString()))
            .ForMember(x => x.PaymentMethod, map
                => map.MapFrom(src => src.PaymentMethod.Name.ToString()))

            .ForMember(x => x.CustomerName, map
                => map.MapFrom(src => src.Customer.CustomerDetails.FirstOrDefault().FirstName.ToString()))
            .ForMember(x => x.CustomerSurname, map
                => map.MapFrom(src => src.Customer.CustomerDetails.FirstOrDefault().LastName.ToString()))

            .ForMember(x => x.ApartmentNumber, map
                => map.MapFrom(src => src.Customer.CustomerDetails.FirstOrDefault().Adres.ApartmentNumber))
            .ForMember(x => x.City, map
                => map.MapFrom(src => src.Customer.CustomerDetails.FirstOrDefault().Adres.City))
            .ForMember(x => x.Country, map
                => map.MapFrom(src => src.Customer.CustomerDetails.FirstOrDefault().Adres.Country))
            .ForMember(x => x.HouseNumber, map
                => map.MapFrom(src => src.Customer.CustomerDetails.FirstOrDefault().Adres.HouseNumber))
            .ForMember(x => x.StreetName, map
                => map.MapFrom(src => src.Customer.CustomerDetails.FirstOrDefault().Adres.Street))
            .ForMember(x => x.PostCode, map
                => map.MapFrom(src => src.Customer.CustomerDetails.FirstOrDefault().Adres.ZipCode))

            .ForMember(x => x.BookName, map
                => map.MapFrom(src => src.Book.BookDetails.FirstOrDefault().Name.ToString()))
            .ForMember(x => x.BookPrice, map
                => map.MapFrom(src => src.Book.BookDetails.FirstOrDefault().Price))

            .ForAllOtherMembers(d => d.Ignore());
    }
}