using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Domain.Entities
{
    internal class Basket
    {
        public int ID { get; set; }
        public string AppUserEmail { get; set; } 
        public List<BasketItem> BasketItems { get; set; }

    }
}
