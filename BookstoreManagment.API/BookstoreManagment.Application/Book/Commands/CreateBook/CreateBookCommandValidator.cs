using FluentValidation;

namespace BookstoreManagement.Application.Book.Commands.CreateBook;

public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
{
    public CreateBookCommandValidator()
    {
        
    }
}