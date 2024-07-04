using Microsoft.EntityFrameworkCore;
using Repositories.Contracts;
using Repositories.Core;

namespace WebAPI.Extensions
{
    public static class ServicesExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services,
            IConfiguration configuration) =>
            services.AddDbContext<RepositoryContext>(options =>
            options.UseSqlServer(
                configuration.GetConnectionString("sqlConnection"),
                b => b.MigrationsAssembly("WebAPI"))); // Migrations Assembly'ini belirtiyoruz

        public static void ConfigureRepositoryManager(this IServiceCollection services)
            => services.AddScoped<IRepositoryManager, RepositoryManager>();
    }
}
