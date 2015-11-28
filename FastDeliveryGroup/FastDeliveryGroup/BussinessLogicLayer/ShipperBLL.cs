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
    class ShipperBLL
    {
        public static List<Shipper> GetAllShipper()
        {
            return ShipperData.SelectAllShipper();
        }
        public static bool AddShipper(Shipper shipper)
        {
            return ShipperData.AddShipperName(shipper);
        }
        public static DataTable GetShipper()
        {
            return ShipperData.SelectAll();
        }
        public static bool DeleteShipper(int ID)
        {
            return ShipperData.DeleteShipper(ID);
        }
    }
}
