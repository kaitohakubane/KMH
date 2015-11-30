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
    class CustomerData
    {
        public static bool AddCustomer(Customer a)
        {
            string sql = "sp_InsertCustomer";
            SqlParameter CusID = new SqlParameter("@CusID", a.CusID);
            SqlParameter CusName = new SqlParameter("@CusName", a.CusName);
            SqlParameter CusAddress = new SqlParameter("@CusAddress", a.CusAddress);
            SqlParameter CusPhone = new SqlParameter("@CusPhone", a.CusPhone);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, CusID, CusName, CusAddress, CusPhone);
        }
        public static bool DeleteCustomer(int inCustomerID)
        {
            string sql = "sp_DeleteCustomer";
            SqlParameter CusID = new SqlParameter("@CusID", inCustomerID);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, CusID);
        }
        public static DataTable DislayAllCus()
        {
            string sql = "sp_DisplayAllCus";
            return DataProvider.ExecuteQueryWithDataSet(sql, System.Data.CommandType.StoredProcedure).Tables[0];
        }
    }
}
