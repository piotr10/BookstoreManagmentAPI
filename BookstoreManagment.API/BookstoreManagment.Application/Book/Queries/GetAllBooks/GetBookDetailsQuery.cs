using MediatR;

namespace BookstoreManagement.Application.Book.Queries.GetAllBooks;

public class GetBookDetailsQuery : IRequest<BookDetailsVm>
{
}