using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Mappings
{
    public class OrderMappings
    {
        public OrderMappings(EntityTypeBuilder<Order> entityBuilder)
        {
            entityBuilder.HasKey(t => t.ID);
            entityBuilder.Property(t => t.CustomerId).IsRequired();
            entityBuilder.Property(t => t.StockId).IsRequired();
            entityBuilder.Property(t => t.DateCreated).IsRequired();
        }
    }
}
