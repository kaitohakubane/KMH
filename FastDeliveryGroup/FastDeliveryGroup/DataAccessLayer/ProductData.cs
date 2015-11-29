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
    class ProductData
    {
        public static bool InsertProduct(Product pro)
        {
            string sql = "spInsertProduct";
            SqlParameter Name = new SqlParameter("Name", pro.Name);
            SqlParameter Price = new SqlParameter("Price", pro.Price);
            return DataProvider.ExecuteNonQuery(sql, System.Data.CommandType.StoredProcedure, Name, Price);
        }
        
        public static List<Product> SelectAllProduct()
        {
            List<Product> list = new List<Product>();
            string sql = "spGetAllProduct";
            try
            {
                SqlDataReader rd = DataProvider.ExecuteQueryWithDataReader(sql, System.Data.CommandType.StoredProcedure);
                if (rd.HasRows)
                {
                    while(rd.Read())
                    {
                        Product p = new Product()
                        {
                            ProductID = rd.GetInt32(0),
                            Name = rd.GetString(1),
                            Price = rd.GetDouble(2)

                        };
                        list.Add(p);
                    }
                }
            }catch(Exception g)
            {
                throw new Exception(g.Message);
            }
            return list;
        }
        public static DataTable GetAllProducts()
        {
            return DataProvider.ExecuteQueryWithDataSet("spGetAllProduct",System.Data.CommandType.StoredProcedure).Tables[0];
        }

        public static bool DeleteProduct(int ProductID)
        {
            string DeleteProduct = "spDeleteProduct";
            SqlParameter ID = new SqlParameter("@ProductID", ProductID);
            try
            {
                return DataProvider.ExecuteNonQuery(DeleteProduct, CommandType.StoredProcedure, ID);
            }
            catch (SqlException se)
            {

                throw new Exception("Error: " + se.Message);
            }
        }
        public static bool UpdateProduct(Product Pro)
        {
          
            string sql = "spUpdateProduct";
            SqlParameter ProID = new SqlParameter("ProductID", Pro.ProductID);
            SqlParameter Name = new SqlParameter("Name", Pro.Name);
            SqlParameter Price = new SqlParameter("Price", Pro.Price);
            
            return DataProvider.ExecuteNonQuery(sql, CommandType.StoredProcedure, ProID,Name,Price);

        }
    }
    }

