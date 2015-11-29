using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entity
{
    class Discount
    {
        private int mCodeID;
        private string mType;
        private float mRate;
        private int mProIDGift;
        private DateTime mDateStart;
        private DateTime mDateEnd;

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

        public string Type
        {
            get
            {
                return mType;
            }

            set
            {
                if (value == string.Empty)
                    throw new Exception("Type invalid.");
                mType = value;
            }
        }

        public float Rate
        {
            get
            {
                return mRate;
            }

            set
            {
                mRate = value;
            }
        }

        public int ProIDGift
        {
            get
            {
                return mProIDGift;
            }

            set
            {
                mProIDGift = value;
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
