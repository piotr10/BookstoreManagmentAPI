using BookstoreManagement.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Order.Queries.GetOrderDetail;

public class GetOrderDetailQueryHandler : IRequestHandler<GetOrderDetailQuery, OrderDetailVm>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;

    public GetOrderDetailQueryHandler(IBookstoreDbContext bookstoreDbContext)
    {
        _bookstoreDbContext = bookstoreDbContext;
    }

    public async Task<OrderDetailVm> Handle(GetOrderDetailQuery request, CancellationToken cancellationToken)
    {
        var order = await _bookstoreDbContext.Orders.Where(p => p.Id == request.OrderId)
            .FirstOrDefaultAsync(cancellationToken);

        var orderVm = new OrderDetailVm()
        {

        };
        return orderVm;
    }
}