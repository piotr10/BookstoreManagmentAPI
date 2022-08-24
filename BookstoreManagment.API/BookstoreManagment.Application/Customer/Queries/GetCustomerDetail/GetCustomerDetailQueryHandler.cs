using BookstoreManagement.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Customer.Queries.GetCustomerDetail;

public class GetCustomerDetailQueryHandler : IRequestHandler<GetCustomerDetailQuery, CustomerDetailVm>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;

    public GetCustomerDetailQueryHandler(IBookstoreDbContext bookstoreDbContext)
    {
        _bookstoreDbContext = bookstoreDbContext;
    }

    public async Task<CustomerDetailVm> Handle(GetCustomerDetailQuery request, CancellationToken cancellationToken)
    {
        var customer = await _bookstoreDbContext.Customers.Where(p => p.Id == request.CustomerId)
            .FirstOrDefaultAsync(cancellationToken);

        var customerVm = new CustomerDetailVm()
        {

        };
        return customerVm;
    }
}