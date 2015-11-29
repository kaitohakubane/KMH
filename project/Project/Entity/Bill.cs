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
        private int mStaffID;
        private DateTime mDateStart;
        private DateTime mDateEnd;

        public Bill(int mBillID, int mCusID, int mCodeID, int mStaffID, DateTime mDateStart, DateTime mDateEnd)
        {
            this.mBillID = mBillID;
            this.mCusID = mCusID;
            this.mCodeID = mCodeID;
            this.mStaffID = mStaffID;
            this.mDateStart = mDateStart;
            this.mDateEnd = mDateEnd;
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

        public int StaffID
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

        public DateTime DateStart
        {
            get
            {
                return mDateStart;
            }

            set
            {
                mDateStart = value;
            }
        }

        public DateTime DateEnd
        {
            get
            {
                return mDateEnd;
            }

            set
            {
                mDateEnd = value;
            }
        }
    }
}
