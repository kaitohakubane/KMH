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
    }
}
