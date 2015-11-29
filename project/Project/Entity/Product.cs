using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entity
{
    class Product
    {
        private int mProID;
        private string mProName;
        private int mSupID;
        private string mProducer;
        private string mOrigin;
        private double mInPrice;
        private double mOutPrice;
        private int mQuantity;
        private string mType;

        public int ProID
        {
            get
            {
                return mProID;
            }

            set
            {
                mProID = value;
            }
        }

        public string ProName
        {
            get
            {
                return mProName;
            }

            set
            {
                if (value == string.Empty)
                    throw new Exception("ProName invalid.");
                mProName = value;
            }
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

        public string Producer
        {
            get
            {
                return mProducer;
            }

            set
            {
                if (value == string.Empty)
                    throw new Exception("Producer invalid.");
                mProducer = value;
            }
        }

        public string Origin
        {
            get
            {
                return mOrigin;
            }

            set
            {
                if (value == string.Empty)
                    throw new Exception("Origin invalid.");
                mOrigin = value;
            }
        }

        public double InPrice
        {
            get
            {
                return mInPrice;
            }

            set
            {
                mInPrice = value;
            }
        }

        public double OutPrice
        {
            get
            {
                return mOutPrice;
            }

            set
            {
                mOutPrice = value;
            }
        }

        public int Quantity
        {
            get
            {
                return mQuantity;
            }

            set
            {
                mQuantity = value;
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
    }
}
