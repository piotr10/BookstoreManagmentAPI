using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Entities.Book;
using BookstoreManagement.Domain.Entities.Customer;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Order.Queries.GetOrderDetail;

public class GetOrderDetailQueryHandler : IRequestHandler<GetOrderDetailQuery, OrderDetailVm>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;

    public GetOrderDetailQueryHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
    }

    public async Task<OrderDetailVm> Handle(GetOrderDetailQuery request, CancellationToken cancellationToken)
    {
        var order = await _bookstoreDbContext.Orders
            .Include(p => p.OrderTransportType)
            .Include(p => p.PaymentMethod)
            .Include(p => p.Customer)
            .ThenInclude(p=>p.CustomerDetails)
            .Include(p => p.Book)
            .ThenInclude(p=>p.BookDetails)
            .Where(p => p.Id == request.OrderId)
            .FirstOrDefaultAsync(cancellationToken);
       
        var book = new BookDetail();

        book = await _bookstoreDbContext.BookDetails
            .Where(p => p.Id == request.BookDetailId)
            .FirstOrDefaultAsync(cancellationToken);

        var customer = new CustomerDetail();

        customer = await _bookstoreDbContext.CustomerDetails
            .Where(p => p.Id == request.CustomerDetailId)
            .FirstOrDefaultAsync(cancellationToken);

        var orderVm = _mapper.Map<OrderDetailVm>(order);
        orderVm.BookName = book.Name;
        orderVm.BookPrice = book.Price;
        orderVm.CustomerName = customer.FirstName;
        orderVm.CustomerSurname = customer.LastName;

        return orderVm;
    }
}