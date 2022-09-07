using FluentValidation;

namespace BookstoreManagement.Application.Customer.Commands.DeleteCustomer;

public class DeleteCustomerCommandValidator : AbstractValidator<DeleteCustomerCommand>
{
    public DeleteCustomerCommandValidator()
    {
        
    }
}