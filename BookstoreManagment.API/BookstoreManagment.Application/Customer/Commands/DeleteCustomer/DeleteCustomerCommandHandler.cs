using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
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
        var customer = await _bookstoreDbContext.Customers
            .Where(x => x.Id == request.CustomerId && x.StatusId == 1)
            .FirstOrDefaultAsync(cancellationToken);

        _bookstoreDbContext.Customers.Remove(customer);
        await _bookstoreDbContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}