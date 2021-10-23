using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
           
          //  ProductTest();
            CategoryTest();
            

        }

        private static void CategoryTest()
        {

           
            //BasketManager basketManager = new BasketManager(new EfBasketDal(),new BasketDetailManager(new EfBasketDetailDal()));
           // var result = basketManager.Add(1,2,1);
         
            Console.WriteLine("eklendi");
           
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();
            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);

                }
             }
             else
                {
                Console.WriteLine(result.Message);
                }
            
            
        }
    }
}
