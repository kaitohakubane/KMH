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

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {Staff curStaff;
        public MainWindow(Staff inStaff)
        {
            InitializeComponent();
            curStaff=inStaff;
            if (Power == 1)
            {
                //Admin: Show cái j lên thì bỏ vào đây
                btnStaff.IsEnabled = false;
            }
            if (Power == 2)
            {
                //StockManger: Show cái j lên thì bỏ vào đây
                btnStaff.IsEnabled = false;
            }
            if (Power == 3)
            {
                //Dealer: Show cái j lên thì bỏ vào đây
                btnStaff.IsEnabled = false;
            }
        }
        private int mPower;

        public int Power
        {
            get { return mPower; }
            set { mPower = value; }
        }

        private void btnStaff_Click(object sender, RoutedEventArgs e)
        {
            ListW
        }
    }
    
}
