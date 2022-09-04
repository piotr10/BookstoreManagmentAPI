namespace BookstoreManagement.Application.Order.Queries.GetAllOrders;

public class OrdersVm
{
    public ICollection<OrderDto> Orders { get; set; }
}