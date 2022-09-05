﻿using AutoMapper;
using BookstoreManagement.Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Book.Queries.GetBookDetail;

public class GetBookQueryHandler : IRequestHandler<GetBookQuery, BookVm>
{
    private readonly IBookstoreDbContext _bookstoreDbContext;
    private readonly IMapper _mapper;

    public GetBookQueryHandler(IBookstoreDbContext bookstoreDbContext, IMapper mapper)
    {
        _bookstoreDbContext = bookstoreDbContext;
        _mapper = mapper;
    }

    public async Task<BookVm> Handle(GetBookQuery request, CancellationToken cancellationToken)
    {
        var book = await _bookstoreDbContext.Books
            .Include(p=>p.Author)
            .Include(p=>p.Genre)
            .Where(p => p.Id == request.BookId)
            .FirstOrDefaultAsync(cancellationToken);

        var bookVm = _mapper.Map<BookVm>(book);
        return bookVm;
    }
}