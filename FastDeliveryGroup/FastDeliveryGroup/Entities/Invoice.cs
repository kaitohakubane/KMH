using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.Entities
{
    public class Invoice
    {
        private int mInvoiceID;

        public int InvoiceID
        {
            get { return mInvoiceID; }
            set { mInvoiceID = value; }
        }

        private string mCustomerID;

        public string CustomerID
        {
            get { return mCustomerID; }
            set { mCustomerID = value; }
        }

        private int mShipperID;

        public int ShipperID
        {
            get { return mShipperID; }
            set { mShipperID = value; }
        }

        private DateTime mShipmentDate;

        public DateTime ShipmentDate
        {
            get { return mShipmentDate; }
            set { mShipmentDate = value; }
        }

        private double mTotal;

        public double Total
        {
            get { return mTotal; }
            set { mTotal = value; }
        }

        private int mStaffID;

        public int StaffID
        {
            get { return mStaffID; }
            set { mStaffID = value; }
        }

        private string mStatus;

        public string Status
        {
            get { return mStatus; }
            set { mStatus = value; }
        }

        private string mDescription;

        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }



    }
}
