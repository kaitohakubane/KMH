using FastDeliveryGroup.Entities;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FastDeliveryGroup.DataAccessLayer
{
    class DistrictData
    {
        public static bool InsertDistrict(District dis)
        {
            string sql = "spAddDistrict";
            SqlParameter NameOfDistrict = new SqlParameter("Name", dis.NameOfDistrict);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, NameOfDistrict);
        }
        public static List<District> SelectAll()
        {
            List<District> list = new List<District>();
            string spSelectAll = "spGetAllDistrict";
            SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(spSelectAll, CommandType.StoredProcedure);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    District r = new District()
                    {
                        DistrictID = rd.GetInt32(0),
                        NameOfDistrict = rd.GetString(1)
                    };
                    list.Add(r);
                }
            }
            return list.OrderBy(p => p.DistrictID).ToList();
        }
        public static DataTable SelectAllDistrict()
        {
            return DataProvider.ExecuteQueryWithDataSet("spGetAllDistrict", CommandType.StoredProcedure).Tables[0];  
            //nhan F10 nua no chay ra khoi ham nay, quay ve dong goi ham nay ben class kia   
        }
        public static bool DeleteDistrict(int DistrictID)
        {
            string DeleteDistrict = "spDeleteDistrict";
            SqlParameter ID = new SqlParameter("@PlaceID", DistrictID);
            try
            {
                return DataProvider.ExecuteNonQuery(DeleteDistrict, CommandType.StoredProcedure, ID);
            }
            catch (SqlException se)
            {

                throw new Exception("Error: " + se.Message);
            }
        }

        public static int SelectCurrentIden()
        {
            string sql = "spCurrentIden";
            SqlParameter para = new SqlParameter("@table", "Place");
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
