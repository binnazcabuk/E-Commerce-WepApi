using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //HANGİ TİP DÖNECEKSE <T>
   public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
