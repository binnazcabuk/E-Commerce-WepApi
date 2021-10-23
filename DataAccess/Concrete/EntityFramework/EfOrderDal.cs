using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
  public  class EfOrderDal:EfEntityRepositoryBase<Order,NorthwindContext>,IOrderDal
    {


        

    }
}
