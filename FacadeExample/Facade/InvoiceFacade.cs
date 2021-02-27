using FacadeExample.Backend;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeExample.Facade
{
    public class InvoiceFacade
    {
        public string PrintReceipt(List<ProductsModel> products)
        {

            var receipt = new InvoiceModel();
            receipt.ProductList = new ProductLogic().GetProductsForInvoice(products);
            new FiscalLogic().GetFiscalReceiptData(receipt);
            new InvoiceLogic().GetInvoiceAmounts(receipt);
            return new PrinterLogic().PrintSalesReceiptInvoice(receipt);
        }
    }
}
