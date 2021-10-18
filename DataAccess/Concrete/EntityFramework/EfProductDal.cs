using Core.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{

    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             join s in context.Suppliers on p.SupplierId equals s.SupplierId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId, ProductName = p.ProductName,
                                 CategoryName = c.CategoryName, UnitPrice = (short)p.UnitPrice,SupplierName=s.SupplierName
                             };
                return result.ToList();
            }
        }
    }
}
