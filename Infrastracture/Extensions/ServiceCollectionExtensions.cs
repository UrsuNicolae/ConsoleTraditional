using Application.Repos;
using Infrastracture.Repos;
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
    }
}
