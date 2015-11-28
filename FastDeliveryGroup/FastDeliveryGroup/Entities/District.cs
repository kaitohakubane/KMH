using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.Entities
{
  public  class District
    {
        private int mDistrictID;

        public int DistrictID
        {
            get{ return mDistrictID;}
            set{ mDistrictID = value;}
        }
        private string mNameOfDistrict;
        public string NameOfDistrict
        {
            get { return mNameOfDistrict;}
            set { mNameOfDistrict = value;}
        }

        
    }
}
