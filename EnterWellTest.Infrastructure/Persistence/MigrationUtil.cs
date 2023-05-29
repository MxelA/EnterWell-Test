using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace EnterWellTest.Infrastructure.Persistence
{
    public class MigrationUtil
    {
        public static void MigrateDatabase(IServiceProvider serviceProvider)
        {
            using var scope = serviceProvider.CreateScope();
            var context = scope.ServiceProvider.GetRequiredService<EnterWellTestDbContext>();
            context.Database.Migrate();
        }
    }
}
