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
using Project.Bussiness_Layer;
using Project.Entity;

namespace Project.Presentation
{
    /// <summary>
    /// Interaction logic for ListForm.xaml
    /// </summary>
    public partial class ListWindow : Window
    {
        string choice;
        DataTable dt = new DataTable();
        Staff curStaff;
        public ListWindow(string Order,Staff sta)
        {
            InitializeComponent();
            lblName2.Content = Order;
            choice = Order;
            curStaff = sta;
            loadData();
            dataGrid.IsReadOnly = true;
        }
        private void loadData()
        {
            if (choice.Equals("Staff"))
            {
                lblName.Content = "Search by Staff's name";
                dt = StaffBL.DisplayAllStaff();                
                dataGrid.ItemsSource = dt.DefaultView;
                dataGrid.AutoGenerateColumns = true;
            }
            if (choice.Equals("Product"))
            {
                lblName.Content = "Search by Product's name";
                dt = ProductBL.DisplayAllProduct();
                dataGrid.ItemsSource = dt.DefaultView;
                dataGrid.AutoGenerateColumns = true;
            }
            if (choice.Equals("Bill"))
            {
                lblName.IsEnabled=false;
                txtSearch.Visibility = Visibility.Hidden;
                dt = StaffBL.DisplayAllStaff();
                dataGrid.ItemsSource = dt.DefaultView;
                dataGrid.AutoGenerateColumns = true;
            }
            if (choice.Equals("Customer"))
            {
                lblName.Content = "Search by Customer's name";
                dt = CustomerBL.DisplayAllCus();
                dataGrid.ItemsSource = dt.DefaultView;
                dataGrid.AutoGenerateColumns = true;
            }
            if (choice.Equals("Discount"))
            {
                lblName.Content = "Search by Discount's Date";
                dt = DiscountBL.DisplayAllDiscount();
                dataGrid.ItemsSource = dt.DefaultView;
                dataGrid.AutoGenerateColumns = true;
            }
            if (choice.Equals("Supplier"))
            {
                lblName.Content = "Search by Supplier's name";
                dt = SupplierBL.DisplayAllSupplier();
                dataGrid.ItemsSource = dt.DefaultView;
                dataGrid.AutoGenerateColumns = true;
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)dataGrid.SelectedItem;
                if (row == null)                   
                    System.Windows.Forms.MessageBox.Show("Please select a Row");
                else
                {                    
                    if (choice.Equals("Staff"))
                    {
                        if (StaffBL.GefbyID(row[0].ToString()).StaffID.Equals(curStaff.StaffID))
                        {
                            System.Windows.Forms.MessageBox.Show("Can not delete current user");
                        }
                        else
                        {
                            StaffBL.DeleteStaff(row[0].ToString());
                        }

                        loadData();
                    }
                    if (choice.Equals("Customer"))
                    {
                        CustomerBL.DeleteCustomer(row[0].GetHashCode());
                        loadData();
                    }
                    if (choice.Equals("Product"))
                    {
                        ProductBL.DeleteProduct(row[0].GetHashCode());
                        loadData();
                    }
                    if (choice.Equals("Supplier"))
                    {
                        SupplierBL.DeleteSupplier(row[0].GetHashCode());
                        loadData();
                    }
                    if (choice.Equals("Discount"))
                    {
                        DiscountBL.DeleteDiscount(row[0].GetHashCode());
                        loadData();
                    }
                    System.Windows.Forms.MessageBox.Show("Deleted!");
                }                     
            }
            catch (Exception g)
            {
                System.Windows.Forms.MessageBox.Show(g.Message);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)dataGrid.SelectedItem;
            if (row == null)
                System.Windows.Forms.MessageBox.Show("Please select a Row");
            else
            {
                if (choice.Equals("Staff"))
                {
                    StaffWindow sta = new StaffWindow(true);
                    sta.lblName.Content = "Update Staff";
                    sta.txtID.Text = row[0].ToString();
                    sta.txtName.Text = row[1].ToString();
                    sta.cbxRole.SelectedItem = row[2].ToString();
                    sta.txtAge.Text = row[3].ToString();
                    sta.txtSalary.Text=row[4].ToString();
                    sta.txtPassword.Text=row[5].ToString();
                    sta.ShowDialog();
                    loadData();
                }
                if (choice.Equals("Customer"))
                {
                    CustomerWindow cus = new CustomerWindow(true);
                    cus.lblName.Content = "Update Customer";                    
                    cus.txtName.Text= row[1].ToString();
                    cus.txtAddress.Text= row[2].ToString();
                    cus.txtPhoneNo.Text= row[3].ToString();
                    cus.ShowDialog();
                    loadData();
                }
                if (choice.Equals("Product"))
                {
                    ProductWindow pro = new ProductWindow(true);
                    pro.lblName.Content = "Update Product";
                    pro.txtID.Text= row[0].ToString();
                    pro.txtName.Text= row[1].ToString();
                    pro.txtSupplierID.Text = row[2].ToString();
                    pro.txtProducer.Text = row[3].ToString();
                    pro.txtOrigin.Text = row[4].ToString();
                    pro.txtInPrice.Text = row[5].ToString();
                    pro.txtOutPrice.Text = row[6].ToString();
                    pro.txtQuantity.Text = row[7].ToString();
                    pro.cbbType.SelectedItem = row[8].ToString();
                    pro.ShowDialog();
                    loadData();
                }
                if (choice.Equals("Supplier"))
                {
                    SupplierWindow sup = new SupplierWindow(true);
                    sup.lblName.Content = "Update Supplier";
                    sup.txtSupID.Text = row[0].ToString();
                    sup.txtSupName.Text = row[1].ToString();
                    sup.txtAddress.Text = row[2].ToString();
                    sup.txtDebt.Text = row[3].ToString();
                    sup.txtPhone.Text = row[4].ToString();
                    sup.ShowDialog();
                    loadData();
                }
                if (choice.Equals("Discount"))
                {
                    DiscountWindow dis = new DiscountWindow(true);
                    dis.lblName.Content = "Update Discount";
                    dis.txtCodeID.Text = row[0].ToString();
                    dis.txtType.Text = row[1].ToString();
                    dis.txtRate.Text = row[2].ToString();
                    dis.txtProIDGift.Text = row[3].ToString();
                    dis.dpStart.Text = row[4].ToString();
                    dis.dpEnd.Text = row[5].ToString();
                    dis.ShowDialog();
                    loadData();
                }
            }
        }
        private DataTable SearchData()
        {
            DataTable tmp=new DataTable();
            if (choice.Equals("Staff"))
            {
                tmp = StaffBL.SearchStaff(txtSearch.Text);
                if (txtSearch.Text == "")
                    tmp = StaffBL.DisplayAllStaff();
            }             
                
            if (choice.Equals("Customer"))
            {
                tmp = CustomerBL.SearchCustomer(txtSearch.Text);
                if (txtSearch.Text == "")
                    tmp = CustomerBL.DisplayAllCus();
            }

            if (choice.Equals("Product"))
            {
                tmp = ProductBL.SearchProduct(txtSearch.Text);
                if (txtSearch.Text == "")
                    tmp = ProductBL.DisplayAllProduct();

            }
            //if (choice.Equals("Discount"))
            //{
            //    tmp = DiscountBL.SearchDiscount(txtSearch.Text);
            //    if (txtSearch.Text == "")
            //        tmp = DiscountBL.DisplayAllDiscount();
            //}
            if (choice.Equals("Supplier"))
            {
                tmp = SupplierBL.SearchSupplier(txtSearch.Text);
                if (txtSearch.Text == "")
                    tmp = SupplierBL.DisplayAllSupplier();
            }
            return tmp;
        }

        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {            
            dt = SearchData();
            dataGrid.ItemsSource = dt.DefaultView;
            dataGrid.AutoGenerateColumns = true;
            
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}