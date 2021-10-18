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
      

       public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
            
        }

        public IResult Add(Basket basket)
        {
            
            //Sepete'e ürün ekle.
            _basketDal.Add(basket);
           
            return new SuccessResult("sepete eklendi");
        }

        public IResult Delete(Basket basket)
        {
            _basketDal.Delete(basket);
            return new SuccessResult("Ürün Sepetten silindi");
        }

        public IDataResult<List<BasketDetailDto>> GetBasketDetailByUserId(int userId)
        {


            var result = _basketDal.GetBasketDetails(r => r.UserId == userId).ToList();

            if (result == null)
            {
                return new ErrorDataResult<List<BasketDetailDto>>("Sepette Ürün Yok");
            }
            return new SuccessDataResult<List<BasketDetailDto>>(result);
          
           
        }

        public IDataResult<List<Basket>>GetById(int userId)
        {
            return new SuccessDataResult<List<Basket>>(_basketDal.GetAll(c => c.UserId == userId));
        }

    }
}
