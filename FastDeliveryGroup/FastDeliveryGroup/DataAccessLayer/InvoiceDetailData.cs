using FastDeliveryGroup.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.DataAccessLayer
{
    class InvoiceDetailData
    {
        public static bool InsertDetail(InvoiceDetail d)
        {
            string sql = "spInsertInvoiceDetail";
            SqlParameter InvoiceID = new SqlParameter("@InvoiceID", d.InvoiceID);
            SqlParameter ProductID = new SqlParameter("@ProductID", d.ProductID);
            SqlParameter Quantity = new SqlParameter("@Quantity", d.Quantity);
            SqlParameter SubTotal = new SqlParameter("@SubTotal", d.SubTotal);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, InvoiceID,
                                            ProductID, Quantity, SubTotal);

        }

        public static int SelectCurrentIden()
        {
            string sql = "spCurrentIden";
            SqlParameter para = new SqlParameter("@table", "Invoice");
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, System.Data.CommandType.StoredProcedure, para);
            if (rd.HasRows)
            {
                rd.Read();
                if (!rd.IsDBNull(0))
                {
                    return rd.GetInt32(0);
                }
                
            }
            return 0;
        }
    }
}
