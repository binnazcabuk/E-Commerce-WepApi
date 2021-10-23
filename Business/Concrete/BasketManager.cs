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
    public class BasketManager : IBasketService
    {
        IBasketDal _basketDal;
        IBasketDetailService _basketDetailService;

        public BasketManager(IBasketDal basketDal, IBasketDetailService basketDetailService)
        {
            _basketDal = basketDal;
            _basketDetailService = basketDetailService;
        }

        public IResult Add(int userId, int productId, int quantity)
        {
            var cart = GetCartByUserId(userId);

            if (cart.Data == null)
            {
                var basket = new Basket()
                {
                    UserId = userId
                };
                _basketDal.Add(basket);



                var basketDetail = new BasketDetail()
                {
                    ProductId = productId,
                    Quantity = quantity,
                    BasketId = basket.BasketId,
                    Status = true,
                };

                _basketDetailService.Add(basketDetail);

            }
            else
            {
                //eklenmek isteyen ürün sepette var mı?(güncelleme)
                //eklenmek isteyen ürün sepette var adet artır

                var result = _basketDetailService.GetCartById(cart.Data.BasketId);

                int index = result.Data.FindIndex(a => a.ProductId == productId);
                if (index < 0)
                {
                   
                  var basketDetail= new BasketDetail()
                    {
                        ProductId = productId,
                        Quantity = quantity,
                        BasketId  = cart.Data.BasketId,
                        Status = true,
                  };

                   _basketDetailService.Add(basketDetail);
                }
                else
                {
                    result.Data[index].Quantity = result.Data[index].Quantity+1;
                    _basketDetailService.Update(result.Data[index]);

                }



            }
           
                return new SuccessResult();
            
        }
       

     

            public IDataResult<Basket> GetCartByUserId(int userId)
            {

                return new SuccessDataResult<Basket>(_basketDal.Get(c => c.UserId == userId));
            }

            /*
            public double SumBasketUnitPrice(int userId)
            {
                var result = _basketDal.GetBasketDetails(r => r.UserId == userId).Sum(x => x.UnitPrice);
                return result;
            }
            */



     
       

        public IResult Update(Basket basket)
        {
            _basketDal.Update(basket);
            return new SuccessResult();
        }

      

        
    
    }
}
