using FluentValidation;

namespace BookstoreManagement.Application.Book.Commands.DeleteBook;

public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand>
{
    public DeleteBookCommandValidator()
    {
        RuleFor(x => x.BookId).NotEmpty().GreaterThan(0);
    }
}