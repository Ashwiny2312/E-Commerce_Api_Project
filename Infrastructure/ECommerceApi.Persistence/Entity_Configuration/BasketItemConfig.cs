using ECommerceApi.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Persistence.Entity_Configuration
{
 
    public class BasketItemConfig : BaseEntityConfig<BasketItem>
    {
        public override void Configure(EntityTypeBuilder<BasketItem> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.AppUserEmail).IsRequired(false);


            base.Configure(builder);
        }
    }
}
