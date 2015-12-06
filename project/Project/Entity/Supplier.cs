using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entity
{
    class Supplier
    {
        private int mSupID;
        private string mSupName;
        private string mSupAddress;
        private float mSupDept;
        private int mSupPhone;
        private bool misActive;
        public Supplier()
        {

        }
        public Supplier(int mSupID, string mSupName, string mSupAddress, float mSupDept, int mSupPhone, bool misActive)
        {
            this.mSupID = mSupID;
            this.mSupName = mSupName;
            this.mSupAddress = mSupAddress;
            this.mSupDept = mSupDept;
            this.mSupPhone = mSupPhone;
            this.misActive = misActive;
        }
        public bool isActive
        {
            get { return misActive; }
            set { misActive = value; }
        }

        public int SupID
        {
            get
            {
                return mSupID;
            }

            set
            {
                mSupID = value;
            }
        }

        public string SupName
        {
            get
            {
                return mSupName;
            }

            set
            {
                if (value == string.Empty)
                    throw new Exception("SupName invalid.");
                mSupName = value;
            }
        }

        public string SupAddress
        {
            get
            {
                return mSupAddress;
            }

            set
            {
                if (value == string.Empty)
                    throw new Exception("SupAddress invalid.");
                mSupAddress = value;
            }
        }

        public float SupDept
        {
            get
            {
                return mSupDept;
            }

            set
            {
                mSupDept = value;
            }
        }

        public int SupPhone
        {
            get
            {
                return mSupPhone;
            }

            set
            {
                mSupPhone = value;
            }
        }
    }
}
