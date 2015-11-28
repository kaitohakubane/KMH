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
    class UserData
    {
        public static User SelectByUserName(string username)
        {
            string sql = "spSelectUserByUName";
            SqlParameter UserName = new SqlParameter("UserName", username);
            SqlDataReader dr = DataProvider.ExecuteQueryWithDataReader(sql, System.Data.CommandType.StoredProcedure,
                            UserName);
            if (dr.HasRows)
            {
                dr.Read();
                User a = new User();
                a.FullName = dr.GetString(0);
                a.UserID = dr.GetInt32(1);
                a.UserName = dr.GetString(2);
                a.Password = dr.GetString(3);
                a.Role = dr.GetBoolean(4);
                a.Phone = dr.GetString(5);
                return a;
            }
            else
            {
                return null;
            }
        }
        public static bool AddUserName(User user)
        {
            string sql = "AddUser";
            SqlParameter FullName = new SqlParameter("FullName", user.FullName);
            SqlParameter UserName = new SqlParameter("UserName", user.UserName);
            SqlParameter PassWord = new SqlParameter("PassWord", user.Password);
            SqlParameter Phone = new SqlParameter("Phone", user.Phone);
            SqlParameter Role = new SqlParameter("Role", user.Role);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, FullName, UserName, PassWord, Phone, Role);
        }
        public static List<User> SelectAll()
        {
            List<User> UserList = new List<User>();
            string getAllUser = "GetAllUser";
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(getAllUser, CommandType.StoredProcedure);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    User r = new User()
                    {
                        FullName = rd.GetString(0),
                        UserID = rd.GetInt32(1),
                        UserName = rd.GetString(2),
                        Password = rd.GetString(3),
                        Role = rd.GetBoolean(4),
                        Phone = rd.GetString(5)           
                    };
                    UserList.Add(r);
                }
            }
            return UserList.OrderBy(p => p.UserID).ToList();
        }
        public static DataTable SelectAllUser()
        {
            return DataProvider.ExecuteQueryWithDataSet("GetAllUser", CommandType.StoredProcedure).Tables[0];
            //nhan F10 nua no chay ra khoi ham nay, quay ve dong goi ham nay ben class kia   
        }
        public static bool DeleteStaff(int UserID)
        {
            string DeleteStaff = "DeleteStaff";
            SqlParameter ID = new SqlParameter("@UserID", UserID);
            try
            {
                return DataProvider.ExecuteNonQuery(DeleteStaff, CommandType.StoredProcedure, ID);
            }
            catch (SqlException se)
            {

                throw new Exception("Error: " + se.Message);
            }
        }
    }
}
