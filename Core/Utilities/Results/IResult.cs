using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç
   public interface IResult
    {
        //yapılan işlem başarılımı
        bool Success { get; }
        //işlem sonucuna göre bilgilendirme
        string Message { get; }

    }
}
