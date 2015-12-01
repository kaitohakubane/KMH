using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.Access_Data;
using Project.Entity;
using System.Data;
namespace Project.Bussiness_Layer
{
    class StaffBL
    {
        public static bool AddStaff(Staff a)
        {
            return StaffData.AddStaff(a);
        }
        public static bool DeleteStaff(string StaID)
        {
            return StaffData.DeleteStaff(StaID);
        }
        public static DataTable DisplayAllStaff()
        {
            return StaffData.DisplayAllStaff();
        }
        public static bool UpdateStaff(Staff a)
        {
            return StaffData.UpdateStaff(a);
        }
        public static Staff GefbyID(string ID)
        {
            return StaffData.GetbyID(ID);
        }
    }
}
