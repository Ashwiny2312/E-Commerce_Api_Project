﻿using ECommerceApi.Domain.Entities.Common;
using ECommerceApi.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Domain.Entities
{
    public class Basket :  IBaseEntity
    {
        public int Id { get; set; }
        public string AppUserEmail { get; set; } 
        public string BasketItem_Id { get; set; } 
        public BasketItem BasketItems  { get; set; } 
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public Status Status { get; set; }

    }
}
