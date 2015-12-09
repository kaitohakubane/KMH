using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project.Entity
{
    
    class Discount
    {
        private int mCodeID;        
        private int mRate;        
        private DateTime mDateStart;
        private DateTime mDateEnd;
        private bool misActive;
        public Discount()
        {

        }
        public Discount(int mCodeID, int mRate, DateTime mDateStart, DateTime mDateEnd, bool misActive)
        {
            this.mCodeID = mCodeID;            
            this.mRate = mRate;            
            this.mDateStart = mDateStart;
            this.mDateEnd = mDateEnd;
            this.misActive = misActive;
        }
        public bool isActive
        {
            get { return misActive; }
            set { misActive = value; }
        }
        public int CodeID
        {
            get
            {
                return mCodeID;
            }

            set
            {
                mCodeID = value;
            }
        }        

        public int Rate
        {
            get
            {
                return mRate;
            }

            set
            {
                mRate = value;
            }
        }    

        public DateTime DateStart
        {
            get
            {
                return mDateStart;
            }

            set
            {
                mDateStart = value;
            }
        }

        public DateTime DateEnd
        {
            get
            {
                return mDateEnd;
            }

            set
            {
                mDateEnd = value;
            }
        }
    }
}
