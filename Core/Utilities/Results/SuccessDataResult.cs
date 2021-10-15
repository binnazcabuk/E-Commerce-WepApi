using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
  public  class SuccessDataResult<T>:DataResult<T>
    {
        //veri, doğruluk,mesaj
        public SuccessDataResult(T data,string message):base(data,true,message)
        {
                
        }
        // veri , doğruluk
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        // default,doğruluk,mesaj
        public SuccessDataResult(string message):base(default,true,message)
        {
                
        }
        //default değer,doğruluk
        public SuccessDataResult():base(default,true)
        {
                
        }
    
  }
}
