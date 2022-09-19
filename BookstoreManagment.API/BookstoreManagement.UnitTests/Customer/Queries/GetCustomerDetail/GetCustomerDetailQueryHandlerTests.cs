using AutoMapper;
using BookstoreManagement.Application.Customer.Queries.GetCustomerDetail;
using BookstoreManagement.Persistance;
using BookstoreManagement.UnitTests.Common;
using Shouldly;

namespace BookstoreManagement.UnitTests.Customer.Queries.GetCustomerDetail;

[Collection("QueryCollection")]
public class GetCustomerDetailQueryHandlerTests
{
    private readonly BookstoreDbContext _context;
    private readonly IMapper _mapper;

    public GetCustomerDetailQueryHandlerTests(QueryTestFixtures fixtures)
    {
        _context = fixtures.Context;
        _mapper = fixtures.Mapper;
    }

    [Fact]
    public async Task CanGetCustomerDetailById()
    {
        var handler = new GetCustomerDetailQueryHandler(_context, _mapper);
        var customerId = 3;
        
        var result = await handler.Handle(new GetCustomerDetailQuery() { CustomerDetailId = customerId }, CancellationToken.None);

        result.ShouldBeOfType<CustomerDetailVm>();
        result.Name.ShouldBe("Piotr");
        result.Surname.ShouldBe("Customer");
        result.ApartmentNumber.ShouldBe(222);
        result.City.ShouldBe("Piaseczno");
        result.Country.ShouldBe("Poland");
        result.HouseNumber.ShouldBe(222);
        result.StreetName.ShouldBe("Piaseczyńska");
        result.PostCode.ShouldBe("05-500");
        result.AddressTypeName.ShouldBe("Private address");
        result.ContactName.ShouldBe("pczerskiCustomer@example.com");
        result.DetailType.ShouldNotBeNull();
    }
}