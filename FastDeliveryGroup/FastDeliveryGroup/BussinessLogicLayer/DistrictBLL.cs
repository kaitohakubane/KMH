using FastDeliveryGroup.DataAccessLayer;
using FastDeliveryGroup.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.BussinessLogicLayer
{
    class DistrictBLL
    {
        public static bool AddDistrict(District dis)
        {
            return DistrictData.InsertDistrict(dis);
        }

        public static DataTable GetAllDistrict()
        {
            return DistrictData.SelectAllDistrict();
        }
        public static bool DeleteDistrict(int ID)
        {
            return DistrictData.DeleteDistrict(ID);
        }
    }
}
