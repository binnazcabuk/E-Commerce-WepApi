﻿using Core.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //class cıplak kalmamalı bir implemetasyon yapılmalı
   public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}