using System;

namespace DomainDriven.CleanArchitecture.Application
{
    public class UseCaseFactory : IUseCaseFactory
    {

        public readonly IServiceProvider _serviceProvider;

        public UseCaseFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        IUseCase<TReq, TRes> IUseCaseFactory.GetUseCase<TReq, TRes>()
        {
            return (IUseCase<TReq, TRes>)_serviceProvider.GetService(typeof(IUseCase<TReq, TRes>));
        }
    }
}
