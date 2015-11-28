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
    /// Interaction logic for ProductManagement.xaml
    /// </summary>
    public partial class ProductManagement :System.Windows.Controls.UserControl
    {
        User user;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        public ProductManagement(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            dtgProduct.AutoGenerateColumns = false;
            dt = ProductBLL.getAllProduct();
            bs.DataSource = dt;
            dtgProduct.ItemsSource = bs;
        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProduct AddPro = new AddProduct(user);
            AddPro.AddFinished += new HD(UpdateTable);
            AddPro.ShowDialog();
            LoadData();
        }
        private void UpdateTable(Product pro)
        {
            dt.Rows.Add(pro.ProductID, pro.Name, pro.Price);
        }

        private void btnDeleteProduct_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)dtgProduct.SelectedItem;
            if (row == null)
            {
                Console.WriteLine("Please chose a row");
            }
            else
            {
                int id = int.Parse(row["ProductID"].ToString());
                ProductBLL.DeleteProduct(id);
                LoadData();
            }
        }
        public delegate void sendProductID(int id);
        private void btnEditProduct_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)dtgProduct.SelectedItem;
            if (row == null)
            {

            }
            else
            {
                Edit_Product EditPro = new Edit_Product(user);
                EditPro.AddFinished += new Edit(UpdateTable);
                EditPro.ShowDialog();
                LoadData();
            }

        }
    }
}
