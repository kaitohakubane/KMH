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
    class ProductData
    {
        public static bool AddProduct(Product a)
        {
            string sql = "sp_InsertProduct";
            SqlParameter ProID = new SqlParameter("@ProID", a.ProID);
            SqlParameter ProName = new SqlParameter("@ProName", a.ProName);
            SqlParameter SupID = new SqlParameter("@SupID", a.SupID);
            SqlParameter Producer = new SqlParameter("@Producer", a.Producer);
            SqlParameter Origin = new SqlParameter("@Origin", a.Origin);
            SqlParameter InPrice = new SqlParameter("@InPrice", a.InPrice);
            SqlParameter OutPrice = new SqlParameter("@OutPrice", a.OutPrice);
            SqlParameter Quantity = new SqlParameter("@Quantity", a.Quantity);
            SqlParameter Type = new SqlParameter("@Type", a.Type);

            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, ProID, ProName, SupID, Producer, Origin, InPrice,OutPrice,Quantity,Type);
        }
        public static bool DeleteProduct(int inProID)
        {
            string sql = "sp_DeleteProduct";
            SqlParameter ProID = new SqlParameter("@ProID", inProID);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, ProID);
        }
        public static DataTable DisplayAllProduct()
        {
            string sql = "sp_DisplayAllProduct";
            return DataProvider.ExecuteQueryWithDataSet(sql, System.Data.CommandType.StoredProcedure).Tables[0];
        }
    }
}
