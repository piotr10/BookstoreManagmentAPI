using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Customer.Commands.DeleteCustomer;

public class DeleteCustomerCommandHandler : IRequestHandler<DeleteCustomerCommand>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;

    public DeleteCustomerCommandHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var customer = await _bookstoreDbContext.Customers
                .Where(x => x.Id == request.CustomerId && x.StatusId == 1)
                .FirstOrDefaultAsync(cancellationToken);
            if (customer == null)
            {
                throw new ObjectNotExistInDbException(request.CustomerId, "Customer");
            }
            _bookstoreDbContext.Customers.Remove(customer);

            var customerDetail = await _bookstoreDbContext.CustomerDetails
                .Where(x => x.CustomerId == request.CustomerId && x.StatusId == 1)
                .FirstOrDefaultAsync(cancellationToken);
            if (customerDetail == null)
            {
                throw new ObjectNotExistInDbException(request.CustomerId, "Customer Detail");
            }
            _bookstoreDbContext.CustomerDetails.Remove(customerDetail);

            try
            {
                await _bookstoreDbContext.SaveChangesAsync(cancellationToken);
            }
            catch (Exception e)
            {
                throw new DbUpdateException("Saving to database error!");
            }

            return Unit.Value;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}