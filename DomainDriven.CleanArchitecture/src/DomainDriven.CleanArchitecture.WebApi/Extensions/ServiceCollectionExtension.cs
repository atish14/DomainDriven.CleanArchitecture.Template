using System;
using AutoMapper;
using DomainDriven.CleanArchitecture.WebApi.Presenters;
using DomainDriven.CleanArchitecture.WebApi.Translator;
using Microsoft.Extensions.DependencyInjection;

namespace DomainDriven.CleanArchitecture.WebApi.Extensions
{
    public static class ServiceCollectionExtension
    {

        public static void AddApiServices(this IServiceCollection services)
        {
            services.AddTransient<IAddProductPresenter, AddProductPresenter>();
            //services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            var config = new MapperConfiguration(c => {
                c.AddProfile<MapperProfile>();

            });
            services.AddSingleton<IMapper>(s => config.CreateMapper());
        }

    }
}
