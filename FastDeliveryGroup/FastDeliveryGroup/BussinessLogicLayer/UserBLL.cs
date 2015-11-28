using FastDeliveryGroup.DataAccessLayer;
using FastDeliveryGroup.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.BussinessLogicLayer
{
    class UserBLL
    {
        public static User GetUserByUName(string username)
        {
            return UserData.SelectByUserName(username);
        }
        public static bool AddUser(User user)
        {
            return UserData.AddUserName(user);
        }
        public static DataTable GetAllUser()
        {
            return UserData.SelectAllUser();
        }
        public static bool DeleteStaff(int ID)
        {
            return UserData.DeleteStaff(ID);
        }

    }
}
