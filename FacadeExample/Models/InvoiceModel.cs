using System;
using System.Collections.Generic;

namespace FacadeExample.Facade
{
    public class InvoiceModel
    {
        public InvoiceModel()
        {
            ProductList = new List<ProductsModel>();
        }
        public List<ProductsModel> ProductList { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public string FiscalID { get; set; }
        public DateTime Date { get; set; }
    }
}