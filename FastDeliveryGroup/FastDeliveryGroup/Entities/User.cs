using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.Entities
{
    public class User
    {

        private string mUserName;

        public string UserName
        {
            get { return mUserName; }
            set { mUserName = value; }
        }

        private int mUserID;

        public int UserID
        {
            get { return mUserID; }
            set { mUserID = value; }
        }

        private string mFullName;

        public string FullName
        {
            get { return mFullName; }
            set { mFullName = value; }
        }

        private string mPassword;

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        private bool mRole;

        public bool Role
        {
            get { return mRole; }
            set { mRole = value; }
        }

        private string mPhone;

        public User(string userName, int userID)
        {
            UserName = userName;
            UserID = userID;
        }

        public string Phone
        {
            get { return mPhone; }
            set { mPhone = value; }
        }

        public User()
        {

        }
    }
}
