using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        //veri, doğruluk,mesaj
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        // veri , doğruluk
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        // default,doğruluk,mesaj
        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
        //default değer,doğruluk
        public ErrorDataResult() : base(default, false)
        {

        }

    }
}
