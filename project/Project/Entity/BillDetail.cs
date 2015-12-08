using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entity
{
    class BillDetail
    {
        private int mBillID;
        private int mProID;
        private int mQuantity;
        public BillDetail()
        {
        }
        
        public BillDetail(int mBillID, int mProID, int mQuantity)
        {
            this.mBillID = mBillID;
            this.mProID = mProID;
            this.mQuantity = mQuantity;
        }

        public int Quantity
        {
            get { return mQuantity; }
            set { mQuantity = value; }
        }

        public int ProID
        {
            get { return mProID; }
            set { mProID = value; }
        }

        public int BillID
        {
            get { return mBillID; }
            set { mBillID = value; }
        }

    }
}
