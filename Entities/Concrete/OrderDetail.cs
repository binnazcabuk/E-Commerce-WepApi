using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class OrderDetail:IEntity
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
       

        public int ProductId { get; set; }
       

        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}
