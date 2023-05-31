using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class Order : BaseEntity
    {
        public int CustomerId { get; set; }
        public int StockId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
