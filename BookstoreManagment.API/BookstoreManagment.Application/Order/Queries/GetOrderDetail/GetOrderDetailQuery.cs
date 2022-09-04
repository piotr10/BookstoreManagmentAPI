using MediatR;

namespace BookstoreManagement.Application.Order.Queries.GetOrderDetail;

public class GetOrderDetailQuery : IRequest<OrderDetailVm>
{
    public int OrderId { get; set; }
}