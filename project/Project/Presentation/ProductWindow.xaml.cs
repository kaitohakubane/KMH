using Project.Bussiness_Layer;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Project.Presentation
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        public ProductWindow()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Product pro = new Product();
                pro.ProID = int.Parse(txtID.Text);
                pro.ProName = txtName.Text;
                pro.SupID = int.Parse(txtSupplierID.Text);
                pro.Producer=txtProducer.Text;
                pro.Origin=txtOrigin.Text;
                pro.InPrice = int.Parse(txtInPrice.Text);
                pro.OutPrice = int.Parse(txtOutPrice.Text);
                pro.Quantity = int.Parse(txtQuantity.Text);
                pro.Type =;
                ProductBL.AddProduct(pro);
                System.Windows.Forms.MessageBox.Show("Success");
                this.Close();
            }
            catch (Exception h)
            {
                System.Windows.Forms.MessageBox.Show("Error " + h.Message);
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }        
        
    }
}
