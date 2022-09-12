using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Exceptions;
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
        try
        {
            var orders = await _bookstoreDbContext.Orders.Where(x => x.StatusId == 1).AsNoTracking().ProjectTo<OrderDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
            if (orders == null)
            {
                throw new ThisObjectNotExistInDbException("Orders");
            }

            return new OrdersVm() { Orders = orders };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }


    }
}