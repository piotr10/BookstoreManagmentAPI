using MediatR;

namespace BookstoreManagement.Application.Customer.Commands.DeleteCustomer;

public class DeleteCustomerCommand : IRequest
{
    public int CustomerId { get; set; }
}