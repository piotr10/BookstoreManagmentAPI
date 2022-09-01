using BookstoreManagement.Domain.Entities.Book;

namespace BookstoreManagement.Application.Order.Queries.GetAllBooks;

public class BookDetailsVm
{
    public ICollection<BookDetailDto> BookDetails { get; set; }
}