using AutoMapper;
using AutoMapper.QueryableExtensions;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Customer.Queries.GetAllCustomers;

public class GetCustomersQueryHandler : IRequestHandler<GetCustomersQuery, CustomersVm>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;

    public GetCustomersQueryHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
    }
    public async Task<CustomersVm> Handle(GetCustomersQuery request, CancellationToken cancellationToken)
    {
        try
        {
            var customers = await _bookstoreDbContext.Customers.Where(x => x.StatusId == 1)
                .AsNoTracking().ProjectTo<CutomerDto>(_mapper.ConfigurationProvider).ToListAsync(cancellationToken);
            if (customers == null)
            {
                throw new ThisObjectNotExistInDbException("Customers");
            }

            return new CustomersVm() { Cutomers = customers };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}