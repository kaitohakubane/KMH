﻿using Project.Bussiness_Layer;
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
        bool isUpdate;
        public CustomerWindow(bool Update)
        {
            InitializeComponent();
            isUpdate = Update;
            lblName.Content = "Add Customer";
            if (isUpdate)
            {
                txtID.IsEnabled = false;
            }                  
        }
        
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (isUpdate)
            {
                lblName.Content = "Update Customer";
                try
                {
                    Customer cus = new Customer();
                    cus.CusID = int.Parse(txtID.Text);
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
                    cus.CusID = int.Parse(txtID.Text);
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

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();            
        }
    }
}
