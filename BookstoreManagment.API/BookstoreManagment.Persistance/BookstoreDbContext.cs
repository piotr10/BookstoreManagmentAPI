using System.Reflection;
using BookstoreManagement.Application.Common.Interfaces;
using BookstoreManagement.Domain.Common;
using BookstoreManagement.Domain.Entities.Author;
using BookstoreManagement.Domain.Entities.Book;
using BookstoreManagement.Domain.Entities.Customer;
using BookstoreManagement.Domain.Entities.Order;
using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Persistance;

public class BookstoreDbContext : DbContext, IBookstoreDbContext
{
    private readonly IDateTime _dateTime;

    public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options) : base(options)
    {
        
    }

    public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options, IDateTime dateTime) : base(options)
    {
        _dateTime = dateTime;
    }

    public DbSet<Author> Authors { get; set; }
    public DbSet<AuthorBiography> AuthorBiographies { get; set; }
    public DbSet<AuthorContactDetail> AuthorContactDetails { get; set; }
    public DbSet<AuthorContactDetailType> AuthorContactDetailTypes { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<Genre> Genres { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<CustomerAddressType> CustomerAddressTypes { get; set; }
    public DbSet<CustomerContactDetail> CustomerContactDetails { get; set; }
    public DbSet<CustomerContactDetailType> CustomerContactDetailTypes { get; set; }
    public DbSet<CustomerDetail> CustomerDetails { get; set; }
    public DbSet<CustomerDetailType> CustomerDetailTypes { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderTransportType> OrderTransportTypes { get; set; }
    public DbSet<PaymentMethod> PaymentMethods { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        modelBuilder.SeedData();
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
    {
        foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
        {
            switch (entry.State)
            {
                case EntityState.Deleted:
                    entry.Entity.ModifiedBy = string.Empty;
                    entry.Entity.Modified = _dateTime.Now;
                    entry.Entity.Inactivated = _dateTime.Now;
                    entry.Entity.InactivatedBy = string.Empty;
                    entry.Entity.StatusId = 0;
                    entry.State = EntityState.Modified;
                    break;
                case EntityState.Modified:
                    entry.Entity.ModifiedBy = string.Empty;
                    entry.Entity.Modified = _dateTime.Now;
                    break;
                case EntityState.Added:
                    entry.Entity.ModifiedBy = string.Empty;
                    entry.Entity.Modified = null;
                    entry.Entity.Inactivated = null;
                    entry.Entity.InactivatedBy = string.Empty;

                    entry.Entity.CreatedBy = string.Empty;
                    entry.Entity.Created = _dateTime.Now;
                    entry.Entity.StatusId = 1;
                    break;
                default:
                    break;
            }
        }

        foreach (var entry in ChangeTracker.Entries<ValueObject>())
        {
            switch (entry.State)
            {
                case EntityState.Deleted:
                    entry.State = EntityState.Modified;
                    break;
                default:
                    break;
            }
        }
        return base.SaveChangesAsync(cancellationToken);
    }
}