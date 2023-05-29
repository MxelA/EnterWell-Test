using EnterWellTest.Domain.Entities;
using EnterWellTest.Infrastructure.Persistence;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EnterWellTest.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services,
            IConfiguration configuration
        )
        {
            RegisterPersistence(services, configuration);
            ConfigureIdentity(services);

            return services;
        }

        private static void ConfigureIdentity(IServiceCollection services)
        {
            services
                .AddIdentityCore<User>(
                    options =>
                    {
                        options.SignIn.RequireConfirmedAccount = true;
                        options.Password.RequireDigit = false;
                        options.Password.RequiredLength = 6;
                        options.Password.RequireNonAlphanumeric = false;
                        options.Password.RequireUppercase = false;
                        options.Password.RequireLowercase = false;
                    }
                )
                .AddEntityFrameworkStores<EnterWellTestDbContext>();
        }
        private static void RegisterPersistence(
            IServiceCollection services,
            IConfiguration configuration
        )
        {
            var connectionString =
                configuration.GetConnectionString("Database")
                ?? throw new Exception("Connection string not found.");
            services.AddDbContext<EnterWellTestDbContext>(
                (sp, options) =>
                {
                    options.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();
                }
            );

            services.AddScoped<IEnterWellTestDbContext>(
                p => p.GetRequiredService<EnterWellTestDbContext>()
            );
        }
    }
}
