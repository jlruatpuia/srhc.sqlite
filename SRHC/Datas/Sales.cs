using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRHC.Datas
{
    public class Sales
    {
        public int ID { get; set; }
        public string InvoiceNo { get; set; }
        public int CustomerID { get; set; }
        public double TotalAmount { get; set; }
        public double TotalPayment { get; set; }
        public double TotalBalance { get; set; }
    }

    public class SalesDetail
    {
        public int ID { get; set; }
        public string InvoiceNo { get; set; }
        public string SellDate { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double BuyingValue { get; set; }
        public double SellingValue { get; set; }
        public double Amount { get; set; }
        public double DiscountPercent { get; set; }
        public double DiscountValue { get; set; }
        public double TotalAmount { get; set; }
    }
}
