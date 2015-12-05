using Project.Access_Data;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Project.Bussiness_Layer
{
    class CustomerBL
    {
        public static bool AddCustomer(Customer a)
        {
            return CustomerData.AddCustomer(a);
        }
        public static bool DeleteCustomer(int CusID)
        {
            return CustomerData.DeleteCustomer(CusID);
        }
        public static DataTable DisplayAllCus()
        {
            return CustomerData.DisplayAllCus();
        }
        public static bool UpdateCustomer(Customer a)
        {
            return CustomerData.UpdateCustomer(a);
        }
        public static Customer GetbyCustomerName(string name)
        {
            return CustomerData.GetbyCustomerName(name);
        }
        public static DataTable SearchCustomer(string CustomerName)
        {
            return CustomerData.SearchCustomer(CustomerName);
        }
    }
}
