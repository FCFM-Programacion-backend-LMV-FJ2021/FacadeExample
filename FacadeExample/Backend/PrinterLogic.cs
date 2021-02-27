using FacadeExample.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadeExample.Backend
{
    public class PrinterLogic
    {
        internal string PrintSalesReceiptInvoice(InvoiceModel receipt)
        {
            string printerString = "********* RECIBO DE COMPRA *************\n";
            printerString += "\tROLANDO STORE";
            printerString += "\n\tFecha: " + receipt.Date;
            printerString += "\n\n\n\tProducto\tPrecio" + "\n";


            receipt.ProductList.ForEach(f => printerString += "\t" + f.Title + "\t$" + f.Price + "\n");

            printerString += "\n\n\t\tSubtotal: $" + receipt.Subtotal + "\n";
            printerString += "\t\tSubtotal: $" + receipt.Total + "\n";

            return printerString;

        }
    }
}
