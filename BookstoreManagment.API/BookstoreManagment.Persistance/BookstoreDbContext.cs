using Microsoft.EntityFrameworkCore;

namespace BookstoreManagement.Persistance;

public class BookstoreDbContext : DbContext
{
    public BookstoreDbContext(DbContextOptions<BookstoreDbContext> options) : base(options)
    {
        
    }
}