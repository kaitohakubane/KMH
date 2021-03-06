﻿using Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
//using System.Windows.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Project.Presentation
{
    /// <summary>
    /// Interaction logic for ButtonForm.xaml
    /// </summary>
    public partial class ButtonForm : Window
    {
        Staff curStaff;
        string choice;
        public ButtonForm(string Order,Staff sta)
        {
            InitializeComponent();
            lblName.Content = Order+"Management";
            choice = Order;
            curStaff = sta;
        }
        private void LoadAddForm(string Order)
        {            
            if (Order.Equals("Staff"))
            {
                StaffWindow frm = new StaffWindow(false);
                frm.ShowDialog();
            }
            if (Order.Equals("Product"))
            {
                ProductWindow frm1 = new ProductWindow(false);
                frm1.ShowDialog();
            }

            if (Order.Equals("Bill"))
            {
                BillWindow frm2 = new BillWindow(curStaff);
                frm2.ShowDialog();
            }

            if (Order.Equals("Customer"))
            {
                CustomerWindow frm3 = new CustomerWindow(false,0);
                frm3.ShowDialog();
            }
            
            if (Order.Equals("Discount"))
            {
                DateTime td=DateTime.Today;
                DiscountWindow frm4 = new DiscountWindow(false,0,td);
                frm4.ShowDialog();
            }

            if (Order.Equals("Supplier"))
            {
                SupplierWindow frm5 = new SupplierWindow(false,0);
                frm5.ShowDialog();
            }

        }
        private void LoadListForm(string Order)
        {
            ListWindow frm = new ListWindow(Order,curStaff);
            frm.ShowDialog();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            LoadAddForm(choice);
        }

        private void btnList_Click(object sender, RoutedEventArgs e)
        {
            LoadListForm(choice);
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }      
    }
}
