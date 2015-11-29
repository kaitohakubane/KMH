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
    /// Interaction logic for Edit_Product.xaml
    /// </summary>
  
    public partial class Edit_Product : Window
    {
        Product curPro;

        public event HD EditFinished;
        public Edit_Product(Product u)
        {
            InitializeComponent();
            curPro = u;
        }
      
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                curPro.Name = txtNameProduct.Text;
                curPro.Price = float.Parse(txtPrice.Text);
                ProductBLL.UpdateProductByID(curPro);
                System.Windows.Forms.MessageBox.Show("Updated Successfully!!!");
                if (EditFinished != null)
                {
                    EditFinished(curPro);
                }
                this.Close();
            }
            catch (Exception g)
            {
                System.Windows.Forms.MessageBox.Show(g.Message);
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

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                txtNameProduct.Text = curPro.Name;
                txtPrice.Text = curPro.Price.ToString();
            }
            catch (Exception g)
            {
                System.Windows.Forms.MessageBox.Show(g.Message);
            }
        }
    }
}
