using FastDeliveryGroup.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.DataAccessLayer
{
    class InvoiceData
    {
        public static bool InsertInvoice(Invoice inv)
        {
            string sql = "spAddInvoice";
            SqlParameter CustomerID = new SqlParameter("CustomerID", inv.CustomerID);
            SqlParameter ShipperID = new SqlParameter("ShipperID", inv.ShipperID);
            SqlParameter ShipmentDate = new SqlParameter("ShipmentDate", inv.ShipmentDate);
            SqlParameter Total = new SqlParameter("Total", inv.Total);
            SqlParameter Status = new SqlParameter("Status", inv.Status);
            SqlParameter StaffID = new SqlParameter("StaffID", inv.StaffID);
            SqlParameter Description = new SqlParameter("Description", inv.Description);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, CustomerID, ShipperID, ShipmentDate,
                                        StaffID,Total, Status, Description);

        }
        public static DataTable SelectAllInvoice()
        {
            DataTable dt = new DataTable();
            string sql = "spGetAllInvoice";
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, System.Data.CommandType.StoredProcedure);
            
            if (rd.HasRows)
            {
                dt.Load(rd);
            }
            return dt;
        }
        public static bool DeleteInvoice(int InvoiceID)
        {
            string DeleteInvoice = "DeleteInvoice";
            SqlParameter ID = new SqlParameter("@InvoiceID", InvoiceID);
            try
            {
                return DataProvider.ExecuteNonQuery(DeleteInvoice, CommandType.StoredProcedure, ID);
            }
            catch (SqlException se)
            {

                throw new Exception("Error: " + se.Message);
            }
        }
    }
}
