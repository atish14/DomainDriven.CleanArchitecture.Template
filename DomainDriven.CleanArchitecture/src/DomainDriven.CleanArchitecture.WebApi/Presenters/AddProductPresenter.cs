using System;
using System.Linq;
using AutoMapper;
using DomainDriven.CleanArchitecture.Application;
using DomainDriven.CleanArchitecture.Contracts.v1;

namespace DomainDriven.CleanArchitecture.WebApi.Presenters
{
    public class AddProductPresenter : IAddProductPresenter
    {
        private readonly IMapper _mapper;

        public AddProductPresenter(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        public AddProductResponse Execute(AddProductResponseModel responseMessage)
        {
            var addProductResponse = _mapper.Map<AddProductResponse>(responseMessage);

            if (responseMessage.Errors.Any())
            {
                addProductResponse.Errors.AddRange(responseMessage.Errors);
            }
            return addProductResponse;
        }
    }
}
