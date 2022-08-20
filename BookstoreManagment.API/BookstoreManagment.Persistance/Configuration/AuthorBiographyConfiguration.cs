using BookstoreManagement.Domain.Entities.Author;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreManagement.Persistance.Configuration;

public class AuthorBiographyConfiguration : IEntityTypeConfiguration<AuthorBiography>
{
    public void Configure(EntityTypeBuilder<AuthorBiography> builder)
    {
        builder.Property(p => p.Country).HasMaxLength(80);
        builder.Property(p => p.PlaceOfBirth).HasMaxLength(100);
    }
}