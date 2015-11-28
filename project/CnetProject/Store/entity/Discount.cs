using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.entity
{
    class Discount
    {
        private int mCodeID;
        private string mType;
        private float mRate;
        private int mProIDGift;
        private DateTime DateStart;
        private DateTime DateEnd;
        public int CodeID
        {
            get { return mCodeID; }
            set { mCodeID = value; }
        }
        public string Type
        {
            get { return mType; }
            set
            {
                if (value == string.Empty)
                    throw new Exception("Type invalid.");

                mType = value;
            }
        }
        public float Rate
        {
            get { return mRate; }
            set { mRate = value; }
        }
        public int ProIDGift
        {
            get { return mProIDGift; }
            set { mProIDGift = value; }
        }
    }
}
