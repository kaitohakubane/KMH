using FastDeliveryGroup.DataAccessLayer;
using FastDeliveryGroup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.BussinessLogicLayer
{
    class InvoiceDetailBLL
    {
        public static int GetCurrentIdentity()
        {
            return InvoiceDetailData.SelectCurrentIden();
        }

        public static int AddInvoiceDetails(List<InvoiceDetail> details)
        {
            int count = 0;
            foreach (InvoiceDetail id in details)
            {
                if (InvoiceDetailData.InsertDetail(id))
                {
                    count++;
                }
            }
            return count;
        }

    }
}
