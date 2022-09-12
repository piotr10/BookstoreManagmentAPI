using MediatR;

namespace BookstoreManagement.Application.Book.Queries.GetAllBooks;

public class GetBooksQuery : IRequest<BooksVm>
{
}