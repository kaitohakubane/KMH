using FastDeliveryGroup.DataAccessLayer;
using FastDeliveryGroup.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.BussinessLogicLayer
{
    public class ProductBLL
    {
        public static List<Product> GetAllProduct()
        {
            return ProductData.SelectAllProduct();
        }
        public static DataTable getAllProduct()
        {
            return ProductData.GetAllProducts();
        }
        public static bool InsertProduct(Product pro)
        {
            return ProductData.InsertProduct(pro);
        }
        public static bool DeleteProduct(int ID)
        {
            return ProductData.DeleteProduct(ID);
        }
        public static bool UpdateProductByID(Product pro)
        {
            return ProductData.UpdateProduct(pro);
        }
    }
}
