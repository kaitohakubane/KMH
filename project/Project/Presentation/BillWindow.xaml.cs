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
            dtgBill.IsReadOnly = true;
            txtQuantity.Text = "1";
        }
        public void loadData()
        {
            txtDate.Text = date.ToShortDateString();
            txtBillID.IsEnabled = false;
            txtDate.IsEnabled = false;
            txtStaff.Text = curStaff.StaffID.ToString();
            txtDiscount.Text = "1";
            txtCusName.Text = "Ban le";
            txtStaff.IsEnabled = false;
            BillBL.AddBill(new Bill(txtStaff.Text,int.Parse(txtDiscount.Text),DateTime.Parse(txtDate.Text)));
            txtBillID.Text = BillBL.GetMaxID().ToString();

        }
        public void loadGrid()
        {
            dt = BillBL.GetProductInBill(int.Parse(txtBillID.Text));
            dtgBill.ItemsSource = dt.DefaultView;
            dtgBill.AutoGenerateColumns = true;
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            int ProductID = 0;
            int.TryParse(txtAdd.Text, out ProductID);
            int Quantity = int.Parse(txtQuantity.Text);
            int BillID = int.Parse(txtBillID.Text);
            long m = 0;
            if (ProductBL.GetbyProductID(ProductID))
            {
                BillDetail bill = new BillDetail(BillID, ProductID, Quantity);
                if (ProductBL.CheckQuantity(bill))
                {
                    if (BillDetailBL.isExist(bill))
                    {
                        BillDetailBL.AddQuantity(bill);
                    }
                    else
                        BillDetailBL.AddBillDetails(bill);
                    txtQuantity.Text = "1";
                    txtAdd.Text = "";
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Not enough quantity in stock");
                }             
                loadGrid();
                       
            }
            else
            {
                BillDetails frm = new BillDetails(BillID);
                frm.ShowDialog();
                loadGrid();
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                m += long.Parse(dt.Rows[i][4].ToString());
            }
            txtSum.Text = m.ToString();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            DataTable dt2 = new DataTable();
            dt2=BillDetailBL.GetSellQuantity(int.Parse(txtBillID.Text));
            if (dt2.Rows.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("Bill has no product!");
            }
            else
            {
                for (int i = 0; i < dt2.Rows.Count; i++)
                {
                    ProductBL.UpdateQuantity(new BillDetail(int.Parse(txtBillID.Text), int.Parse(dt2.Rows[i][0].ToString()), int.Parse(dt2.Rows[i][1].ToString())));

                }
                this.Close();
            }
        }
    }
}
