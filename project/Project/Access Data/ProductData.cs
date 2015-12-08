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

        public static bool GetbyProductID(int productID)
        {
            string sql = "sp_GetByProID";
            SqlParameter ProID = new SqlParameter("@ProID", productID);
            SqlDataReader dr= DataProvider.ExecuteQueryWithDataReader(sql, CommandType.StoredProcedure, ProID);
            return dr.HasRows;
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
        public static bool UpdateProduct(Product a)
        {
            string sql = "sp_UpdateProduct";
            SqlParameter ProID = new SqlParameter("@ProID", a.ProID);
            SqlParameter ProName = new SqlParameter("@ProName", a.ProName);
            SqlParameter SupID = new SqlParameter("@SupID", a.SupID);
            SqlParameter Producer = new SqlParameter("@Producer", a.Producer);
            SqlParameter Origin = new SqlParameter("@Origin", a.Origin);
            SqlParameter InPrice = new SqlParameter("@InPrice", a.InPrice);
            SqlParameter OutPrice = new SqlParameter("@OutPrice", a.OutPrice);
            SqlParameter Quantity = new SqlParameter("@Quantity", a.Quantity);
            SqlParameter Type = new SqlParameter("@Type", a.Type);

            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, ProID, ProName, SupID, Producer, Origin, InPrice, OutPrice, Quantity, Type);
        }
        public static Product GetbyProductName(string name)
        {
            string sql = "sp_GetProduct";
            SqlParameter Name = new SqlParameter("@ProName", name);
            SqlDataReader dr = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.StoredProcedure, Name);
            if (dr.HasRows)
            {
                dr.Read();
                Product a = new Product();
                a.ProID = dr.GetInt32(0);
                a.ProName = dr.GetString(1);
                a.SupID = dr.GetInt32(2);
                a.Producer = dr.GetString(3);
                a.Origin = dr.GetString(4);
                a.InPrice = dr.GetInt32(5);
                a.OutPrice = dr.GetInt32(6);
                a.Quantity = dr.GetInt32(7);
                a.Type = dr.GetString(8);
                return a;
            }
            else
                return null;
        }
        public static DataTable SearchProduct(string ProductName)
        {
            string sql = "sp_SearchProduct";
            ProductName = '%' + ProductName + '%';
            SqlParameter inProduct = new SqlParameter("@ProName", ProductName);
            return DataProvider.ExecuteQueryWithDataSet(sql, CommandType.StoredProcedure, inProduct).Tables[0];
        }
        
    }
}
