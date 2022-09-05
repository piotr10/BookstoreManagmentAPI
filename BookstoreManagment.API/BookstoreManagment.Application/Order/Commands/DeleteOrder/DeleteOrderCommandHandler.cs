using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Application.Customer.Commands.DeleteCustomer;
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
        var order = await _bookstoreDbContext.Orders
            .Where(x => x.Id == request.OrderId && x.StatusId == 1)
            .FirstOrDefaultAsync(cancellationToken);

        _bookstoreDbContext.Orders.Remove(order);
        await _bookstoreDbContext.SaveChangesAsync(cancellationToken);

        return Unit.Value;
    }
}