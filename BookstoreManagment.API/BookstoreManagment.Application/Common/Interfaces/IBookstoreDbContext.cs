using BookstoreManagement.Domain.Entities.Author;
using BookstoreManagement.Domain.Entities.Book;
using BookstoreManagement.Domain.Entities.Customer;
using BookstoreManagement.Domain.Entities.Order;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Application.Common.Interfaces;

public interface IBookstoreDbContext
{
    DbSet<Domain.Entities.Author.Author> Authors { get; set; }
    DbSet<AuthorBiography> AuthorBiographies { get; set; }
    DbSet<AuthorContactDetail> AuthorContactDetails { get; set; }
    DbSet<AuthorContactDetailType> AuthorContactDetailTypes { get; set; }
    DbSet<Domain.Entities.Book.Book> Books { get; set; }
    DbSet<Genre> Genres { get; set; }
    DbSet<Domain.Entities.Customer.Customer> Customers { get; set; }
    DbSet<CustomerAddressType> CustomerAddressTypes { get; set; }
    DbSet<CustomerDetail> CustomerDetails { get; set; }
    DbSet<CustomerDetailType> CustomerDetailTypes { get; set; }
    DbSet<Domain.Entities.Order.Order> Orders { get; set; }
    DbSet<OrderTransportType> OrderTransportTypes { get; set; }
    DbSet<PaymentMethod> PaymentMethods { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}