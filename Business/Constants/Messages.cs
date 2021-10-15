using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
  public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "ürün ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ProductListed="ürünler listelendi";
        public static string ProductCategoryError = "Kategori 10'den fazla var";
        public static string CategoryLimitExeceded = "Kategori limitini aştınız";

        public static string AuthorizationDenied = "yetkiniz yok";
    }
}
