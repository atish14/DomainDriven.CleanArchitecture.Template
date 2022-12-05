using DomainDriven.CleanArchitecture.Domain;

namespace DomainDriven.CleanArchitecture.Application
{
    public interface IProductRepository
    {
        Product AddProduct(Product product);
        Product GetProduct(string productType, string productCode);
        bool UpdateProductQuantity(string productType, string productCode, int quantity);
    }
}
