using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SRHC.Datas
{
    public class Purchase
    {
        public int ID { get; set; }
        public string InvoiceNo { get; set; }
        public int SupplierID { get; set; }
        public double TotalAmount { get; set; }
        public double TotalPayment { get; set; }
        public double TotalBalance { get; set; }

    }

    public class PurchaseDetail
    {
        public int ID { get; set; }
        public string InvoiceNo { get; set; }
        public string PurchaseDate { get; set; }
        public int ProductID { get; set; }
        public double BuyingValue { get; set; }
        public double SellingValue { get; set; }
        public int Quantity { get; set; }
        public double Amount { get; set; }
    }
}
