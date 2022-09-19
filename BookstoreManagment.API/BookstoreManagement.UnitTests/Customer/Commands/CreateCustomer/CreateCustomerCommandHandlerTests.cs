using BookstoreManagement.Application.Customer.Commands.CreateCustomer;
using BookstoreManagement.UnitTests.Common;
using Microsoft.EntityFrameworkCore;
using Shouldly;

namespace BookstoreManagement.UnitTests.Customer.Commands.CreateCustomer;

public class CreateCustomerCommandHandlerTests : CommandTestBase
{
    private readonly CreateCustomerCommandHandler _handler;

    public CreateCustomerCommandHandlerTests() : base()
    {
        _handler = new CreateCustomerCommandHandler(_context);
    }

    [Fact]
    public async Task Handle_GivenValidRequest_ShouldInsertCustomer()
    {
        var command = new CreateCustomerCommand()
        {
            CustomerId = 3,
            FirstName = "John",
            LastName = "Doe",
            CustomerDetailTypeId = 3,
            CustomerAddressTypeId = 3,
            ApartmentNumber = 111,
            City = "Big City Live",
            Country = "Sequaczu",
            HouseNumber = 222,
            Street = "One way ticket",
            ZipCode = "11-212",
            DetailContact = "0048111222333",
            CustomerContactDetailTypeId = 4
        };

        var result = await _handler.Handle(command, CancellationToken.None);

        var customer = await _context.Customers.FirstAsync(x => x.Id == result, CancellationToken.None);
        customer.ShouldNotBeNull();
    }
}