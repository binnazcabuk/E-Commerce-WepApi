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
        IBasketDetailService _basketDetailServiceDal;
        IOrderDal _orderDal;
        IOrderDetailService _orderDetailService;

        public OrderManager(IOrderDal orderDal,IBasketDetailService basketDetailService, IOrderDetailService orderDetailService)
        {
            _orderDal = orderDal;
            _basketDetailServiceDal = basketDetailService;
            _orderDetailService = orderDetailService;
        }

      
        public IResult Add(Order order)
        {
            _orderDal.Add(order);
           
            var basketDetail = _basketDetailServiceDal.GetAllBasket(order.UserId);

            foreach (var item in basketDetail.Data)
            {
                var orderDetail = new OrderDetail()
                {
                    OrderId = order.OrderId,
                    Price=item.UnitPrice,
                    ProductId=item.ProductId,
                    Quantity=item.Quantity
                    
                    
                };

            
                _orderDetailService.Add(orderDetail);

            }
                
            
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


     


        public IDataResult <List<Order>> GetByUserId(int userId)
        {  
            return new SuccessDataResult<List<Order>>(_orderDal.GetAll(x=>x.UserId==userId));
        }

      
    }
}
