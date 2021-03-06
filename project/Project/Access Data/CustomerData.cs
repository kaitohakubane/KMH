﻿using System;
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
            SqlParameter CusName = new SqlParameter("@CusName", a.CusName);
            SqlParameter CusAddress = new SqlParameter("@CusAddress", a.CusAddress);
            SqlParameter CusPhone = new SqlParameter("@CusPhone", a.CusPhone);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, CusName, CusAddress, CusPhone);
        }
        public static bool DeleteCustomer(int inCustomerID)
        {
            string sql = "sp_DeleteCustomer";
            SqlParameter CusID = new SqlParameter("@CustomerID", inCustomerID);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, CusID);
        }
        public static DataTable DisplayAllCus()
        {
            string sql = "sp_DisplayAllCus";
            return DataProvider.ExecuteQueryWithDataSet(sql, System.Data.CommandType.StoredProcedure).Tables[0];
        }
        public static bool UpdateCustomer(Customer a)
        {
            string sql = "sp_UpdateCustomer";
            SqlParameter CusID = new SqlParameter("@CusID", a.CusID);
            SqlParameter CusName = new SqlParameter("@CusName", a.CusName);
            SqlParameter CusAddress = new SqlParameter("@CusAddress", a.CusAddress);
            SqlParameter CusPhone = new SqlParameter("@CusPhone", a.CusPhone);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, CusID, CusName, CusAddress, CusPhone);
        }
        public static Customer GetbyCustomerName(string name)
        {
            string sql = "sp_GetCustomer";
            SqlParameter Name = new SqlParameter("@CustomerName", name);
            SqlDataReader dr = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.StoredProcedure, Name);
            if (dr.HasRows)
            {
                dr.Read();
                Customer a = new Customer();
                a.CusID = dr.GetInt32(0);
                a.CusName = dr.GetString(1);
                a.CusAddress = dr.GetString(2);
                a.CusPhone = dr.GetString(3);
                return a;
            }
            else
                return null;
        }
        public static DataTable SearchCustomer(string CustomerName)
        {
            string sql = "sp_SearchCustomer";
            CustomerName = '%' + CustomerName + '%';
            SqlParameter inCustomer = new SqlParameter("@CusName", CustomerName);
            return DataProvider.ExecuteQueryWithDataSet(sql, CommandType.StoredProcedure, inCustomer).Tables[0];
        }

        public static bool GetByID(int cusID)
        {
            string sql = "sp_GetCusbyID";
            SqlParameter CusID = new SqlParameter("@CusID", cusID);
            SqlDataReader dr= DataProvider.ExecuteQueryWithDataReader(sql, CommandType.StoredProcedure, CusID);
            return dr.HasRows;
        }
        public static DataTable GetCusByID(int cusID)
        {
            string sql = "sp_GetCusbyID";
            SqlParameter CusID = new SqlParameter("@CusID", cusID);
            return DataProvider.ExecuteQueryWithDataSet(sql, CommandType.StoredProcedure, CusID).Tables[0];
        }
    }
}
