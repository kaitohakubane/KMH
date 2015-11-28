using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.Entities
{
    public class Product
    {
        private int mProductID;

        public int ProductID
        {
            get { return mProductID; }
            set { mProductID = value; }
        }

        private string mName;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        private double mPrice;

        public Product()
        {
        }

        public double Price
        {
            get { return mPrice; }
            set { mPrice = value; }
        }

        public new string ToString()
        {
            return this.Name;
        }


    }
}
