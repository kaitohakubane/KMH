using Project.Access_Data;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Project.Bussiness_Layer
{
    class BillBL
    {
        public static bool AddBill(Bill a)
        {
            return BillBL.AddBill(a);
        }
        public static bool DeleteBill(int StaID)
        {
            return BillBL.DeleteBill(StaID);
        }
        public static DataTable DisplayAllBill()
        {
            return BillBL.DisplayAllBill();
        }
        public static bool UpdateBill(Bill a)
        {
            return BillBL.UpdateBill(a);
        }

    }
}
