﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Basket : IEntity
    {
        public int BasketId { get; set; }
        public int ProductId { get; set; }

        public int UserId { get; set; }

       
    }
}
