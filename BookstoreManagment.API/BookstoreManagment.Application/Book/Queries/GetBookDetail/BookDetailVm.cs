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
            .ForMember(d => d.AuthorFullName, map
                => map.MapFrom(src => src.Book.Author.AuthorName.ToString()))
            .ForMember(d => d.BookName, map
                => map.MapFrom(src=>src.Name))
            .ForMember(d => d.PublishedBookDate, map
                => map.MapFrom(src => src.PublishedBookDate))
            .ForMember(d => d.Price, map
                => map.MapFrom(src => src.Price))
            .ForMember(d => d.Genre, map
                => map.MapFrom(src => src.Genre.Name.ToString()))

            .ForAllOtherMembers(d => d.Ignore());
    }
    /*
    private class BookNameResolver : IValueResolver<Domain.Entities.Book.BookDetail, object, string>
    {
        public string Resolve(Domain.Entities.Book.BookDetail source, object destination, string destMember, ResolutionContext context)
        {
            if (source. is not null && source.BookDetails.Any())
            {
                var bookDetail = source.BookDetails.FirstOrDefault()?.Name;
                if (bookDetail != null) return bookDetail.ToString();
            }
            return string.Empty;
        }
    }

    private class PublishedResolver : IValueResolver<Domain.Entities.Book.BookDetail, object, DateTime>
    {
        public DateTime Resolve(Domain.Entities.Book.BookDetail source, object destination, DateTime destMember, ResolutionContext context)
        { 
            var bookDetail = source.BookDetails.FirstOrDefault()?.PublishedBookDate;
            return (DateTime) bookDetail;
        }
    }

    private class PriceResolver : IValueResolver<Domain.Entities.Book.BookDetail, object, decimal?>
    {
        public decimal? Resolve(Domain.Entities.Book.BookDetail source, object destination, decimal? destMember, ResolutionContext context)
        {
            var bookDetail = source.BookDetails.FirstOrDefault().Price;
            return bookDetail;
        }
        
    }

    private class GenreResolver : IValueResolver<Domain.Entities.Book.BookDetail, object, string>
    {
        public string Resolve(Domain.Entities.Book.BookDetail source, object destination, string destMember, ResolutionContext context)
        {
            if (source.BookDetails is not null && source.BookDetails.Any())
            {
                var genreType = source.BookDetails.FirstOrDefault()?.Genre.Name;
                if (genreType != null) return genreType.ToString();
            }
            return string.Empty;
        }
    }*/
}
