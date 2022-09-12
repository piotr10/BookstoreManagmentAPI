using FluentValidation;

namespace BookstoreManagement.Application.Author.Commands.DeleteAuthor;

public class DeleteAuthorCommandValidator : AbstractValidator<DeleteAuthorCommand>
{
    public DeleteAuthorCommandValidator()
    {
        RuleFor(x => x.AuthorId).NotEmpty().GreaterThan(0);
    }
}