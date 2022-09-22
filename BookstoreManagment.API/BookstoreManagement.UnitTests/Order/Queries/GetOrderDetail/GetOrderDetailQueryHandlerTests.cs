using AutoMapper;
using BookstoreManagement.Application.Order.Queries.GetOrderDetail;
using BookstoreManagement.Persistance;
using BookstoreManagement.UnitTests.Common;
using Shouldly;

namespace BookstoreManagement.UnitTests.Order.Queries.GetOrderDetail;

[Collection("QueryCollection")]
public class GetOrderDetailQueryHandlerTests
{
    private readonly BookstoreDbContext _context;
    private readonly IMapper _mapper;

    public GetOrderDetailQueryHandlerTests(QueryTestFixtures fixtures)
    {
        _context = fixtures.Context;
        _mapper = fixtures.Mapper;
    }

    [Fact]
    public async Task CanGetOrderDetailById()
    {
        var handler = new GetOrderDetailQueryHandler(_context, _mapper);
        var orderId = 3;
        
        var result = await handler.Handle(new GetOrderDetailQuery() { OrderId = orderId }, CancellationToken.None);

        result.ShouldBeOfType<OrderDetailVm>();
        result.CustomerName.ShouldBe("Piotr");
        result.CustomerSurname.ShouldBe("Customer");
        result.ApartmentNumber.ShouldBe(222);
        result.City.ShouldBe("Piaseczno");
        result.Country.ShouldBe("Poland");
        result.HouseNumber.ShouldBe(222);
        result.StreetName.ShouldBe("Piaseczyńska");
        result.PostCode.ShouldBe("05-500");

        result.BookName.ShouldBe("Potop");
        result.BookPrice.ShouldBe(15);

        result.DayOfDelivery.ShouldBe(new DateTime(2022, 1, 15));
        result.DayOfOrder.ShouldBe(new DateTime(2022, 1, 1));
        result.OrderPrice.ShouldBe(111);
        result.OrderQuantity.ShouldBe(3);
    }
}