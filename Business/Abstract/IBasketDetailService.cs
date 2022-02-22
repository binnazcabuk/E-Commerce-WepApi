using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBasketDetailService
    {
        IResult Add(BasketDetail basketDetail);
        IResult Delete(BasketDetail basketDetail);
        IResult Update(BasketDetail basketDetail);
        IDataResult<List<BasketDetailDto>> GetAllBasket(int userId);
        IDataResult<List<BasketDetail>> GetAll(int userId);
        IDataResult<List<BasketDetail>> GetCartById(int basketId);
    }
}
