using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class BasketDetailDto : IDto
    {
        public int BasketId { get; set; }
        public int UserId { get; set; }
        public string ProductName { get; set; }
       
        public short UnitPrice { get; set; }

    }
}
