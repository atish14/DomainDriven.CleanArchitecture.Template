using DomainDriven.CleanArchitecture.Domain;

namespace DomainDriven.CleanArchitecture.Application
{
    public class AddProductResponseModel : BaseUseCaseResponse
    {
        public Product Product { get; set; }

    }
}
