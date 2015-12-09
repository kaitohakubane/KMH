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
            SqlParameter Rate = new SqlParameter("@Rate", a.Rate);
            SqlParameter DateStart = new SqlParameter("@DateStart", a.DateStart);
            SqlParameter DateEnd = new SqlParameter("@DateEnd", a.DateEnd);

            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, Rate, DateStart, DateEnd);
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
        public static bool UpdateDiscount(Discount a)
        {
            string sql = "sp_UpdateDiscount";
            SqlParameter Rate = new SqlParameter("@Rate", a.Rate);
            SqlParameter DateStart = new SqlParameter("@DateStart", a.DateStart);
            SqlParameter DateEnd = new SqlParameter("@DateEnd", a.DateEnd);

            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, Rate,DateStart, DateEnd);
        }
        public static Discount GetbyDay(DateTime dayStart, DateTime dayEnd)
        {
            string sql = "sp_GetDiscount";
            SqlParameter DayStart = new SqlParameter("@DayStart", dayStart);
            SqlParameter DayEnd = new SqlParameter("@DayEnd", dayEnd);

            SqlDataReader dr = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.StoredProcedure, DayStart, DayEnd);
            if (dr.HasRows)
            {
                dr.Read();
                Discount a = new Discount();
                a.CodeID = dr.GetInt32(0);
                a.Rate = dr.GetInt32(1);
                a.DateStart = dr.GetDateTime(2);
                a.DateEnd = dr.GetDateTime(3);
                return a;
            }
            else
                return null;
        }
    }
}
