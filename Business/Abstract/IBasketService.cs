using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IBasketService
    {
      
      
        IResult Add(Basket basket);
        IResult Delete(Basket basket);
        IDataResult<List<Basket>> GetById(int userId);
        IDataResult<List<BasketDetailDto>> GetBasketDetailByUserId(int userId);

      
    }
}
