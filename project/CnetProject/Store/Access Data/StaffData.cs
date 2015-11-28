using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.entity;
using System.Data.SqlClient;
using Store.Provider;
using System.Data;
namespace Store.Access_Data
{
    class StaffData
    {
        public static bool AddStaff(Staff a){
            //sql này là trên procedure
            string sql="sp_InsertStaff";
            SqlParameter StaffName= new SqlParameter("@StaffName",a.StaffName);
            SqlParameter StaffRole= new SqlParameter("@StaffRole",a.StaffRole);
            SqlParameter StaffAge= new SqlParameter("@StaffAge",a.StaffRole);
            SqlParameter StaffSalary=new SqlParameter("@StaffSalary",a.StaffSalary);
            SqlParameter StaffUserName=new SqlParameter("@StaffUserName",a.StaffUserName);
            SqlParameter StaffPassword=new SqlParameter("@StaffPassword",a.StaffPassword);
            //ExecuteNonQuery dung` cho insert update delete, thứ tự truyền tham số phải đúng với định nghĩa trong stored procedure
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, StaffName, StaffRole, StaffAge, StaffSalary, StaffUserName, StaffPassword);
        }
        public static bool DeleteStaff(int inStaffID)
        {
            string sql = "sp_DeleteStaff";
            SqlParameter StaffID = new SqlParameter("@StaffID", inStaffID);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, StaffID);
        }
        public static DataTable DisplayAllStaff()
        {
            string sql="sp_DisplayAllStaff";
            //Lấy về 1 bảng nên Tables[0]
            return DataProvider.ExecuteQueryWithDataSet(sql, System.Data.CommandType.StoredProcedure).Tables[0];
        }

    }
}
