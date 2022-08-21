﻿using MediatR;

namespace BookstoreManagement.Application.Customer.Queries.GetCustomerDetail;

public class GetCustomerDetailQuery : IRequest<CustomerDetailVm>
{
    public int CustomerId { get; set; }
}