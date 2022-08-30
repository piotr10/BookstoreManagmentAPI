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

        var customer = await _bookstoreDbContext.CustomerDetails
            .Include(p => p.Customer)
            .Include(p => p.CustomerAddressType)
            .Include(p => p.CustomerDetailType)

            .Where(p => p.Id == request.CustomerDetailId)
            .FirstOrDefaultAsync(cancellationToken);

        var customerVm = _mapper.Map<CustomerDetailVm>(customer);
        return customerVm;
    }
}