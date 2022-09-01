using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookstoreManagement.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Order.Queries.GetAllOrders;

public class GetOrdersQueryHandler : IRequestHandler<GetOrdersQuery, OrdersVm>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;

    public GetOrdersQueryHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
    }
    public async Task<OrdersVm> Handle(GetOrdersQuery request, CancellationToken cancellationToken)
    {
        var orders = await _bookstoreDbContext.Orders.AsNoTracking().ProjectTo<OrderDto>(_mapper.ConfigurationProvider)
            .ToListAsync();
        return new OrdersVm() {Orders = orders};

    }
}