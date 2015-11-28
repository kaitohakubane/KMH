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
    /// Interaction logic for AddProduct.xaml
    /// </summary>
    /// 
    public delegate void HD(Product pro);
    public partial class AddProduct : Window
    {
        public List<Product> ListPro = new List<Product>();
        public event HD AddFinished;
        User curUser;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        public AddProduct(User u)
        {
            InitializeComponent();
            curUser = u;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product pro = new Product();
                pro.Name = txtNameProduct.Text;
                pro.Price = float.Parse(txtPrice.Text);
                ProductBLL.InsertProduct(pro);
                System.Windows.Forms.MessageBox.Show("Successfully");
                if (AddFinished != null)
                {
                    AddFinished(pro);
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
