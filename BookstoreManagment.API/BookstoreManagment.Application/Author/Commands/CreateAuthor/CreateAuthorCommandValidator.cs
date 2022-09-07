using FluentValidation;

namespace BookstoreManagement.Application.Author.Commands.CreateAuthor;

public class CreateAuthorCommandValidator : AbstractValidator<CreateAuthorCommand>
{
    public CreateAuthorCommandValidator()
    {
        RuleFor(x => x.FirstName).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(x => x.LastName).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(x => x.AuthorId).GreaterThan(0);
        RuleFor(x => x.AuthorContactDetailTypeId).GreaterThan(0);
        RuleFor(x => x.AuthorDateOfBirth).NotEmpty();
        RuleFor(x => x.AuthorPlaceOfBirth).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(x => x.Country).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(x => x.Contact).NotEmpty().MinimumLength(2).MaximumLength(40);
    }
}