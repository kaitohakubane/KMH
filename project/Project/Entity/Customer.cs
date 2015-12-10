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
        private string mCusPhone;
        private bool misActive;
        public Customer()
        {

        }
        public Customer(int mCusID, string mCusName, string mCusAddress, string mCusPhone,bool misActive)
        {
            this.mCusID = mCusID;
            this.mCusName = mCusName;
            this.mCusAddress = mCusAddress;
            this.mCusPhone = mCusPhone;
            this.misActive = misActive;
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

        public string CusPhone
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

        public bool isActive
        {
            get
            {
                return misActive;
            }

            set
            {
                misActive = value;
            }
        }
    }
}
