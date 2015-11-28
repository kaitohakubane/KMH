using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.Entities
{
    public class Customer
    {
        private string mCustomerID;

        public string CustomerID
        {
            get { return mCustomerID; }
            set { mCustomerID = value; }
        }
        private string mName;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        private string mAddress;

        public string Address
        {
            get { return mAddress; }
            set { mAddress = value; }
        }

        private string mPhone;

        public string Phone
        {
            get { return mPhone; }
            set { mPhone = value; }
        }



    }
}
