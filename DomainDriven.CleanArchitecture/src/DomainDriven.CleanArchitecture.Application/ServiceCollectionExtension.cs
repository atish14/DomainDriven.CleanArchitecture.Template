using Microsoft.Extensions.DependencyInjection;

namespace DomainDriven.CleanArchitecture.Application
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplicationServices(this IServiceCollection service)
        {
            service.AddSingleton<IUseCaseFactory, UseCaseFactory>();
            service.AddTransient<IUseCase<AddProductRequestModel, AddProductResponseModel>, AddProductInteractor>();
            service.AddTransient<IUseCase<AddToCartRequestModel, AddToCartResponseModel>, AddToCartInteractor>();
        }
    }
}
