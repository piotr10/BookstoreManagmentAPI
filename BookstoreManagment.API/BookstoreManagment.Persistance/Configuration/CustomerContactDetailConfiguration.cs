using BookstoreManagement.Domain.Entities.Customer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreManagement.Persistance.Configuration;

public class CustomerContactDetailConfiguration : IEntityTypeConfiguration<CustomerContactDetail>
{
    public void Configure(EntityTypeBuilder<CustomerContactDetail> builder)
    {
        builder.Property(p => p.ContactName).HasMaxLength(80).IsRequired();
    }
}