using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
       
//iki parametre gönderilince  bu classın successi de çalışmalı
        public Result(bool success, string message):this(success)
        {
            Message = message;
           
        }

        //mesaj yazdırmak istemezsek
        public Result(bool success)
        {
           
            Success = success;
        }

        public bool Success {get;}

        public string Message { get; }

    }
}
