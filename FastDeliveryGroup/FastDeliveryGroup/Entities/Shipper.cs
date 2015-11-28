using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.Entities
{
    public class Shipper
    {
        private int mShipperID;

        public int ShipperID
        {
            get { return mShipperID; }
            set { mShipperID = value; }
        }

        private string mName;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        private int mPlaceID;

        public int PlaceID
        {
            get { return mPlaceID; }
            set { mPlaceID = value; }
        }

        private string mPhone;

        public string Phone
        {
            get { return mPhone; }
            set { mPhone = value; }
        }


    }
}
