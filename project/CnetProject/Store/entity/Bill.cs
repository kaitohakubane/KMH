using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.entity
{
    class Bill
    {
        private int mBillID;
        private int mCusID;
        private int mCodeID;
        private int mStaffID;
        private DateTime mDateStart;
        private DateTime mDateEnd;
        public int StaffID
        {
            get { return mStaffID; }
            set { mStaffID = value; }
        }
        public int BillID
        {
            get { return mBillID; }
            set { mBillID = value; }
        }
        public int CusID
        {
            get { return mCusID; }
            set { mCusID = value; }
        }
        public int CodeID
        {
            get { return mCodeID; }
            set { mCodeID = value; }
        }
    }
}
