using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Application.CQRS.Category.Commands.Request
{
    public class DeleteCategoryCommandRequest
    {
        public int Id { get; set; }
    }
}
