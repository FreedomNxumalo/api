using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class Stock : BaseEntity
    {
        public string StockNumber { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
