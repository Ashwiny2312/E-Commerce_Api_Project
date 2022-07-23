using ECommerceApi.Application.CQRS.Category.Commands.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.CQRS.Category.Commands.Request
{
    public class CreateCategoryCommandRequest : IRequest<CreateCategoryCommandResponse>
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public DateTime CreateDate => DateTime.Now;
    }
}
