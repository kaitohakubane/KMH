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
            AddCustomer addcus = new AddCustomer(curU);
            addcus.AddFinished += new ACT(updateTable);
            addcus.ShowDialog();
        }
        private void updateTable(Customer cus)
        {
            dt.Rows.Add(cus.CustomerID,cus.Name,cus.Address,cus.Phone);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            dtgCustomer.AutoGenerateColumns = false;
            dt = CustomerBLL.GetAllCustomer();
            bs.DataSource = dt;
            dtgCustomer.ItemsSource = bs;

        }

        private void btnDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)dtgCustomer.SelectedItems;
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
        public void LoadData()
        {
            dtgCustomer.ItemsSource = null;
            dtgCustomer.ItemsSource = CustomerBLL.Loaddata().DefaultView;
            dtgCustomer.Items.Refresh();

        }
    }
}
