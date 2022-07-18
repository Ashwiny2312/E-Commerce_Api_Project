using AutoMapper;
using ECommerceApi.Application.CQRS.Product.Queries.Request;
using ECommerceApi.Application.CQRS.Product.Queries.Response;
using ECommerceApi.Application.RepositoriesInterface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.CQRS.Product.Handlers.Queries
{

    public class GetAllQueryHandler : IRequestHandler<List<GetAllProductQueryRequest, GetAllProductQueryResponse>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetAllQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }


        public async Task<GetAllProductQueryResponse> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {

            var model = _mapper.Map<ECommerceApi.Domain.Entities.Product>(request);

            await _productRepository.Create(model);

            return new GetAllProductQueryResponse
            {
                IsSuccess = true,
                ProductId = model.Id
            };
        }
    }
}
