using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FarmService
{
    public class InvoiceClass
    {
        public int InvoiceID;
        public int user;
        public DateTime day;
        public double subtotal;
        public double vat;
        public double delivery;
        public double grossTotal;
    }
}