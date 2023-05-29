using EnterWellTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EnterWellTest.Infrastructure.Persistence.Configurations
{
    public class InvoiceItemConfiguration : IEntityTypeConfiguration<InvoiceItem>
    {
        public void Configure(EntityTypeBuilder<InvoiceItem> builder)
        {
            builder
                .HasOne(p => p.Invoice)
                .WithMany(p => p.InvoiceItems)
                .HasForeignKey(p => p.InvoiceId);
        }
    }
}
