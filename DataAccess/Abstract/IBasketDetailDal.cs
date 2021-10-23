using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IBasketDetailDal : IEntityRepository<BasketDetail>
    {
        List<BasketDetailDto> GetBasketDetails(Expression<Func<BasketDetailDto, bool>> filter = null);

    }
}
