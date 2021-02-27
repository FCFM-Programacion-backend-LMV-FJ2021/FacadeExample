using FacadeExample.Facade;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacadeExample.Backend
{
    class FiscalLogic
    {
        internal void GetFiscalReceiptData(InvoiceModel receipt)
        {
            //this is a mock for fiscal procedure
            receipt.FiscalID = Guid.NewGuid().ToString();
            receipt.Date = DateTime.Now;
        }
    }
}
