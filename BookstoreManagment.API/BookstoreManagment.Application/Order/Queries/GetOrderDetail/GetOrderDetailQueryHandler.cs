using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Entities.Book;
using BookstoreManagement.Domain.Entities.Customer;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Order.Queries.GetOrderDetail;

public class GetOrderDetailQueryHandler : IRequestHandler<GetOrderDetailQuery, OrderDetailVm>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;

    public GetOrderDetailQueryHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
    }

    public async Task<OrderDetailVm> Handle(GetOrderDetailQuery request, CancellationToken cancellationToken)
    {
        var order = await _bookstoreDbContext.Orders
            .Include(p => p.OrderTransportType)
            .Include(p => p.PaymentMethod)
            .Include(p => p.Customer)
            .ThenInclude(p=>p.CustomerDetails)
            .Include(p => p.Book)
            .Where(p => p.Id == request.OrderId)
            .FirstOrDefaultAsync(cancellationToken);

        var orderVm = _mapper.Map<OrderDetailVm>(order);
        return orderVm;
    }
}