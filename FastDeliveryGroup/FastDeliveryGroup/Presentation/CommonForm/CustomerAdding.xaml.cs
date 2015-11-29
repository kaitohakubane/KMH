using FastDeliveryGroup.BussinessLogicLayer;
using FastDeliveryGroup.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FastDeliveryGroup.Presentation.StaffForm
{
    /// <summary>
    /// Interaction logic for AddCustomer.xaml
    /// </summary>
    /// 
    public delegate void ACT(Customer cus);
    public partial class AddCustomer : Window
    {
        public List<Customer> cusList = new List<Customer>();
        public event ACT AddFinished;
        User curU;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
      
        public AddCustomer(User user,DataTable tt)
        {
            InitializeComponent();
            curU = user;
            this.dt = tt;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Customer cus = new Customer();
                cus.CustomerID = txtCustomerID.Text;
                cus.Name= txtFullName.Text;
                cus.Address =txtAddress.Text;
                cus.Phone = txtFullName.Text;
                bool sameID = false;
                var rows = dt.Rows;
                foreach (DataRow datarow in rows)
                {
                    if (datarow["CustomerID"].ToString().Equals(cus.CustomerID))
                    {
                        sameID = true;
                        break;
                    }
                }
                if (!sameID)
                {
                    CustomerBLL.AddCustomer(cus);
                    System.Windows.Forms.MessageBox.Show("Successfully");

                    if (AddFinished != null)
                    {
                        AddFinished(cus);
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("This ID was existed!!");
                }
            }
            catch (Exception g)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + g.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
