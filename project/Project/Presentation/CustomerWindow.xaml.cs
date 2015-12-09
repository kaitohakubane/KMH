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
    /// Interaction logic for CustomerWindow.xaml
    /// </summary>
    public partial class CustomerWindow : Window
    {
        bool isUpdate; int CusID;
        Customer CurCus=null;
        public CustomerWindow(bool Update,int ID)
        {
            InitializeComponent();
            isUpdate = Update;
            lblName.Content = "Add Customer";
            CusID = ID; 
        }
        public bool isValid()
        {
            int n;
            //if (!int.TryParse(txtID.Text, out n))
            //{
            //    System.Windows.Forms.MessageBox.Show("Customer ID must be NUMBER!");
            //    return false;
            //}
            //if (txtID.Text.Length < 4)
            //{
            //    System.Windows.Forms.MessageBox.Show("ID must be more than 4 number");
            //    return false;
            //}
            //if(!int.TryParse(txtID.Text,out n))
            //{
            //    System.Windows.Forms.MessageBox.Show("Customer ID must be NUMBER!");
            //    return false;
            //}
            //if (int.Parse(txtID.Text) <= 0)
            //{
            //    System.Windows.Forms.MessageBox.Show("0<ID");
            //    return false;
            //}
            if (txtName.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Customer name is not null!");
                return false;
            }
            if (txtAddress.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Address is not null!");
                return false;
            }
            if (txtPhoneNo.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Phone number is not null");
                return false;
            }
            if (!int.TryParse(txtPhoneNo.Text, out n))
            {
                System.Windows.Forms.MessageBox.Show("Phone number must be number and not contain spaces!");
                return false;
            }
            if (txtPhoneNo.Text.Trim().Length < 10 || txtPhoneNo.Text.Trim().Length > 11)
            {
                System.Windows.Forms.MessageBox.Show("Phone number must be 10 or 11 numbers");
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
                    lblName.Content = "Update Customer";
                    try
                    {
                        Customer cus = new Customer();
                        cus.CusID = CusID;
                        cus.CusName = txtName.Text;
                        cus.CusAddress = txtAddress.Text;
                        cus.CusPhone = int.Parse(txtPhoneNo.Text);
                        CustomerBL.UpdateCustomer(cus);
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
                        Customer cus = new Customer();                        
                        cus.CusName = txtName.Text;
                        cus.CusAddress = txtAddress.Text;
                        cus.CusPhone = int.Parse(txtPhoneNo.Text);
                        CustomerBL.AddCustomer(cus);
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
