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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FastDeliveryGroup.Presentation.StaffForm
{
    /// <summary>
    /// Interaction logic for CustomerManagement.xaml
    /// </summary>
    public partial class CustomerManagement : System.Windows.Controls.UserControl
    {
        User curU;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        public CustomerManagement(User user)
        {
            InitializeComponent();
            curU = user;
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            try {
                
                AddCustomer addcus = new AddCustomer(curU, dt);
                addcus.AddFinished += new ACT(updateTable);
                addcus.ShowDialog();
            }catch(Exception g)
            {
                System.Windows.Forms.MessageBox.Show(g.Message);
            }
        }
        private void updateTable(Customer cus)
        {
            dt.Rows.Add(cus.CustomerID,cus.Name,cus.Address,cus.Phone, true);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {

            LoadData();
        }

        //private void btnDeleteCustomer_Click(object sender, RoutedEventArgs e)
        //{
        //    try {
        //        DataRowView row = (DataRowView)dtgCustomer.SelectedItem;
        //        if (row == null)
        //        {
        //            Console.WriteLine("Please chose a row");
        //        }
        //        else
        //        {
        //            string id = row["CustomerID"].ToString();
        //            {
        //                CustomerBLL.DeleteCustomer(id);
        //                LoadData();
        //            }
        //        } }catch(Exception g)
        //    {
        //        System.Windows.Forms.MessageBox.Show(g.Message);
        //    }
        //}
        public void LoadData()
        {
            dtgCustomer.AutoGenerateColumns = false;
            dt = CustomerBLL.GetAllCustomer();
            bs.DataSource = dt;
            dtgCustomer.ItemsSource = bs;

        }

        private void btnDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)dtgCustomer.SelectedItem;
                if (row == null)
                {
                    Console.WriteLine("Please chose a row");
                }
                else
                {
                    string id = row["CustomerID"].ToString();
                    {
                        CustomerBLL.DeleteCustomer(id);
                        LoadData();
                    }
                }
            }
            catch (Exception g)
            {
                System.Windows.Forms.MessageBox.Show(g.Message);
            }
        }
    }
}
