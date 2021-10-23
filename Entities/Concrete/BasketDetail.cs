using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class BasketDetail:IEntity
    {

        public int BasketDetailId { get; set; }

        public int ProductId { get; set; }
    

        public int BasketId { get; set; }
       
      
        public int Quantity { get; set; }
        public bool Status { get; set; }
    }
}
