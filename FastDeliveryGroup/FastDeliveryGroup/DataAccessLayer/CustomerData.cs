using FastDeliveryGroup.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.DataAccessLayer
{
    class CustomerData
    {
        public static DataTable SelectAllCustomer()
        {
            
            string sql = "spGetAllCustomer";
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, System.Data.CommandType.StoredProcedure);
            DataTable dt = new DataTable();
            dt.Load(rd);
            return dt;
        }
        public static bool InsertCustomer(Customer cus)
        {
            string sql = "AddCustomer";
            SqlParameter CustomerID = new SqlParameter("CustomerID",cus.CustomerID);
            SqlParameter Name = new SqlParameter("Name", cus.Name);
            SqlParameter Address = new SqlParameter("Address", cus.Address);
            SqlParameter Phone = new SqlParameter("Phone", cus.Phone);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, CustomerID,Name,Address,Phone);
        }
        public static List<Customer> SelectAll()
        {
            List<Customer> cusList = new List<Customer>();
            string SelectAllCus = "GetAllCustomer";
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(SelectAllCus, CommandType.StoredProcedure);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Customer r = new Customer()
                    {
                        CustomerID = rd.GetString(0),
                        Name = rd.GetName(1),
                        Address = rd.GetName(2),
                        Phone = rd.GetName(3)
                        
                    };
                    cusList.Add(r);
                }
            }
            return cusList.OrderBy(p => p.CustomerID).ToList();
        }
        //public static DataTable SelectAllCus()
        //{
        //    return DataProvider.ExecuteQueryWithDataSet("GetAllCustomer", CommandType.StoredProcedure).Tables[0];
        //    //nhan F10 nua no chay ra khoi ham nay, quay ve dong goi ham nay ben class kia   
        //}
        public static bool DeleteCustomer(string CustomerID)
        {
            string DeleteCustomer = "DeleteCustomer";
            SqlParameter ID = new SqlParameter("@CustomerID",CustomerID);
            try
            {
                return DataProvider.ExecuteNonQuery(DeleteCustomer, CommandType.StoredProcedure, ID);
            }
            catch (SqlException se)
            {

                throw new Exception("Error: " + se.Message);
            }
        }
    }
}
