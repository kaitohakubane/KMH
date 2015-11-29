using FastDeliveryGroup.DataAccessLayer;
using FastDeliveryGroup.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.BussinessLogicLayer
{
    class CustomerBLL
    {
        public static bool AddCustomer(Customer cus)
        {
            return CustomerData.InsertCustomer(cus);
        }
        public static DataTable GetAllCustomer()
        {
            return CustomerData.SelectAllCustomer();
        }
        public static bool DeleteCustomer(string ID)
        {
            return CustomerData.DeleteCustomer(ID);
        }
       

    }
}
