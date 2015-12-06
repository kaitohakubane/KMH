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
    class SupplierData
    {
        public static bool AddSupplier(Supplier a)
        {
            string sql = "sp_InsertSupplier";
            SqlParameter SupID = new SqlParameter("@SupID", a.SupID);
            SqlParameter SupName = new SqlParameter("@SupName", a.SupName);
            SqlParameter SupAddress = new SqlParameter("@SupAddress", a.SupAddress);
            SqlParameter SupDept = new SqlParameter("@SupDept", a.SupDept);
            SqlParameter SupPhone = new SqlParameter("@SupPhone", a.SupPhone);
            

            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, SupID, SupName, SupAddress, SupDept, SupPhone);
        }
        public static bool DeleteSupplier(int inSupID)
        {
            string sql = "sp_DeleteSupplier";
            SqlParameter SupID = new SqlParameter("@SupID", inSupID);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, SupID);
        }
        public static DataTable DisplayAllSupplier()
        {
            string sql = "sp_DisplayAllSupplier";
            return DataProvider.ExecuteQueryWithDataSet(sql, System.Data.CommandType.StoredProcedure).Tables[0];
        }
        public static bool UpdateSupplier(Supplier a)
        {
            string sql = "sp_UpdateSupplier";
            SqlParameter SupID = new SqlParameter("@SupID", a.SupID);
            SqlParameter SupName = new SqlParameter("@SupName", a.SupName);
            SqlParameter SupAddress = new SqlParameter("@SupAddress", a.SupAddress);
            SqlParameter SupDept = new SqlParameter("@SupDept", a.SupDept);
            SqlParameter SupPhone = new SqlParameter("@SupPhone", a.SupPhone);


            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, SupID, SupName, SupAddress, SupDept, SupPhone);
        }
        public static Supplier GetbySupplierName(string name)
        {
            string sql = "sp_GetSupplier";
            SqlParameter Name = new SqlParameter("@SupName", name);
            SqlDataReader dr = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.StoredProcedure, Name);
            if (dr.HasRows)
            {
                dr.Read();
                Supplier a = new Supplier();
                a.SupID = dr.GetInt32(0);
                a.SupName = dr.GetString(1);
                a.SupAddress = dr.GetString(2);
                a.SupDept = dr.GetInt32(3);
                a.SupPhone = dr.GetInt32(4);
                return a;
            }
            else
                return null;
        }
        public static DataTable SearchSupplier(string SupplierName)
        {
            string sql = "sp_SearchSupplier";
            SupplierName = '%' + SupplierName + '%';
            SqlParameter inSupplier = new SqlParameter("@SupName", SupplierName);
            return DataProvider.ExecuteQueryWithDataSet(sql, CommandType.StoredProcedure, inSupplier).Tables[0];
        }
    }
}
