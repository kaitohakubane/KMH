using Project.Bussiness_Layer;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for BillWindow.xaml
    /// </summary>
    public partial class BillWindow : Window
    {
        DataTable dt = new DataTable();
        Staff curStaff;
        DateTime date = DateTime.Today;
        public BillWindow(Staff sta)
        {
            InitializeComponent();
            curStaff = sta;
            loadData();

        }
        public void loadData()
        {
            txtDate.Text = date.ToShortDateString();
            txtDate.IsEnabled = false;
            txtStaff.Text = curStaff.StaffID.ToString();
            txtCusName.Text = "Ban le";
            BillBL.AddBill(new Bill(txtStaff.Text,int.Parse(txtDiscount.Text),DateTime.Parse(txtDate.Text)));
            DataTable b = new DataTable();
            b = BillBL.GetMaxID();
            txtBillID = b.Rows[0];
        }
        public void loadGrid()
        {
           // dt = BillBL.GetProductinBill();
            dtgBill.ItemsSource = dt.DefaultView;
            dtgBill.AutoGenerateColumns = true;
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
      
            int ProductID = int.Parse(txtAdd.Text);
            //int Quantity = int.Parse(txtQuantity.Text);
            BillDetail bill = new BillDetail();
            BillDetailBL.AddBillDetails(bill);
        }
    }
}
