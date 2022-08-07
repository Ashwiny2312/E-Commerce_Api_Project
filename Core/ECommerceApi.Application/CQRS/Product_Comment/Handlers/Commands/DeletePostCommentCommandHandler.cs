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

    public class DeletePostCommentCommandHandler : IRequestHandler<DeletePostCommentCommandRequest, DeletePostCommentCommandResponse>
    {
        private readonly IProductCommentRepository _productCommentRepository;
        private readonly IMapper _mapper;

        public DeletePostCommentCommandHandler(IProductCommentRepository productCommentRepository, IMapper mapper)
        {
            _productCommentRepository = productCommentRepository;
            _mapper = mapper;
        }


        public async Task<DeletePostCommentCommandResponse> Handle(DeletePostCommentCommandRequest request, CancellationToken cancellationToken)
        {


            var category = await _productCommentRepository.GetDefault(x => x.Id == request.Id);

            category.Status = Domain.Enums.Status.Passive;
            category.DeleteDate = DateTime.Now;

            await _productCommentRepository.Commit();

            return new DeletePostCommentCommandResponse
            {
                IsSuccess = true,
            };
        }
    }
}
