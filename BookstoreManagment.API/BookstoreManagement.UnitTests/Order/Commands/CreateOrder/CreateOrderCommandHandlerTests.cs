using BookstoreManagement.Application.Order.Commands.CreateOrder;
using BookstoreManagement.UnitTests.Common;
using Microsoft.EntityFrameworkCore;
using Shouldly;

namespace BookstoreManagement.UnitTests.Order.Commands.CreateOrder;

public class CreateOrderCommandHandlerTests : CommandTestBase
{
    private readonly CreateOrderCommandHandler _handler;

    public CreateOrderCommandHandlerTests() : base()
    {
        _handler = new CreateOrderCommandHandler(_context);
    }

    [Fact]
    public async Task Handle_GivenValidRequest_ShouldInsertOrder()
    {
        var command = new CreateOrderCommand()
        {
            BookId = 9,
            CustomerId = 3,
            OrderTransportTypeId = 3,
            PaymentMethodId = 3,
            DeliveryDate = new DateTime(2022, 1, 2),
            OrderDate = new DateTime(2022, 1, 1),
            Quantity = 11
        };

        var result = await _handler.Handle(command, CancellationToken.None);

        var order = await _context.Orders.FirstAsync(x => x.Id == result, CancellationToken.None);
        order.ShouldNotBeNull();
    }
}