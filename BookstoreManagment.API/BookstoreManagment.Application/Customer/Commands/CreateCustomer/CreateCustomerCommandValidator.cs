using FluentValidation;

namespace BookstoreManagement.Application.Customer.Commands.CreateCustomer;

public class CreateCustomerCommandValidator : AbstractValidator<CreateCustomerCommand>
{
    public CreateCustomerCommandValidator()
    {
        RuleFor(x => x.CustomerId).GreaterThan(0);
        RuleFor(x => x.FirstName).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(x => x.LastName).NotEmpty().MinimumLength(2).MaximumLength(30);
        RuleFor(x => x.CustomerDetailTypeId).GreaterThan(0);
        RuleFor(x => x.CustomerAddressTypeId).GreaterThan(0);
        RuleFor(x => x.ApartmentNumber).GreaterThanOrEqualTo(0);
        RuleFor(x => x.City).NotEmpty().MinimumLength(2).MaximumLength(20);
        RuleFor(x => x.Country).NotEmpty().MinimumLength(2).MaximumLength(20);
        RuleFor(x => x.HouseNumber).GreaterThanOrEqualTo(0);
        RuleFor(x => x.Street).NotEmpty().MinimumLength(2).MaximumLength(20);
        RuleFor(x => x.ZipCode).NotEmpty().MinimumLength(0).MaximumLength(20);
        RuleFor(x => x.DetailContact).NotEmpty().MinimumLength(2).MaximumLength(40);
        RuleFor(x => x.CustomerContactDetailTypeId).GreaterThan(0);
    }
}