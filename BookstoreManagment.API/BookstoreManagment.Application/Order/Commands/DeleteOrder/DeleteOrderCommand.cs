using MediatR;

namespace BookstoreManagement.Application.Order.Commands.DeleteOrder;

public class DeleteOrderCommand : IRequest
{
    public int OrderId { get; set; }
}