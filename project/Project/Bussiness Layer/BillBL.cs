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

        public static int GetMaxID()
        {
            return BillData.GetMaxID();
        }

        public static DataTable GetProductInBill(int v)
        {
            return BillData.GetProductInBill(v);
        }
        public static DataTable PrintDay(DateTime d1, DateTime d2)
        {
            return BillData.PrintDay(d1, d2);
        }
        public static DataTable ReportMonth(int d1)
        {
            return BillData.ReportMonth(d1);
        }
        public static DataTable ReportYear()
        {
            return BillData.ReportYear();
        }
    }
}
