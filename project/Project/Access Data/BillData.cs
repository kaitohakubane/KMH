using Project.Entity;
using Project.Provider;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Project.Access_Data
{
    class BillData
    {
        public static bool AddBill(Bill a)
        {
            string sql = "sp_InsertBill";
            SqlParameter StaffID = new SqlParameter("@StaffID", a.StaffID);
            SqlParameter CodeID = new SqlParameter("@CodeID", a.CodeID);
            SqlParameter Date = new SqlParameter("@Date", a.Date);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, StaffID, CodeID, Date);
        }
        public static bool DeleteBill(int inBillID)
        {
            string sql = "sp_DeleteBill";
            SqlParameter BillID = new SqlParameter("@BillID", inBillID);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, BillID);
        }
        public static DataTable PrintDay(DateTime date1, DateTime date2)
        {
            string sql = "sp_PrintDay";
            SqlParameter d1 = new SqlParameter("@Date1", date1);
            SqlParameter d2 = new SqlParameter("@Date2", date2);
            return DataProvider.ExecuteQueryWithDataSet(sql, System.Data.CommandType.StoredProcedure, d1, d2).Tables[0];
        }
        public static DataTable GetProductInBill(int v)
        {
            string sql = "sp_GetProductInBill";
            SqlParameter BillID = new SqlParameter("@BillID", v);
            return DataProvider.ExecuteQueryWithDataSet(sql, CommandType.StoredProcedure, BillID).Tables[0];
        }

        public static int GetMaxID()
        {
            string sql = "sp_GetMaxID";
            SqlDataReader dr = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.StoredProcedure);
            dr.Read();
            return dr.GetInt32(0);
        }

        public static DataTable DisplayAllBill()
        {
            string sql = "sp_DisplayAllBill";
            return DataProvider.ExecuteQueryWithDataSet(sql, System.Data.CommandType.StoredProcedure).Tables[0];
        }
        public static bool UpdateBill(Bill a)
        {
            string sql = "sp_UpdateBill";
            SqlParameter StaffID = new SqlParameter("@StaffID", a.StaffID);
            SqlParameter CodeID = new SqlParameter("@CodeID", a.CodeID);
            SqlParameter Date = new SqlParameter("@Date", a.Date);
            SqlParameter CusID = new SqlParameter("@CusID", a.CusID);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, StaffID, CodeID, Date, CusID);
        }
        public static Bill GetbyDay(DateTime date)
        {
            string sql = "sp_GetBill";
            SqlParameter Date = new SqlParameter("@Date", date);
            SqlDataReader dr = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.StoredProcedure, Date);
            if (dr.HasRows)
            {
                dr.Read();
                Bill a = new Bill();
                a.BillID = dr.GetInt32(0);
                a.CusID = dr.GetInt32(1);
                a.CodeID = dr.GetInt32(2);
                a.StaffID = dr.GetString(3);
                a.Date = dr.GetDateTime(4);
                return a;
            }
            else
                return null;
        }
    }
}

