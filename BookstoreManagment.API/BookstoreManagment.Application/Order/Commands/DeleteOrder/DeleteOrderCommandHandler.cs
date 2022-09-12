using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Application.Customer.Commands.DeleteCustomer;
using BookstoreManagement.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Order.Commands.DeleteOrder;

public class DeleteOrderCommandHandler : IRequestHandler<DeleteOrderCommand>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;

    public DeleteOrderCommandHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
    }

    public async Task<Unit> Handle(DeleteOrderCommand request, CancellationToken cancellationToken)
    {
        try
        {
            var order = await _bookstoreDbContext.Orders
                .Where(x => x.Id == request.OrderId && x.StatusId == 1)
                .FirstOrDefaultAsync(cancellationToken);
            if (order == null)
            {
                throw new ObjectNotExistInDbException(request.OrderId, "Order");
            }
            _bookstoreDbContext.Orders.Remove(order);

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