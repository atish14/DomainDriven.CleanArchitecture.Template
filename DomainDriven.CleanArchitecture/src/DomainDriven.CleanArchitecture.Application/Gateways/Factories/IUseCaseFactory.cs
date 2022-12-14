namespace DomainDriven.CleanArchitecture.Application
{
    public interface IUseCaseFactory
    {
        IUseCase<TReq, TRes> GetUseCase<TReq, TRes>() where TReq : BaseUseCaseRequest where TRes : BaseUseCaseResponse;
    }
}
