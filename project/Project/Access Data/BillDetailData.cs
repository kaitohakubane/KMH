using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Project.Entity;
using Project.Provider;
using System.Data;
using System.Data.SqlClient;
namespace Project.Access_Data
{
    class BillDetailData
    {
        public static bool AddBillDetails(BillDetail a)
        {
            string sql = "sp_InsertBill";
            SqlParameter BillID = new SqlParameter("@StaffID", a.BillID);
            SqlParameter ProID = new SqlParameter("@CodeID", a.ProID);
            SqlParameter Quantity = new SqlParameter("@Date", a.Quantity);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, BillID, ProID, Quantity);
        }
    }
}
