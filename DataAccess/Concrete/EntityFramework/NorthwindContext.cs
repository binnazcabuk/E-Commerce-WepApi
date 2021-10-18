using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //db tabloları ile proje classlarını bağlamak için kullanıyoruz

  public  class NorthwindContext:DbContext
    {
        //bu metod projenin hangi veri tabanı ile ilişkili olduğunu belirtmek için kullanılır
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=ETicaret;Trusted_Connection=true");
        }

        //hangi class hangi tabloya denk gelir onun belirlenmesi
       public DbSet<Product> Products { get; set; }
       public DbSet<Category> Categories { get; set; }
       public DbSet<Order> Orders { get; set; }

        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
