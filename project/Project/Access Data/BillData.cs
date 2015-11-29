using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.Entity;
using Project.Provider;
using System.Data;
using System.Data.SqlClient;
namespace Project.Access_Data
{
    class BillData
    {
        public static bool AddBill(Bill a)
        {
            string sql = "sp_InsertBill";
            SqlParameter BillID = new SqlParameter("@BillID", a.BillID);
            SqlParameter CusID = new SqlParameter("@CusID", a.CusID);
            SqlParameter CodeID = new SqlParameter("@CodeID", a.CodeID);
            SqlParameter StaffID = new SqlParameter("@StaffID", a.StaffID);
            SqlParameter DateStart = new SqlParameter("@DateStart", a.DateStart);
            SqlParameter DateEnd = new SqlParameter("@DateEnd", a.DateEnd);

            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, BillID, CusID, CodeID, StaffID, DateStart, DateEnd);
        }
        public static bool DeleteBill(int inBillID)
        {
            string sql = "sp_DeleteBill";
            SqlParameter BillID = new SqlParameter("@BillID", inBillID);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, BillID);
        }
        public static DataTable DisplayAllBill()
        {
            string sql = "sp_DisplayAllBill";
            return DataProvider.ExecuteQueryWithDataSet(sql, System.Data.CommandType.StoredProcedure).Tables[0];
        }
    }
}
