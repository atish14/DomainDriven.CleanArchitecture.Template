using DomainDriven.CleanArchitecture.Application;
using DomainDriven.CleanArchitecture.Contracts.v1;

namespace DomainDriven.CleanArchitecture.WebApi.Presenters
{
    public interface IAddProductPresenter
    {
        AddProductResponse Execute(AddProductResponseModel responseMessage);
    }
}
