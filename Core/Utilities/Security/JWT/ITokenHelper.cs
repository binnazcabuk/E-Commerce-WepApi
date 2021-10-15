using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
  public  interface ITokenHelper
    {
        //kullanıcı giriş yaptı kullanıcı adı şifre doğru ise giriş yapacak ve bu yapı çalışacak
        //giriş yapan kullanıcı için,veritabanına gidecek orta bir token , nelere yetkisi var bilgisini tutan
        //oluşturacak
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
