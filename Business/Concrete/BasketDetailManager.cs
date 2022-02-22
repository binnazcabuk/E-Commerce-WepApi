using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BasketDetailManager : IBasketDetailService
    {
        IBasketDetailDal _basketDetailDal;
        IBasketDal _basketService;
        public BasketDetailManager(IBasketDetailDal basketDetailDal, IBasketDal basketService)
        {
            _basketDetailDal = basketDetailDal;
            _basketService = basketService;
        }

        public IResult Add(BasketDetail basketDetail)
        {
            _basketDetailDal.Add(basketDetail);
            return new SuccessResult("eklendi");
        }

        public IResult Delete(BasketDetail basketDetail)
        {
            _basketDetailDal.Delete(basketDetail);
            return new SuccessResult("Ürün Sepetten silindi");
        }

        public IDataResult<List<BasketDetail>> GetAll(int userId)
        {
            var cart = _basketService.Get(c => c.UserId == userId);
            return new SuccessDataResult<List<BasketDetail>>(_basketDetailDal.GetAll(x => x.BasketId == cart.BasketId));
        }

        public IDataResult<List<BasketDetailDto>> GetAllBasket(int userId)
        {
            var cart = _basketService.Get(c => c.UserId == userId);
            return new SuccessDataResult<List<BasketDetailDto>>(_basketDetailDal.GetBasketDetails(x => x.BasketId == cart.BasketId && x.Status == true));
        }

        public IDataResult<List<BasketDetail>> GetCartById(int basketId)
        {
            var result = _basketDetailDal.GetAll(x => x.BasketId == basketId);
            return new SuccessDataResult<List<BasketDetail>>(result);
        }

        public IResult Update(BasketDetail basketDetail)
        {
            _basketDetailDal.Update(basketDetail);
            return new SuccessResult("Sepet güncellendi");
        }
    }
}
