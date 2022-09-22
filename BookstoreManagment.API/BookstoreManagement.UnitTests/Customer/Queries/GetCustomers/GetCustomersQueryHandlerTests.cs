using AutoMapper;
using BookstoreManagement.Application.Customer.Queries.GetAllCustomers;
using BookstoreManagement.Persistance;
using BookstoreManagement.UnitTests.Common;
using Shouldly;

namespace BookstoreManagement.UnitTests.Customer.Queries.GetCustomers;

[Collection("QueryCollection")]
public class GetCustomersQueryHandlerTests
{
    private readonly BookstoreDbContext _context;
    private readonly IMapper _mapper;

    public GetCustomersQueryHandlerTests(QueryTestFixtures fixtures)
    {
        _context = fixtures.Context;
        _mapper = fixtures.Mapper;
    }

    [Fact]
    public async Task CanGetCustomers()
    {
        var handler = new GetCustomersQueryHandler(_context, _mapper);
        var result = await handler.Handle(new GetCustomersQuery(), CancellationToken.None);

        result.ShouldBeOfType<CustomersVm>();
        result.Cutomers.Count.ShouldBe(3);
    }
}