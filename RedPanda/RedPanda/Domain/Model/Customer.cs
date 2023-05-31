using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Model
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
