using BookstoreManagement.Domain.Entities.Book;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreManagement.Persistance.Configuration;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.Property(p => p.Name);
        builder.Property(p => p.Price).HasColumnType("decimal(18,4)").IsRequired();
    }
}