using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entity
{
    class Customer
    {
        private int mCusID;
        private string mCusName;
        private string mCusAddress;
        private int mCusPhone;

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

        public string CusName
        {
            get
            {
                return mCusName;
            }

            set
            {
                if (value == string.Empty)
                    throw new Exception("CusName invalid.");
                mCusName = value;
            }
        }

        public string CusAddress
        {
            get
            {
                return mCusAddress;
            }

            set
            {
                if (value == string.Empty)
                    throw new Exception("CusAddress invalid.");
                mCusAddress = value;
            }
        }

        public int CusPhone
        {
            get
            {
                return mCusPhone;
            }

            set
            {
                mCusPhone = value;
            }
        }
    }
}
