using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BasketDetailDto : IDto
    {
        public int BasketId { get; set; }
        public int ProductId { get; set; }
        public bool Status { get; set; }
        public int BasketDetailId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public short UnitPrice { get; set; }
        public string SupplierName { get; set; }
    }
}
