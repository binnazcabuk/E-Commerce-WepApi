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
  public  class EfOrderDal:EfEntityRepositoryBase<Order,NorthwindContext>,IOrderDal
    {


        public List<OrderDetailDto> GetOrderDetails(Expression<Func<OrderDetailDto, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var result = from rt in context.Orders
                             join cr in context.Products on rt.ProductId equals cr.ProductId
                             join cst in context.Suppliers on cr.SupplierId equals cst.SupplierId
                             join usr in context.Users on rt.UserId equals usr.UserId
                             join brd in context.Shippers on rt.ShipperId equals brd.ShipperId
                            
                             select new OrderDetailDto
                             {
                               OrderId=rt.OrderId,
                               ProductId=rt.ProductId,
                               ProductName=cr.ProductName,
                               ShipperName=brd.ShipperName,
                               SupplierName=cst.SupplierName,
                               UserId=usr.UserId,
                               UserName=usr.FirstName+ usr.LastName,
                              

                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();

            }
        }

    }
}
