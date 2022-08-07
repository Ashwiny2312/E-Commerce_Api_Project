using ECommerceApi.Application.CQRS.Product_Comment.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.CQRS.Product_Comment.Commands.Request
{
    public class DeletePostCommentCommandRequest : IRequest<DeletePostCommentCommandResponse>
    {
        public int Id { get; set; }
    }
}
