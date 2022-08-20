using BookstoreManagement.Domain.Entities.Author;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreManagement.Persistance.Configuration;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.OwnsOne(p => p.AuthorName)
            .Property(p => p.FirstName)
            .HasColumnName("FirstName");

        builder.OwnsOne(p => p.AuthorName)
            .Property(p => p.LastName)
            .HasColumnName("LastName");
    }
}