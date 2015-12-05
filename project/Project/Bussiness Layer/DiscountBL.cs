using Project.Access_Data;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Project.Bussiness_Layer
{
    class DiscountBL
    {
        public static bool AddDiscount(Discount a)
        {
            return DiscountData.AddDiscount(a);
        }
        public static bool DeleteDiscount(int DiscountID)
        {
            return DiscountData.DeleteDiscount(DiscountID);
        }
        public static DataTable DisplayAllDiscount()
        {
            return DiscountData.DisplayAllDiscount();
        }
        public static bool UpdateDiscount(Discount a)
        {
            return DiscountData.UpdateDiscount(a);
        }
        public static Discount GetbyDay(DateTime dateStart, DateTime dateEnd)
        {
            return DiscountData.GetbyDay(dateStart, dateEnd);
        }
    }
}
