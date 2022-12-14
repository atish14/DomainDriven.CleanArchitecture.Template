namespace DomainDriven.CleanArchitecture.Application
{
    public interface IUseCase<TUseCaseRequest, TUseCaseResponse> where TUseCaseRequest : BaseUseCaseRequest where TUseCaseResponse : BaseUseCaseResponse
    {
        TUseCaseResponse Execute(TUseCaseRequest baseUseCaseRequest);
    }
}
