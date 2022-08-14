using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Persistance;

public class BookstoreDbContextFactory : DesignTimeDbContextFactoryBase<BookstoreDbContext>
{
    protected override BookstoreDbContext CreateNewInstance(DbContextOptions<BookstoreDbContext> options)
    {
        return new BookstoreDbContext(options);
    }
}