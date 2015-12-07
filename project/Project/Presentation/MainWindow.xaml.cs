﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Project.Entity;
using Project.Presentation;

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {Staff curStaff;
        public MainWindow(Staff inStaff,int Power)
        {
            InitializeComponent();
            curStaff=inStaff;            
            if (Power == 1)
            {
             
            }
            if (Power == 2)
            {
                //StockManger: Show cái j lên thì bỏ vào đây
                btnStaff.IsEnabled = false;
                btnPayment.IsEnabled = false;
                btnCustomer.IsEnabled = false;
                btnDiscount.IsEnabled = false;                
            }
            if (Power == 3)
            {
                //Dealer: Show cái j lên thì bỏ vào đây
                btnStaff.IsEnabled = false;
            }
        }

        private void btnStaff_Click(object sender, RoutedEventArgs e)
        {
            ButtonForm frm = new ButtonForm("Staff",curStaff);
            frm.ShowDialog();
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            ButtonForm frm = new ButtonForm("Product",curStaff);
            frm.ShowDialog();
        }

        private void btnPayment_Click(object sender, RoutedEventArgs e)
        {
            BillWindow bill = new BillWindow(curStaff);
            bill.ShowDialog();
        }

        private void btnCustomer_Click(object sender, RoutedEventArgs e)
        {
            ButtonForm frm = new ButtonForm("Customer",curStaff);
            frm.ShowDialog();
        }

        private void btnReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDiscount_Click(object sender, RoutedEventArgs e)
        {
            ButtonForm frm = new ButtonForm("Discount",curStaff);
            frm.ShowDialog();
        }

        private void btnSupplier_Click(object sender, RoutedEventArgs e)
        {
            ButtonForm frm = new ButtonForm("Supplier",curStaff);
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {           
            Login l = new Login();
            l.Show();
            this.Close();
        }
    }
    
}
