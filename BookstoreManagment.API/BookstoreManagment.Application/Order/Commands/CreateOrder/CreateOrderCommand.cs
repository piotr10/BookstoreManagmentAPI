using MediatR;

namespace BookstoreManagement.Application.Order.Commands.CreateOrder;

public class CreateOrderCommand : IRequest<int>
{
    //Order
    public int BookId { get; set; }
    public int CustomerId { get; set; }
    //BookDetail
    public int OrderTransportTypeId { get; set; }
    public int PaymentMethodId { get; set; }

    public DateTime DeliveryDate { get; set; }
    public DateTime OrderDate { get; set; }
    public int Quantity { get; set; }
}