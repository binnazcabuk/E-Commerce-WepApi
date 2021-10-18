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


        public static string UserAdded = "Kullanici Eklendi";
        public static string UsersListed = "Kullanicilar Listelendi";
        public static string UserDeleted = "Kullanici Silindi";
        public static string UserUpdated = "Kullanici Guncellendi";

        public static string AuthorizationDenied = "yetkiniz yok";
        public static string Registered = "Kullanıcı Başarılı bir sekilde kayıt oldu.";


        public static string UserNotFound = "Kullanıcı Bulunamadı";
        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string UserAlreadyExists = "Kullanıcı Mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
