using AutoMapper;
using DomainDriven.CleanArchitecture.Application;
using DomainDriven.CleanArchitecture.Contracts.v1;
using DomainDriven.CleanArchitecture.Domain;

namespace DomainDriven.CleanArchitecture.WebApi.Translator
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<AddProductRequest, AddProductRequestModel>();
            CreateMap<Product, AddProductRequestModel>();
            CreateMap<AddProductResponseModel, AddProductResponse>()
                    .ForMember(dest => dest.ExpiryInMonths, src => src.MapFrom(x => x.Product.ExpiryInMonths))
                    .ForMember(dest => dest.ManufacturingDate, src => src.MapFrom(x => x.Product.ManufacturingDate))
                    .ForMember(dest => dest.ProductId, src => src.MapFrom(x => x.Product.ProductId))
                    .ForMember(dest => dest.ProductName, src => src.MapFrom(x => x.Product.ProductName))
                    .ForMember(dest => dest.ProductCode, src => src.MapFrom(x => x.Product.ProductKey.ProductCode))
                    .ForMember(dest => dest.ProductType, src => src.MapFrom(x => x.Product.ProductKey.ProductType))
                    .ForMember(dest => dest.StockQuantity, src => src.MapFrom(x => x.Product.StockQuantity))
                    ;
        }
    }
}