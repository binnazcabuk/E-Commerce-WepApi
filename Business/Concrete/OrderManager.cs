using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
      
        IOrderDal _orderDal;
   

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
     
          
        }

      
        public IResult Add(Order order)
        {

             _orderDal.Add(order);

            return new SuccessResult();
        }

       
        public IResult Update(Order order)
        {
            _orderDal.Update(order);
            return new SuccessResult();
        }

 
     
        public IResult Delete(Order order)
        {
            _orderDal.Delete(order);
            return new SuccessResult();
        }


  
        public IDataResult<List<Order>> GetAll()
        {
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll());
        }


        public IDataResult<List<OrderDetailDto>> GetOrderDetails()
        {
            return new SuccessDataResult<List<OrderDetailDto>>(_orderDal.GetOrderDetails());
        }


        public IDataResult <List<Order>> GetByUserId(int userId)
        {  
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(x=>x.UserId==userId));
        }

        public IDataResult<List<OrderDetailDto>> GetOrderUserDetails(int userId)
        {
            return new SuccessDataResult<List<OrderDetailDto>>(_orderDal.GetOrderDetails(x=>x.UserId==userId));
        }
    }
}
