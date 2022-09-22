using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Order.Commands.CreateOrder;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, int>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;

    public CreateOrderCommandHandler(IBookstoreDbContext bookstoreDbContext)
    {
        _bookstoreDbContext = bookstoreDbContext;
    }
    public async Task<int> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var bookId = await _bookstoreDbContext.Books.FindAsync(request.BookId);
            var customerId = await _bookstoreDbContext.Customers.FindAsync(request.CustomerId);
            if (bookId == null)
            {
                throw new ObjectNotExistInDbException(request.BookId, "Book");
            }

            if (customerId == null)
            {
                throw new ObjectNotExistInDbException(request.CustomerId, "Customer");
            }

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
            await _bookstoreDbContext.Orders.AddAsync(order, cancellationToken);

            try
            {
                await _bookstoreDbContext.SaveChangesAsync(cancellationToken);
            }
            catch (Exception e)
            {
                throw new DbUpdateException("Saving to database error!");
            }

            return order.Id;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}