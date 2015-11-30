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
        public static bool UpdateBill(Bill a)
        {
            string sql = "sp_UpdateBill";
            SqlParameter BillID = new SqlParameter("@BillID", a.BillID);
            SqlParameter CusID = new SqlParameter("@CusID", a.CusID);
            SqlParameter CodeID = new SqlParameter("@CodeID", a.CodeID);
            SqlParameter StaffID = new SqlParameter("@StaffID", a.StaffID);
            SqlParameter DateStart = new SqlParameter("@DateStart", a.DateStart);
            SqlParameter DateEnd = new SqlParameter("@DateEnd", a.DateEnd);

            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, BillID, CusID, CodeID, StaffID, DateStart, DateEnd);
        }
        public static Bill GetbyDay(DateTime dayStart, DateTime dayEnd)
        {
            string sql = "sp_GetBill";
            SqlParameter DayStart = new SqlParameter("@DayStart", dayStart);
            SqlParameter DayEnd = new SqlParameter("@DayEnd", dayEnd);

            SqlDataReader dr = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.StoredProcedure, DayStart, DayEnd);
            if (dr.HasRows)
            {
                dr.Read();
                Bill a = new Bill();
                a.BillID = dr.GetInt32(0);
                a.CusID = dr.GetInt32(1);
                a.CodeID = dr.GetInt32(2);
                a.StaffID = dr.GetInt32(3);
                a.DateStart = dr.GetDateTime(4);
                a.DateEnd = dr.GetDateTime(5);
                return a;
            }
            else
                return null;
        }
    }
}
