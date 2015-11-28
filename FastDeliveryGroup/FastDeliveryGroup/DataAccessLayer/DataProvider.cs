    using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.DataAccessLayer
{
    class DataProvider
    {
        public static String GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ShipperDB"].ConnectionString;
        }


        public static SqlDataReader ExecuteQueryWithDataReader(string strSQL,
            CommandType cmdType, params SqlParameter[] param)
        {
            SqlDataReader dr = null;
            try
            {

                SqlConnection cnn = new SqlConnection(GetConnectionString());
                    SqlCommand cmd = new SqlCommand(strSQL, cnn);
                    cmd.CommandType = cmdType;
                    cmd.Parameters.AddRange(param);
                    cnn.Open();
                    dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    return dr;
                
            }
            catch (Exception g)
            {
                throw new Exception(g.Message);
            }
        }

        public static bool ExecuteNonQuery(string strSQL, CommandType cmdType, params SqlParameter[] paramList)
        {
            bool result = false;
            try
            {
                using(SqlConnection cnn = new SqlConnection(GetConnectionString()))
                {
                    SqlCommand cmd = new SqlCommand(strSQL, cnn);
                    cmd.CommandType = cmdType;
                    cmd.Parameters.AddRange(paramList);
                    cnn.Open();
                    result = cmd.ExecuteNonQuery() > 0;
                }
            }catch(Exception g)
            {
                throw new Exception("Error: " + g.Message);
            }
            return result;
        }
        public static DataSet ExecuteQueryWithDataSet(string strSQL, CommandType cmdType,params SqlParameter[] param)
        {
            SqlConnection cnn = new SqlConnection(GetConnectionString());
            SqlCommand cmd = new SqlCommand(strSQL, cnn);
            cmd.CommandType = cmdType;
            cmd.Parameters.AddRange(param);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;//test trong day neu khong co loi thi ra, vi du dong Dataset, sau khi dung ham Fill xong thi se co ket qua khac
            //nhan vao day de xem nhung thu trong dataset ds, vi cau select trong SP chi lay ve 1 table nen no ghi ro~ count cua Table la 1
            // Table vua lay duoc co 2 column ID voi Name ==> moi thu binh thuong
        }

        //public static int ExecuteQueryForCurIden(string table, CommandType cmdType, SqlParameter para)
        //{
        //    int count = 0;
        //    using(SqlConnection cnn = new SqlConnection(GetConnectionString()))
        //    {
        //        SqlCommand cmd = new SqlCommand(table, cnn);
        //        cmd.CommandType = cmdType;
        //        cmd.Parameters.Add(para);
        //        cnn.Open();
        //        SqlDataReader dr = cmd.ExecuteReader();

        //    }
        //}

    }
}
