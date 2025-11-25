using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentService.Domain.Entities;

namespace PaymentService.Infrastructure.Persistence.Configurations;

public class PaymentFailureConfiguration : IEntityTypeConfiguration<PaymentFailure>
{
    public void Configure(EntityTypeBuilder<PaymentFailure> builder)
    {
        builder.ToTable("payment_failures");
        
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).HasColumnName("id");
        builder.Property(x => x.PaymentId).HasColumnName("payment_id");
        builder.Property(x => x.Reason).HasColumnName("reason");
        builder.Property(x => x.CreatedAt).HasColumnName("created_at");
    }
}