﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entity
{
    public class Staff
    {
        private string mStaffID;
        private string mStaffName;
        private string mStaffRole;
        private int mStaffAge;
        private float mStaffSalary;
        //private string mStaffUserName;
        private string mStaffPassword;
        private bool misActive;
        public Staff()
        {

        }
        public Staff(string mStaffID, string mStaffName, string mStaffRole, int mStaffAge, float mStaffSalary, string mStaffPassword, bool misActive)
        {
            this.mStaffID = mStaffID;
            this.mStaffName = mStaffName;
            this.mStaffRole = mStaffRole;
            this.mStaffAge = mStaffAge;
            this.mStaffSalary = mStaffSalary;
            //this.mStaffUserName = mStaffUserName;
            this.mStaffPassword = mStaffPassword;
            this.misActive = misActive;
        }

        public bool isActive
        {
            get { return misActive; }
            set { misActive = value; }
        }
        
        public string StaffID
        {
            get
            {
                return mStaffID;
            }

            set
            {
                mStaffID = value;
            }
        }

        public string StaffName
        {
            get
            {
                return mStaffName;
            }

            set
            {
                if (value == string.Empty)
                    throw new Exception("StaffName invalid.");
                mStaffName = value;
            }
        }

        public string StaffRole
        {
            get
            {
                return mStaffRole;
            }

            set
            {
                mStaffRole = value;
            }
        }

        public int StaffAge
        {
            get
            {
                return mStaffAge;
            }

            set
            {
                mStaffAge = value;
            }
        }

        public float StaffSalary
        {
            get
            {
                return mStaffSalary;
            }

            set
            {
                mStaffSalary = value;
            }
        }

        //public string StaffUserName
        //{
        //    get
        //    {
        //        return mStaffUserName;
        //    }

        //    set
        //    {
        //        if (value == string.Empty)
        //            throw new Exception("StaffUsername invalid.");
        //        mStaffUserName = value;
        //    }
        //}

        public string   StaffPassword
        {
            get
            {
                return mStaffPassword;
            }

            set
            {
                if (value == string.Empty)
                    throw new Exception("StaffPassword invalid.");
                mStaffPassword = value;
            }
        }
    }
}
