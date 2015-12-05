using Project.Access_Data;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
namespace Project.Bussiness_Layer
{
    class SupplierBL
    {
        public static bool AddSupplier(Supplier a)
        {
            return SupplierData.AddSupplier(a);
        }
        public static bool DeleteSupplier(int SupplierID)
        {
            return SupplierData.DeleteSupplier(SupplierID);
        }
        public static DataTable DisplayAllSupplier()
        {
            return SupplierData.DisplayAllSupplier();
        }
        public static bool UpdateSupplier(Supplier a)
        {
            return SupplierData.UpdateSupplier(a);
        }
        public static Supplier GetbySupplierName(string name)
        {
            return SupplierData.GetbySupplierName(name);
        }
        public static DataTable SearchSupplier(string SupplierName)
        {
            return SupplierData.SearchSupplier(SupplierName);
        }
    }
}
