using AutoMapper;
using ECommerceApi.Application.CQRS.Product_Rating.Commands.Request;
using ECommerceApi.Application.CQRS.Product_Rating.Commands.Response;
using ECommerceApi.Application.RepositoriesInterface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.CQRS.Product_Rating.Handlers.Commands
{

    public class CreateProductRatingCommandHandler : IRequestHandler<CreateProductRatingCommandRequest, CreateProductRatingCommandResponse>
    {
        private readonly IProductRatingRepository _productRatingRepository;
        private readonly IMapper _mapper;

        public CreateProductRatingCommandHandler(IProductRatingRepository productRatingRepository, IMapper mapper)
        {
            _productRatingRepository = productRatingRepository;
            _mapper = mapper;
        }


        public async Task<CreateProductRatingCommandResponse> Handle(CreateProductRatingCommandRequest request, CancellationToken cancellationToken)
        {

            var model = _mapper.Map<ECommerceApi.Domain.Entities.Product_Rating>(request);

            await _productRatingRepository.Create(model);

            return new CreateProductRatingCommandResponse
            {
                IsSuccess = true,
                ProductId= model.Product_Id,
                UserId = model.User_Id
            };
        }
    }
}
