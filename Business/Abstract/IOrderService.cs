using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IResult Add(Order order);
     

        IResult Update(Order order);
     

        IResult Delete(Order order);
      

        IDataResult<List<Order>> GetByUserId(int userId);
       

        IDataResult<List<Order>> GetAll();

        IDataResult<List<OrderDetailDto>> GetOrderDetails();
        IDataResult<List<OrderDetailDto>> GetOrderUserDetails(int userId);
    }
}

