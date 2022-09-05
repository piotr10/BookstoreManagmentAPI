using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Entities.Customer;
using BookstoreManagement.Domain.ValueObjects;
using MediatR;

namespace BookstoreManagement.Application.Customer.Commands.CreateCustomer;

public class CreateCustomerCommandHandler :IRequestHandler<CreateCustomerCommand, int>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;

    public CreateCustomerCommandHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
    }
    public async Task<int> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
    {
        Domain.Entities.Customer.Customer customer = new Domain.Entities.Customer.Customer();
        _bookstoreDbContext.Customers.Add(customer);
        await _bookstoreDbContext.SaveChangesAsync(cancellationToken);

        var customerId = await _bookstoreDbContext.Customers.FindAsync(request.CustomerId);

        CustomerDetail customerDetail = new CustomerDetail()
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            CustomerDetailTypeId = request.CustomerDetailTypeId,
            CustomerAddressTypeId = request.CustomerAddressTypeId,
            Customer = customerId,

            Adres = new Adres()
            {
                ApartmentNumber = request.ApartmentNumber,
                City = request.City,
                Country = request.Country,
                HouseNumber = request.HouseNumber,
                Street = request.Street,
                ZipCode = request.ZipCode
            }
        };
        _bookstoreDbContext.CustomerDetails.Add(customerDetail);

        CustomerContactDetail contactDetail = new CustomerContactDetail()
        {
            ContactName = request.DetailContact,
            CustomerContactDetailTypeId = request.CustomerContactDetailTypeId,
            Customer = customerId
        };
        _bookstoreDbContext.CustomerContactDetails.Add(contactDetail);

        await _bookstoreDbContext.SaveChangesAsync(cancellationToken);
        return customer.Id;
    }
}