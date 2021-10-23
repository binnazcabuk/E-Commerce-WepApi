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
      
      
        IResult Add(int userId, int productId, int quantity);
       
        IResult Update(Basket basket);
       

        IDataResult<Basket> GetCartByUserId(int userId);


      
     
     
    }
}
