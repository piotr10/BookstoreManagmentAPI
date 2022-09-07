using FluentValidation;

namespace BookstoreManagement.Application.Order.Commands.CreateOrder;

public class CreateOrderCommandValidator : AbstractValidator<CreateOrderCommand>
{
    public CreateOrderCommandValidator()
    {
        RuleFor(x => x.BookId).GreaterThan(0);
        RuleFor(x => x.CustomerId).GreaterThan(0);
        RuleFor(x => x.OrderTransportTypeId).GreaterThan(0);
        RuleFor(x => x.PaymentMethodId).GreaterThan(0);
        RuleFor(x => x.DeliveryDate).NotEmpty();
        RuleFor(x => x.OrderDate).NotEmpty();
        RuleFor(x => x.Quantity).GreaterThanOrEqualTo(0);
    }
}