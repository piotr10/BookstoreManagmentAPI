using FluentValidation;

namespace BookstoreManagement.Application.Order.Commands.DeleteOrder;

public class DeleteOrderCommandValidator : AbstractValidator<DeleteOrderCommand>
{
    public DeleteOrderCommandValidator()
    {
        RuleFor(x => x.OrderId).NotEmpty().GreaterThan(0);
    }
}