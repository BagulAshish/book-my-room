using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentService.Domain.Entities;

namespace PaymentService.Infrastructure.Persistence.Configurations;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.ToTable("payments");
        
        builder.HasKey(x => x.Id);
        
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.BookingGroupId).HasColumnName("booking_group_id");
        builder.Property(x => x.CustomerId).HasColumnName("customer_id");
        builder.Property(x => x.Amount).HasColumnName("amount");
        builder.Property(x => x.PaymentMethod).HasColumnName("payment_method");
        builder.Property(x => x.Provider).HasColumnName("provider");
        builder.Property(x => x.ProviderReferenceId).HasColumnName("provider_reference_id");
        builder.Property(x => x.PaymentStatus).HasColumnName("payment_status");
        builder.Property(x => x.CreatedAt).HasColumnName("created_at");
        builder.Property(x => x.UpdatedAt).HasColumnName("updated_at");
        
        builder.HasOne(x => x.PaymentFailure).WithOne(x => x.Payment).HasForeignKey<PaymentFailure>(x => x.PaymentId);
    }
}