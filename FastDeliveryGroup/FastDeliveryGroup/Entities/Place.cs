using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.Entities
{
    class Place
    {
        private int mPlaceID;

        public int PlaceID
        {
            get { return mPlaceID; }
            set { mPlaceID = value; }
        }

        private int mName;

        public int Name
        {
            get { return mName; }
            set { mName = value; }
        }


    }
}
