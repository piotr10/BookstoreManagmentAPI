using FluentValidation;

namespace BookstoreManagement.Application.Book.Commands.CreateBook;

public class CreateBookCommandValidator : AbstractValidator<CreateBookCommand>
{
    public CreateBookCommandValidator()
    {
        RuleFor(x => x.BookId).GreaterThan(0);
        RuleFor(x => x.AuthorId).GreaterThan(0);
        RuleFor(x => x.Name).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(x => x.PublishedBookDate).NotEmpty();
        RuleFor(x => x.Price).GreaterThanOrEqualTo(0);
        RuleFor(x => x.GenreId).GreaterThan(0);
    }
}