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

        public static bool UpdateInvoiceByID(Invoice inv)
        {
            return InvoiceData.UpdateInvoice(inv);
        }

        public static DataTable GetInvoiceByDay(DateTime d)
        {
            return InvoiceData.SelectInvoiceByDay(d);
        }

        public static DataTable GetScheduleByMonth(int month, int year)
        {
            string sql = "spSelectCustomerByMonth";
            return InvoiceData.SelectInvoiceByMonth(sql, month, year);
        }

        public static DataTable GetShipperByMonth(int month, int year)
        {
            string sql = "spSelectShipperByMonth";
            return InvoiceData.SelectInvoiceByMonth(sql, month, year);
        }
    }
}
