using AutoMapper;
using BookstoreManagement.Application.Common.Mappings;
using BookstoreManagement.Domain.Entities.Book;

namespace BookstoreManagement.Application.Book.Queries.GetBookDetail;

public class BookDetailVm : IMapFrom<BookDetail>
{
    public string? BookName { get; set; }
    public DateTime PublishedBookDate { get; set; }
    public decimal? Price { get; set; }
    public string? Genre { get; set; }
    public string? AuthorFullName { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<BookDetail, BookDetailVm>()
            .ForMember(d => d.AuthorFullName, map => map.MapFrom(src => src.Book.Author.AuthorName.ToString()))
            .ForMember(d => d.BookName, map => map.MapFrom(src=>src.Name))
            .ForMember(d => d.PublishedBookDate, map => map.MapFrom(src => src.PublishedBookDate))
            .ForMember(d => d.Price, map => map.MapFrom(src => src.Price))
            .ForMember(d => d.Genre, map => map.MapFrom(src => src.Genre.Name.ToString()))
            .ForAllOtherMembers(d => d.Ignore());
    }
}
