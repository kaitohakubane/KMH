﻿using FastDeliveryGroup.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.DataAccessLayer
{
    class ShipperData
    {
        public static bool AddShipperName(Shipper shipper)
        {
            string sql = "AddShipper";
            SqlParameter Name = new SqlParameter("Name", shipper.Name);
            SqlParameter PlaceID = new SqlParameter("PlaceID", shipper.PlaceID);
            SqlParameter Phone = new SqlParameter("Phone", shipper.Phone);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure,Name,PlaceID,Phone);
        }
        public static List<Shipper> SelectAllShipper()
        {
            List<Shipper> list = new List<Shipper>();
            string sql = "spSelectAllShipper";
            SqlDataReader rd=  DataProvider.ExecuteQueryWithDataReader(sql, System.Data.CommandType.StoredProcedure);
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    Shipper a = new Shipper();
                    a.ShipperID = rd.GetInt32(0);
                    a.Name = rd.GetString(1);
                    a.PlaceID = rd.GetInt32(2);
                    a.Phone = rd.GetString(3);
                    list.Add(a);
                }
            }
            return list;
        }
        public static DataTable SelectAll()
        {
            return DataProvider.ExecuteQueryWithDataSet("GetAllShipper", CommandType.StoredProcedure).Tables[0];
        }
        public static bool DeleteShipper(int ShipperID)
        {
            string DeleteShipper = "DeleteShipper";
            SqlParameter ID = new SqlParameter("@ShipperID", ShipperID);
            try
            {
                return DataProvider.ExecuteNonQuery(DeleteShipper, CommandType.StoredProcedure, ID);
            }
            catch (SqlException se)
            {

                throw new Exception("Error: " + se.Message);
            }
        }
    }
}
