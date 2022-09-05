using BookstoreManagement.Application.Book.Queries.GetAllBooks;

namespace BookstoreManagement.Application.Book.Queries.GetAllBooks;

public class BookDetailsVm
{
    public ICollection<BookDetailDto> BookDetails { get; set; }
}