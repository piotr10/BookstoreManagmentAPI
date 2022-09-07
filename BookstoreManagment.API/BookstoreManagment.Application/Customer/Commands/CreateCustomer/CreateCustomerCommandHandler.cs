using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Entities.Customer;
using BookstoreManagement.Domain.Exceptions;
using BookstoreManagement.Domain.ValueObjects;
using MediatR;
using Microsoft.EntityFrameworkCore;

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
        try
        {
            Domain.Entities.Customer.Customer customer = new Domain.Entities.Customer.Customer();
            await _bookstoreDbContext.Customers.AddAsync(customer, cancellationToken);
            try
            {
                await _bookstoreDbContext.SaveChangesAsync(cancellationToken);
            }
            catch (Exception e)
            {
                throw new DbUpdateException("Saving to database error!");
            }

            var customerId = await _bookstoreDbContext.Customers.FindAsync(request.CustomerId);
            if (customerId == null)
            {
                throw new ObjectNotExistInDbException(request.CustomerId, "Customer");
            }

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
            await _bookstoreDbContext.CustomerDetails.AddAsync(customerDetail, cancellationToken);

            CustomerContactDetail contactDetail = new CustomerContactDetail()
            {
                ContactName = request.DetailContact,
                CustomerContactDetailTypeId = request.CustomerContactDetailTypeId,
                Customer = customerId
            };
            await _bookstoreDbContext.CustomerContactDetails.AddAsync(contactDetail, cancellationToken);

            try
            {
                await _bookstoreDbContext.SaveChangesAsync(cancellationToken);
            }
            catch (Exception e)
            {
                throw new DbUpdateException("Saving to database error!");
            }

            return customer.Id;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}