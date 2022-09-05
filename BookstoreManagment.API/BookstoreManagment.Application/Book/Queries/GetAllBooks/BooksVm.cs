using BookstoreManagement.Application.Book.Queries.GetAllBooks;

namespace BookstoreManagement.Application.Book.Queries.GetAllBooks;

public class BooksVm
{
    public ICollection<BooksDto> Books { get; set; }
}