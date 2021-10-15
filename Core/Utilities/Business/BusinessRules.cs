using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
   public class BusinessRules
    {
        //params--->istediğin kadar ıresult  parametre ver virgülle ayırarak
        public static IResult Run(params IResult[] logics)
        {
            //parametre ile gönderdiğimiz iş kurallarından
            //başarısız olanı business' e haber ederiyoruz
            foreach (var logic in logics)
            {
                if (!logic.Success)//başarılı değilse kural
                {
                    return logic;
                }

            }
            return null;
        }
    }
}
