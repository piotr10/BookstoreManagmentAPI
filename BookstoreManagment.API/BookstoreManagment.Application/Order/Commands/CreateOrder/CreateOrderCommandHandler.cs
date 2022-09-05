using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Order.Commands.CreateOrder;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;

    public CreateOrderCommandHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var bookId = await _bookstoreDbContext.Books.FindAsync(request.BookId);
        var customerId = await _bookstoreDbContext.Customers.FindAsync(request.CustomerId);

        Domain.Entities.Order.Order order = new Domain.Entities.Order.Order()
        {
            Book = bookId,
            Customer = customerId,
            OrderTransportTypeId = request.OrderTransportTypeId,
            PaymentMethodId = request.PaymentMethodId,
            DeliveryDate = request.DeliveryDate,
            OrderDate = request.OrderDate,
            Quantity = request.Quantity,
            OrderPrice = bookId.Price * request.Quantity,
            Name = bookId.Name,
            BookPrice = bookId.Price
        };

        _bookstoreDbContext.Orders.Add(order);
        await _bookstoreDbContext.SaveChangesAsync(cancellationToken);

        return order.Id;
    }
}