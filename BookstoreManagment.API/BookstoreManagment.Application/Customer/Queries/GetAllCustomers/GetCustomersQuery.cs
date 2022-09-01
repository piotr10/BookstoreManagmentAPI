using MediatR;

namespace BookstoreManagement.Application.Customer.Queries.GetAllCustomers;

public class GetCustomersQuery : IRequest<CustomersVm>
{
}