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
        bool isUpdate; int SupID;
        public SupplierWindow(bool Update,int ID)
        {
            InitializeComponent();
            isUpdate = Update;
            lblName.Content = "Add Supplier";
            SupID = ID;
        }

        public bool isValid()
        {
            long n;
            if (txtSupName.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Name is not null");
                txtSupName.Focus();
                return false;
            }

            if (txtAddress.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Address is not null");
                txtAddress.Focus();
                return false;
            }
            if (txtPhone.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Phone number is not null");
                txtPhone.Focus();
                return false;
            }
            if(!long.TryParse(txtPhone.Text,out n))
            {
                System.Windows.Forms.MessageBox.Show("Phone number not contain Character and Spaces!");
                txtPhone.Focus();
                return false;
            }
            return true;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (isValid())
            {
                if (isUpdate)
                {
                    lblName.Content = "Update Supplier";
                    try
                    {
                        Supplier sup = new Supplier();
                        sup.SupID = SupID;
                        sup.SupName = txtSupName.Text;
                        sup.SupAddress = txtAddress.Text;
                        sup.SupPhone = txtPhone.Text;
                        SupplierBL.UpdateSupplier(sup);
                        System.Windows.Forms.MessageBox.Show("Success");
                        this.Close();
                    }
                    catch (Exception h)
                    {
                        System.Windows.Forms.MessageBox.Show("Error " + h.Message);
                    }
                }
                else
                {
                    try
                    {
                        Supplier sup = new Supplier();
                        sup.SupName = txtSupName.Text;
                        sup.SupAddress = txtAddress.Text;
                        sup.SupPhone = txtPhone.Text;
                        SupplierBL.AddSupplier(sup);
                        System.Windows.Forms.MessageBox.Show("Success");
                        this.Close();
                    }
                    catch (Exception h)
                    {
                        System.Windows.Forms.MessageBox.Show("Error " + h.Message);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
