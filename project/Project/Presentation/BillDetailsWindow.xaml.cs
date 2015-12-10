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
    /// Interaction logic for BillDetails.xaml
    /// </summary>
    public partial class BillDetails : Window
    {
        int BillID;
        DataTable dt = new DataTable();
        public BillDetails(int inBillID)
        {
            InitializeComponent();            
            loadData();
            dgv.IsReadOnly = true;
            BillID = inBillID;
            txtQuantity.Text = "1";
        }
        void loadData()
        {
            dt = ProductBL.DisplayAllProduct();
            dgv.ItemsSource = dt.DefaultView;
            dgv.AutoGenerateColumns = true;
            txtProID.Text = "";
            txtProID.IsEnabled = false;
        }
        private DataTable SearchData()
        {
            DataTable tmp = new DataTable();
            tmp = ProductBL.SearchProduct(txtProName.Text);
            if (txtProName.Text == "")
                tmp = ProductBL.DisplayAllProduct();
            return tmp;

        }
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            txtProID.Text = "";
            dt = SearchData();
            dgv.ItemsSource = dt.DefaultView;
            dgv.AutoGenerateColumns = true;
        }

        private void dgv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                int index = dgv.SelectedIndex;
                if (index >= 0)
                {
                    DataRow dr = dt.Rows[index];
                    txtProID.Text = dr[0].ToString();
                    txtProName.Text = dr[1].ToString();
                }

            }
            catch (Exception g)
            {
                System.Windows.Forms.MessageBox.Show(g.Message);
            }
        }
        public Boolean isvalid()
        {
            int ProID;
            if (!int.TryParse(txtProID.Text,out ProID) || txtProID.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Please choose a Product");
                return false;
            }
            int n;
            if (txtQuantity.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Quantity is not null");
                txtQuantity.Focus();
                return false;
            }
            if (!int.TryParse(txtQuantity.Text, out n))
            {
                System.Windows.Forms.MessageBox.Show("Quantity must be number and not contain spaces!");
                txtQuantity.Focus();
                return false;
            }

            if (int.Parse(txtQuantity.Text) <= 0)
            {
                System.Windows.Forms.MessageBox.Show("0<Quantity");
                txtQuantity.Focus();
                return false;
            }
            return true;
        }
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (isvalid())
            {
                BillDetail bill = new BillDetail(BillID, int.Parse(txtProID.Text), int.Parse(txtQuantity.Text));
                if (ProductBL.CheckQuantity(bill))
                {
                    if (BillDetailBL.isExist(bill))
                    {
                        BillDetailBL.AddQuantity(bill);
                    }
                    else
                        BillDetailBL.AddBillDetails(bill);
                    this.Close();
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Not enough quantity in stock");
                }
                
                
            }
            
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }       
    }
}
