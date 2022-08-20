using BookstoreManagement.Domain.Entities.Customer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreManagement.Persistance.Configuration;

public class CustomerAddressConfiguration : IEntityTypeConfiguration<CustomerAddress>
{
    public void Configure(EntityTypeBuilder<CustomerAddress> builder)
    {
        builder.Property(p => p.ApartmentNumber).HasMaxLength(15);
        builder.Property(p => p.City).HasMaxLength(80);
        builder.Property(p => p.Country).HasMaxLength(80);
        builder.Property(p => p.HouseNumber).HasMaxLength(15);
        builder.Property(p => p.Street).HasMaxLength(60);
        builder.Property(p => p.ZipCode).HasMaxLength(25);
    }
}