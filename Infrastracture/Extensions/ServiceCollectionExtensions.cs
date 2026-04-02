using Application.Repos;
using Infrastracture.Data;
using Infrastracture.Repos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastracture.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepos(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            return services;
        }

        public static IServiceCollection AddDbContext(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlite("Data Source=C:\\Users\\NURSU\\test.db;");
            });
            return services;
        }
    }
}
