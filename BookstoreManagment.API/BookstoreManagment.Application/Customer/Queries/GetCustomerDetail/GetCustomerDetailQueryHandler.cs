using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Customer.Queries.GetCustomerDetail;

public class GetCustomerDetailQueryHandler : IRequestHandler<GetCustomerDetailQuery, CustomerDetailVm>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;

    public GetCustomerDetailQueryHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
    }

    public async Task<CustomerDetailVm> Handle(GetCustomerDetailQuery request, CancellationToken cancellationToken)
    {

        var customer = await _bookstoreDbContext.Customers
            .Include(p => p.CustomerDetails)
            .ThenInclude(p => p.CustomerDetailType)
            .Include(p => p.CustomerDetails)
            .ThenInclude(p => p.CustomerAddressType)
            .Include(p => p.CustomerContactDetails)
            .ThenInclude(p => p.CustomerContactDetailType)
            .Where(p => p.Id == request.CustomerDetailId && p.StatusId == 1)
            .FirstOrDefaultAsync(cancellationToken);

        var customerVm = _mapper.Map<CustomerDetailVm>(customer);
        return customerVm;
    }
}