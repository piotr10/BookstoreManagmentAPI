using BookstoreManagement.Domain.Entities.Order;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookstoreManagement.Persistance.Configuration;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.Property(p => p.OrderPrice).HasColumnType("decimal(18,4)");
        builder.Property(p => p.BookPrice).HasColumnType("decimal(18,4)");
        builder.Property(p => p.DeliveryDate).IsRequired();
        builder.Property(p => p.OrderDate).IsRequired();
        builder.Property(p => p.Quantity).IsRequired();
    }
}