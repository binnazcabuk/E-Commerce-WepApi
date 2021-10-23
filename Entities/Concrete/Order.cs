using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
   public class Order : IEntity
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
      
        public DateTime OrderDate { get; set; }
        public int ShipperId { get; set; }
        public string RecipientName  { get; set; }
        public string RecipientAddress { get; set; }
        public string RecipientCity { get; set; }
        
    }
}
