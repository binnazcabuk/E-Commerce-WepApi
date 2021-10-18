using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class OrderDetailDto : IDto
    {

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public string ProductName { get; set; }
        public string ShipperName { get; set; }
        public string UserName { get; set; }

        public string SupplierName { get; set; }
        
     
    }
}
