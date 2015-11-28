using FastDeliveryGroup.DataAccessLayer;
using FastDeliveryGroup.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.BussinessLogicLayer
{
    class InvoiceBLL
    {
        public static bool AddInvoice(Invoice inv)
        {
            return InvoiceData.InsertInvoice(inv);
        }

        public static DataTable GetAllInvoice()
        {
            return InvoiceData.SelectAllInvoice();
        }
        public static bool DeleteInvoice(int ID)
        {
            return InvoiceData.DeleteInvoice(ID);
        }
    }
}
