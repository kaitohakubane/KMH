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
    /// Interaction logic for SupplierWindow.xaml
    /// </summary>
    public partial class SupplierWindow : Window
    {
        public SupplierWindow()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Supplier sup = new Supplier();
                sup.SupID = int.Parse(txtSupID.Text);
                sup.SupName = txtSupName.Text;
                sup.SupAddress = txtAddress.Text;
                sup.SupDept = int.Parse(txtDebt.Text);
                sup.SupPhone = int.Parse(txtPhone.Text);
                SupplierBL.AddSupplier(sup);
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
