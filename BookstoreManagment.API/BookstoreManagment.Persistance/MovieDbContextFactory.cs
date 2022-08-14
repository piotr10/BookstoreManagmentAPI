using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Persistance;

public class MovieDbContextFactory : DesignTimeDbContextFactoryBase<BookstoreDbContext>
{
    protected override BookstoreDbContext CreateNewInstance(DbContextOptions<BookstoreDbContext> options)
    {
        return new BookstoreDbContext(options);
    }
}