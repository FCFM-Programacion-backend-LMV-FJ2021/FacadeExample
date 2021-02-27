using FacadeExample.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeExample.Backend
{
    class InvoiceLogic
    {
        internal void GetInvoiceAmounts(InvoiceModel receipt)
        {
            receipt.Subtotal = receipt.ProductList.Sum(s => s.Price);
            receipt.Total = receipt.Subtotal * (decimal) 1.16;
        }
    }
}
