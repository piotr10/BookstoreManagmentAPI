using AutoMapper;
using BookstoreManagement.Application.Order.Queries.GetAllOrders;
using BookstoreManagement.Persistance;
using BookstoreManagement.UnitTests.Common;
using Shouldly;

namespace BookstoreManagement.UnitTests.Order.Queries.GetOrders;

[Collection("QueryCollection")]
public class GetOrdersQueryHandlerTests
{
    private readonly BookstoreDbContext _context;
    private readonly IMapper _mapper;

    public GetOrdersQueryHandlerTests(QueryTestFixtures fixtures)
    {
        _context = fixtures.Context;
        _mapper = fixtures.Mapper;
    }

    [Fact]
    public async Task CanGetOrders()
    {
        var handler = new GetOrdersQueryHandler(_context, _mapper);
        var result = await handler.Handle(new GetOrdersQuery(), CancellationToken.None);

        result.ShouldBeOfType<OrdersVm>();
        result.Orders.Count.ShouldBe(3);
    }
}