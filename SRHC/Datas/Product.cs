using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRHC.Datas
{
    public class Product
    {
        public int ID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }
        public double BuyingValue { get; set; }
        public double SellingValue { get; set; }
        public int Quantity { get; set; }

    }
}
