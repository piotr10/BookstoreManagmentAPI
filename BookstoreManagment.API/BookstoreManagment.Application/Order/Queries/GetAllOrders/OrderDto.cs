using AutoMapper;
using BookstoreManagement.Application.Common.Mappings;
using BookstoreManagement.Domain.Entities.Book;

namespace BookstoreManagement.Application.Order.Queries.GetAllOrders;

public class OrderDto : IMapFrom<Domain.Entities.Order.Order>
{
    //Order
    public DateTime DayOfDelivery { get; set; }
    public DateTime DayOfOrder { get; set; }
    public decimal OrderPrice { get; set; }
    public int OrderQuantity { get; set; }
    public string? OrderTransportType { get; set; }
    public string? PaymentMethod { get; set; }

    //Customer
    public string? CustomerName { get; set; }
    public string? CustomerSurname { get; set; }
    //Customer Address
    public int ApartmentNumber { get; set; }
    public string? City { get; set; }
    public string? Country { get; set; }
    public int HouseNumber { get; set; }
    public string? StreetName { get; set; }
    public string? PostCode { get; set; }

    //Book
    public string? BookName { get; set; }
    public decimal BookPrice { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Domain.Entities.Order.Order, OrderDto>()
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


            .ForMember(d => d.BookName, map
                => map.MapFrom(src=>src.Name))
            .ForMember(x => x.BookPrice, map
                => map.MapFrom(src => src.BookPrice))

            .ForAllOtherMembers(d => d.Ignore());
    }
    /*
    private class BookDetailResolver : IValueResolver<Domain.Entities.Order.Order, object, decimal>
    {
        public decimal Resolve(Domain.Entities.Order.Order source, object destination, decimal destMember, ResolutionContext context)
        {
            if (source.Book.BookDetails is not null && source.Book.BookDetails.Any())
            {
                var bookDetails = source.Book.BookDetails.ToList();

                
                foreach (var detail in bookDetails)
                {
                    if (expr)
                    {
                        
                    }
                }

                bookDetails.Select(x => x.Price);

            if (bookDetails != null) return  bookDetails;
            }

            return 0;
        }
    }*/
}