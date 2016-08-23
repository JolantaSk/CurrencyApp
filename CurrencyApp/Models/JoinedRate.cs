using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CurrencyApp.Models
{
    public class ComparedRate : CurrencyRate
    {
        public decimal PastRate { get; set; }

        public decimal Change { get; set; }  

    }
}