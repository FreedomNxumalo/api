﻿using Domain.Mappings;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Context
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new OrderMappings(modelBuilder.Entity<Order>());
            new CustomerMappings(modelBuilder.Entity<Customer>());
            new StockMappings(modelBuilder.Entity<Stock>());
        }
    }
}
