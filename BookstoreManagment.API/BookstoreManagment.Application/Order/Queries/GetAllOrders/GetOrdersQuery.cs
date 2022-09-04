using MediatR;

namespace BookstoreManagement.Application.Order.Queries.GetAllOrders;

public class GetOrdersQuery : IRequest<OrdersVm>
{
}