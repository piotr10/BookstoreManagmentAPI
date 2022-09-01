using AutoMapper;
using BookstoreManagement.Application.Common.Mappings;
using BookstoreManagement.Domain.Entities.Book;

namespace BookstoreManagement.Application.Order.Queries.GetAllBooks;

public class BookDetailDto : IMapFrom<BookDetail>
{
    public int BookDetailId { get; set; }
    public string? BookName { get; set; }
    public decimal BookPrice { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<BookDetail, BookDetailDto>()
            .ForMember(x => x.BookDetailId, map => map.MapFrom(src => src.Id))
            .ForMember(x => x.BookName, map => map.MapFrom(src => src.Name))
            .ForMember(x => x.BookPrice, map => map.MapFrom(src => src.Price));
    }
}