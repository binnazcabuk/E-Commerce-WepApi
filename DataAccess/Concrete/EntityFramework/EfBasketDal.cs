using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBasketDal : EfEntityRepositoryBase<Basket, NorthwindContext>, IBasketDal
    {

      

        public List<BasketDetailDto> GetBasketDetails(Expression<Func<BasketDetailDto, bool>> filter = null)
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from p in context.Baskets
                             join c in context.Products
                             on p.ProductId equals c.ProductId
                             select new BasketDetailDto
                             {
                                 BasketId = p.BasketId,
                                 UserId = p.UserId,
                                 ProductName = c.ProductName,

                                 UnitPrice = (short)c.UnitPrice,
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
    }
}
