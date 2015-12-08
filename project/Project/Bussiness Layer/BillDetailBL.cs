using Project.Access_Data;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Project.Bussiness_Layer
{
    class BillDetailBL
    {
        public static bool AddBillDetails(BillDetail a)
        {
            return BillDetailData.AddBillDetails(a);
        }
        public static bool isExist(BillDetail a)
        {
            return BillDetailData.isExist(a);
        }
        public static bool AddQuantity(BillDetail a)
        {
            return BillDetailData.AddQuantity(a);
        }
    }
}

