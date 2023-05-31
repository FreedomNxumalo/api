using Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Mappings
{
    public class CustomerMappings
    {
        public CustomerMappings(EntityTypeBuilder<Customer> entityBuilder)
        {
            entityBuilder.HasKey(t => t.ID);
            entityBuilder.Property(t => t.Name).IsRequired();
            entityBuilder.Property(t => t.Surname).IsRequired();
            entityBuilder.Property(t => t.Address).IsRequired();
            entityBuilder.Property(t => t.DateCreated).IsRequired();
        }
    }
}
