using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBasketDetailDal : EfEntityRepositoryBase<BasketDetail, NorthwindContext>, IBasketDetailDal
    {

        public List<BasketDetailDto> GetBasketDetails(Expression<Func<BasketDetailDto, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from rt in context.BasketDetails
                            
                             join cr in context.Products on rt.ProductId equals cr.ProductId
                             join cst in context.Suppliers on cr.SupplierId equals cst.SupplierId
              
                           

                             select new BasketDetailDto
                             {
                                 BasketDetailId=rt.BasketDetailId,
                                 Status=rt.Status,
                                 ProductId=cr.ProductId,
                                 BasketId=rt.BasketId,
                                 ProductName=cr.ProductName,
                                 Quantity=rt.Quantity,
                                 SupplierName=cst.SupplierName,
                                 UnitPrice= (short)cr.UnitPrice

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }


    }
}
