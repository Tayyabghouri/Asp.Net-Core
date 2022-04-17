using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BUSSystem.Models
{
    public class Payment
    {
        public int Price { get; set; }
        public int Price_of_ticktet { get; set; }
        public string QRCode { get; set; }
    }
}