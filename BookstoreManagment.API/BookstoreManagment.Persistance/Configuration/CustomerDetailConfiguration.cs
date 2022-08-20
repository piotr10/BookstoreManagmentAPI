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
    }
}