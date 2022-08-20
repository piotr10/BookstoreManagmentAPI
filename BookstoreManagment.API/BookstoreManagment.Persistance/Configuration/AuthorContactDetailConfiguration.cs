using BookstoreManagement.Domain.Entities.Author;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreManagement.Persistance.Configuration;

public class AuthorContactDetailConfiguration : IEntityTypeConfiguration<AuthorContactDetail>
{
    public void Configure(EntityTypeBuilder<AuthorContactDetail> builder)
    {
        builder.Property(p => p.Name).HasMaxLength(100);
    }
}