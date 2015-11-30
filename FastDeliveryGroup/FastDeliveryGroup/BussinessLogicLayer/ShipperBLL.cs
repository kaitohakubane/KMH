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

        public static DataTable GetAllDTShipper()
        {
            return ShipperData.SelectAllDTShipper();
        }

        public static bool AddShipper(Shipper shipper)
        {
            return ShipperData.AddShipperName(shipper);
        }

        public static bool DeleteShipper(int ID)
        {
            return ShipperData.DeleteShipper(ID);
        }

        public static int GetCurrentIden()
        {
            return ShipperData.SelectCurrentIden();
        }

    }
}
