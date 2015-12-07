using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entity
{
    class Bill
    {
        private int mBillID;
        private int mCusID;
        private int mCodeID;
        private string mStaffID;
        private DateTime mDate;
        private long mTotal;

        public long Total
        {
            get { return mTotal; }
            set { mTotal = value; }
        }

        public Bill()
        {

        }
        public Bill(int mBillID, int mCusID, int mCodeID, string mStaffID, DateTime mDate,long mTotal)
        {
            this.mBillID = mBillID;
            this.mCusID = mCusID;
            this.mCodeID = mCodeID;
            this.mStaffID = mStaffID;
            this.mDate = mDate;
            this.mTotal = mTotal;
        }

        public int BillID
        {
            get
            {
                return mBillID;
            }

            set
            {
                mBillID = value;
            }
        }

        public int CusID
        {
            get
            {
                return mCusID;
            }

            set
            {
                mCusID = value;
            }
        }

        public int CodeID
        {
            get
            {
                return mCodeID;
            }

            set
            {
                mCodeID = value;
            }
        }

        public string StaffID
        {
            get
            {
                return mStaffID;
            }

            set
            {
                mStaffID = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return mDate;
            }

            set
            {
                mDate = value;
            }
        }
    }
}

