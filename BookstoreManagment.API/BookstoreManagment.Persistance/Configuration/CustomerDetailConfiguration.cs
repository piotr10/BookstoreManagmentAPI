using BookstoreManagement.Domain.Entities.Customer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreManagement.Persistance.Configuration;

public class CustomerDetailConfiguration : IEntityTypeConfiguration<CustomerDetail>
{
    public void Configure(EntityTypeBuilder<CustomerDetail> builder)
    {
        builder.Property(p => p.FirstName).HasMaxLength(50).IsRequired();
        builder.Property(p => p.LastName).HasMaxLength(50).IsRequired();

        builder.OwnsOne(p => p.Adres)
            .Property(p => p.ApartmentNumber)
            .HasColumnName("ApartmentNumber");
        builder.OwnsOne(p => p.Adres)
            .Property(p => p.City)
            .HasColumnName("City");
        builder.OwnsOne(p => p.Adres)
            .Property(p => p.Country)
            .HasColumnName("Country");
        builder.OwnsOne(p => p.Adres)
            .Property(p => p.HouseNumber)
            .HasColumnName("HouseNumber");
        builder.OwnsOne(p => p.Adres)
            .Property(p => p.Street)
            .HasColumnName("Street");
        builder.OwnsOne(p => p.Adres)
            .Property(p => p.ZipCode)
            .HasColumnName("ZipCode");
    }
}