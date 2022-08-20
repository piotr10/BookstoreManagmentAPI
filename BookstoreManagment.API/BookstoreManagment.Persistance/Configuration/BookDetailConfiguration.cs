using BookstoreManagement.Domain.Entities.Book;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreManagement.Persistance.Configuration;

public class BookDetailConfiguration : IEntityTypeConfiguration<BookDetail>
{
    public void Configure(EntityTypeBuilder<BookDetail> builder)
    {
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.Price).HasColumnType("decimal(18,4)").IsRequired();
    }
}