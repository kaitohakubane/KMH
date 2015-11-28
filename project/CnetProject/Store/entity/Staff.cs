using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.entity
{
    public class Staff
    {
        private int mStaffID;
        private string mStaffName;
        private string mStaffRole;
        private int mStaffAge;
        private float mStaffSalary;
        private string mStaffUserName;
        private string mStaffPassword;
     

        public int StaffID
        {
            get { return mStaffID; }
            set { mStaffID = value; }
        }
        public string StaffName
        {
            get { return mStaffName; }
            set
            {
                if (value == string.Empty)
                    throw new Exception("StaffName invalid.");

                mStaffName = value;
            }
        }
        public string StaffRole
        {
            get { return mStaffRole; }
            set
            {
                if (value == string.Empty)
                    throw new Exception("StaffRole invalid.");

                mStaffRole = value;
            }
        }
        public int StaffAge
        {
            get { return mStaffAge; }
            set { mStaffAge = value; }
        }
        public float StaffSalary
        {
            get { return mStaffSalary; }
            set { mStaffSalary = value; }
        }
        public string StaffUserName
        {
            get { return mStaffUserName; }
            set
            {
                if (value == string.Empty)
                    throw new Exception("StaffPassword invalid.");

                mStaffUserName = value;
            }
        }
        public string StaffPassword
        {
            get { return mStaffPassword; }
            set
            {
                if (value == string.Empty)
                    throw new Exception("StaffPassword invalid.");

                mStaffPassword = value;
            }
        }
    }
}
