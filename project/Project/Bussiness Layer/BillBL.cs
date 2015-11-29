using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.Access_Data;
using Project.Entity;
using System.Data;
namespace Project.Bussiness_Layer
{
    class BillBL
    {
        public static bool AddBill(Bill a)
        {
            return BillData.AddBill(a);
        }
        public static bool DeleteBill(int StaID)
        {
            return BillData.DeleteBill(StaID);
        }
        public static DataTable DisplayAllBill()
        {
            return BillData.DisplayAllBill();
        }
        public static bool UpdateBill(Bill a)
        {
            return BillData.UpdateBill(a);
        }
    }
}
