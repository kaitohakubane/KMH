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
    class DiscountData
    {
        public static bool AddDiscount(Discount a)
        {
            string sql = "sp_InsertDiscount";
            SqlParameter CodeID = new SqlParameter("@CodeID", a.CodeID);
            SqlParameter Type = new SqlParameter("@Type", a.Type);
            SqlParameter Rate = new SqlParameter("@Rate", a.Rate);
            SqlParameter ProIDGift = new SqlParameter("@ProIDGift", a.ProIDGift);
            SqlParameter DateStart = new SqlParameter("@DateStart", a.DateStart);
            SqlParameter DateEnd = new SqlParameter("@DateEnd", a.DateEnd);

            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, CodeID, Type, Rate, ProIDGift, DateStart, DateEnd);
        }
        public static bool DeleteDiscount(int inCodeID)
        {
            string sql = "sp_DeleteDiscount";
            SqlParameter CodeID = new SqlParameter("@CodeID", inCodeID);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, CodeID);
        }
        public static DataTable DisplayAllDiscount()
        {
            string sql = "sp_DisplayAllDiscount";
            return DataProvider.ExecuteQueryWithDataSet(sql, System.Data.CommandType.StoredProcedure).Tables[0];
        }
    }
}
