﻿using Project.Access_Data;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Project.Bussiness_Layer
{
    class ProductBL
    {
        public static bool AddProduct(Product a)
        {
            return ProductData.AddProduct(a);
        }
        public static bool DeleteProduct(int ProID)
        {
            return ProductData.DeleteProduct(ProID);
        }
        public static DataTable DisplayAllProduct()
        {
            return ProductData.DisplayAllProduct();
        }
        public static bool UpdateProduct(Product a)
        {
            return ProductData.UpdateProduct(a);
        }        
        public static Product GetbyProductName(string ProductName)
        {
            return ProductData.GetbyProductName(ProductName);
        }
        public static DataTable SearchProduct(string ProductName)
        {
            return ProductData.SearchProduct(ProductName);
        }
    }
}
