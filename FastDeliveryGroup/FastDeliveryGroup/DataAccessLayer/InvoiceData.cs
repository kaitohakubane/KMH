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
            string DeleteInvoice = "spDeleteInvoice";
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
        public static DataTable SelectInvoiceByDay(DateTime d)
        {
            DataTable dt = new DataTable();
            SqlParameter date = new SqlParameter("@date", d);
            string sql = "spGetInvoiceByDay";
            using (SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, System.Data.CommandType.StoredProcedure, date))
            {

                if (rd.HasRows)
                {
                    dt.Load(rd);
                }
            }
            return dt;
        }

        public static DataTable SelectInvoiceByMonth(string sql, int m, int y)
        {
            DataTable dt = new DataTable();
            SqlParameter month = new SqlParameter("@month", m);
            SqlParameter year = new SqlParameter("@year", y);
            using (SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, System.Data.CommandType.StoredProcedure, month, year))
            {

                if (rd.HasRows)
                {
                    dt.Load(rd);
                }
            }
            return dt;
        }

        public static bool UpdateInvoice(Invoice inv)
        {
            string sql = "spUpdateInvoice";
            SqlParameter InvoiceID = new SqlParameter("InvoiceID", inv.InvoiceID);
            SqlParameter ShipperID = new SqlParameter("ShipperID", inv.ShipperID);
            SqlParameter Description = new SqlParameter("Description", inv.Description);
            SqlParameter ShipmentDate = new SqlParameter("ShipmentDate", inv.ShipmentDate);
            return DataProvider.ExecuteNonQuery(sql, CommandType.StoredProcedure, InvoiceID, ShipperID, ShipmentDate, Description);

        }
    }
}
