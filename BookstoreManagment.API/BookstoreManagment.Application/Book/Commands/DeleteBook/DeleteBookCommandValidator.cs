using FluentValidation;

namespace BookstoreManagement.Application.Book.Commands.DeleteBook;

public class DeleteBookCommandValidator : AbstractValidator<DeleteBookCommand>
{
    public DeleteBookCommandValidator()
    {
        
    }
}