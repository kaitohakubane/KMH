using Project.Entity;
using Project.Provider;
using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Access_Data
{
    class StaffData
    {
        public static bool AddStaff(Staff a)
        {
            //sql này là trên procedure
            string sql = "sp_InsertStaff";
            SqlParameter StaffID = new SqlParameter("@StaffID", a.StaffID);
            SqlParameter StaffName = new SqlParameter("@StaffName", a.StaffName);
            SqlParameter StaffRole = new SqlParameter("@StaffRole", a.StaffRole);
            SqlParameter StaffAge = new SqlParameter("@StaffAge", a.StaffAge);
            SqlParameter StaffSalary = new SqlParameter("@StaffSalary", a.StaffSalary);
            //SqlParameter StaffUserName = new SqlParameter("@StaffUserName", a.StaffUserName);
            SqlParameter StaffPassword = new SqlParameter("@StaffPassword", a.StaffPassword);
            //ExecuteNonQuery dung` cho insert update delete, thứ tự truyền tham số phải đúng với định nghĩa trong stored procedure
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure,StaffID, StaffName, StaffRole, StaffAge, StaffSalary, StaffPassword);
        }
        public static bool DeleteStaff(string inStaffID)
        {
            string sql = "sp_DeleleStaff";
            SqlParameter StaffID = new SqlParameter("@StaffID", inStaffID);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, StaffID);
        }
        public static DataTable DisplayAllStaff()
        {
            string sql = "sp_DisplayAllStaff";
            //Lấy về 1 bảng nên Tables[0]
            return DataProvider.ExecuteQueryWithDataSet(sql, System.Data.CommandType.StoredProcedure).Tables[0];
        }
        public static bool UpdateStaff(Staff a)
        {
            //sql này là trên procedure
            string sql = "sp_UpdateStaff";
            SqlParameter StaffID = new SqlParameter("@StaffID", a.StaffID);
            SqlParameter StaffName = new SqlParameter("@StaffName", a.StaffName);
            SqlParameter StaffRole = new SqlParameter("@StaffRole", a.StaffRole);
            SqlParameter StaffAge = new SqlParameter("@StaffAge", a.StaffAge);
            SqlParameter StaffSalary = new SqlParameter("@StaffSalary", a.StaffSalary);
            //SqlParameter StaffUserName = new SqlParameter("@StaffUserName", a.StaffUserName);
            SqlParameter StaffPassword = new SqlParameter("@StaffPassword", a.StaffPassword);
            //ExecuteNonQuery dung` cho insert update delete, thứ tự truyền tham số phải đúng với định nghĩa trong stored procedure
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure,StaffID, StaffName, StaffRole, StaffAge, StaffSalary, StaffPassword);
        }
        public static Staff GetbyID(string id)
        {
            string sql = "sp_Login";
            SqlParameter ID = new SqlParameter("@UStaffID", id);
            SqlDataReader dr = DataProvider.ExecuteQueryWithDataReader(sql, CommandType.StoredProcedure, ID);            
            if (dr.HasRows)
            {
                dr.Read();
                Staff a = new Staff();
                a.isActive = dr.GetBoolean(6);
                if (a.isActive)
                {
                    a.StaffID = dr.GetString(0);
                    a.StaffName = dr.GetString(1);
                    a.StaffRole = dr.GetInt32(2);
                    a.StaffAge = dr.GetInt32(3);
                    a.StaffSalary = dr.GetInt32(4);
                    //a.StaffUserName = dr.GetString(5);
                    a.StaffPassword = dr.GetString(5);
                    return a;
                }
                else
                    return null;
            }
            else
                return null;
        }
        public static DataTable SearchStaff(string StaffName)
        {
            string sql = "sp_SearchStaff";
            StaffName = '%' + StaffName + '%';
            SqlParameter inStaff = new SqlParameter("@StaffName", StaffName);
            return DataProvider.ExecuteQueryWithDataSet(sql, CommandType.StoredProcedure, inStaff).Tables[0];
        }
    }
}
