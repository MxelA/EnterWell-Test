using EnterWellTest.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace EnterWellTest.Infrastructure.Persistence
{
    public class EnterWellTestDbContext
        : IdentityDbContext<User, Role, int, UserClaim, UserRole, UserLogin, RoleClaim, UserToken>,
          IEnterWellTestDbContext
    {
        public virtual DbSet<Role> Role => Set<Role>();
        public virtual DbSet<RoleClaim> RoleClaim => Set<RoleClaim>();
        public virtual DbSet<UserRole> UserRole => Set<UserRole>();
        public virtual DbSet<User> User => Set<User>();
        public virtual DbSet<Invoice> Invoices => Set<Invoice>();
        public virtual DbSet<InvoiceItem> InvoiceItems => Set<InvoiceItem>();

        public EnterWellTestDbContext(DbContextOptions<EnterWellTestDbContext> options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
