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
    class BillDetailData
    {
        public static bool AddBillDetails(BillDetail a)
        {
            string sql = "sp_InsertBillDetails";
            SqlParameter BillID = new SqlParameter("@BillID", a.BillID);
            SqlParameter ProID = new SqlParameter("@ProID", a.ProID);
            SqlParameter Quantity = new SqlParameter("@Quantity", a.Quantity);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, BillID, ProID, Quantity);
        }
        public static bool isExist(BillDetail a) {
            string sql = "sp_CheckExist";
            SqlParameter BillID = new SqlParameter("@BillID", a.BillID);
            SqlParameter ProID = new SqlParameter("@ProID", a.ProID);
            SqlDataReader dr= DataProvider.ExecuteQueryWithDataReader(sql, System.Data.CommandType.StoredProcedure, BillID, ProID);
            return dr.HasRows;
        }
        public static bool AddQuantity(BillDetail a)
        {
            string sql = "sp_AddQuantity";
            SqlParameter BillID = new SqlParameter("@BillID", a.BillID);
            SqlParameter ProID = new SqlParameter("@ProID", a.ProID);
            SqlParameter Quantity = new SqlParameter("@Quantity", a.Quantity);
            return DataProvider.ExecuteNonQuery(sql, CommandType.StoredProcedure, BillID, ProID, Quantity);
        }
    }
}   
