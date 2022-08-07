using AutoMapper;
using ECommerceApi.Application.CQRS.Product_Comment.Commands.Request;
using ECommerceApi.Application.CQRS.Product_Comment.Commands.Response;
using ECommerceApi.Application.RepositoriesInterface;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.CQRS.Product_Comment.Handlers.Commands
{

    public class UpdatePostCommentCommandHandler : IRequestHandler<UpdatePostCommentCommandRequest, UpdatePostCommentCommandResponse>
    {
        private readonly IProductCommentRepository _productCommentRepository;
        private readonly IMapper _mapper;

        public UpdatePostCommentCommandHandler(IProductCommentRepository productCommentRepository, IMapper mapper)
        {
            _productCommentRepository = productCommentRepository;
            _mapper = mapper;
        }


        public async Task<UpdatePostCommentCommandResponse> Handle(UpdatePostCommentCommandRequest request, CancellationToken cancellationToken)
        {

            var comment = _mapper.Map<Domain.Entities.Product_Comment>(request);
            _productCommentRepository.Update(comment);
            await _productCommentRepository.Commit();
            return new UpdatePostCommentCommandResponse
            {
                IsSuccess = true,
                ProductCommentId = comment.Id,
            };
        }
    }
}
