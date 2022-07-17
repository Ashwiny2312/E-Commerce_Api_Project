using ECommerceApi.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceApi.Persistence.Entity_Configuration
{


    public class AddressConfig : BaseEntityConfig<Address>
    {
        public override void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.UserID);
            builder.Property(x => x.Street).IsRequired(false);
            builder.Property(x => x.City).IsRequired(false);
            builder.Property(x => x.Country).IsRequired(false);
            builder.Property(x => x.Zip).IsRequired(false);
            builder.Property(x => x.Street2).IsRequired(false);
            builder.Property(x => x.State).IsRequired(false);

            base.Configure(builder);
        }
    }
}
