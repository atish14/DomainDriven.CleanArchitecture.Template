using Microsoft.Extensions.DependencyInjection;
using DomainDriven.CleanArchitecture.Application;
using DomainDriven.CleanArchitecture.Persistence.InMemory.Repositories;

namespace DomainDriven.CleanArchitecture.Persistence.InMemory
{
    public static class ServiceCollectionExtensions
    {

        public static void AddRepositoryServices(this IServiceCollection services)
        {
            services.AddTransient<IProductRepository, ProductRepository>();
        }
    }
}
