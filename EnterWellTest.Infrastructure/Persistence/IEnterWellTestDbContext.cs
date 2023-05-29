using EnterWellTest.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnterWellTest.Infrastructure.Persistence
{
    public interface IEnterWellTestDbContext
    {
        DbSet<Invoice> Invoices => Invoices;
        DbSet<InvoiceItem> InvoiceItems => InvoiceItems;
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
