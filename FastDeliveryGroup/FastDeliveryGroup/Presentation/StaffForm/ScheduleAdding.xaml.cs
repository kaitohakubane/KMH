using FastDeliveryGroup.BussinessLogicLayer;
using FastDeliveryGroup.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FastDeliveryGroup.Presentation.StaffForm
{
    /// <summary>
    /// Interaction logic for AddSchedule.xaml
    /// </summary>
    public delegate void ActionCompleted(Invoice inv);
    
    public partial class AddSchedule : Window
    {
        int nextIden = 0;
        public List<InvoiceDetail> InvoiceDetails = new List<InvoiceDetail>();
        public List<Customer> CustomerList = new List<Customer>();
        public List<Product> ProductList = new List<Product>();
        public List<Shipper> Shippers = new List<Shipper>();
        public event ActionCompleted AddFinshed;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        List<object> obja = new List<object>();
        User curUser;
        public AddSchedule(User u, List<Shipper> sp)
        {
            InitializeComponent();
            curUser = u;
            this.Shippers = sp;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var p = (Product)cbbProduct.SelectedItem;
                var index = txtQuantity.Text.IndexOf('_');
                int quantity = 0;
                if (index > 0)
                {
                    quantity = int.Parse(txtQuantity.Text.Substring(0, index));
                }
                else
                {
                    quantity = int.Parse(txtQuantity.Text);
                }
                if (nextIden == 0)
                {
                    nextIden = InvoiceDetailBLL.GetCurrentIdentity() + 1;
                }
                InvoiceDetail id = new InvoiceDetail(nextIden, p, quantity);
                id.Product = ProductList.Where(q => q.ProductID == p.ProductID).FirstOrDefault().Name;
                InvoiceDetails.Add(id);
                dgdProduct.Items.Refresh();
            }
            catch (Exception g)
            {
                System.Windows.Forms.MessageBox.Show(g.Message);
            }




        }

        private void cbxShipper_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ProductList = ProductBLL.GetAllProduct();
            dt = CustomerBLL.GetAllCustomer();

            cbbShipper.DisplayMemberPath = "Name";
            foreach (Shipper sp in Shippers)
            {
                cbbShipper.Items.Add(sp);
            }
            bs.DataSource = dt;
            dgdCustomer.ItemsSource = bs;
            cbbProduct.DisplayMemberPath = "Name";
            foreach (Product pr in ProductList)
            {
                cbbProduct.Items.Add(pr);
            }
            dgdProduct.ItemsSource = InvoiceDetails;
        }

        private void dgdProduct_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (dgdProduct.SelectedItem != null)
            {
                try
                {
                    if (InvoiceDetails.Count != 0)
                    {
                        InvoiceDetails.RemoveAt(dgdProduct.SelectedIndex);
                        dgdProduct.Items.Refresh();
                    }
                }
                catch (Exception g)
                {
                    System.Windows.Forms.MessageBox.Show("Error: " + g.Message);
                }
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Invoice newInv = new Invoice();
                DataRowView cur = (DataRowView)dgdCustomer.SelectedItem;
                newInv.InvoiceID = nextIden;
                newInv.CustomerID = cur[0].ToString();
                newInv.Description = txtDescription.Text;
                newInv.ShipmentDate = dpDeliTime.SelectedDate.Value.Date;
                newInv.ShipperID = ((Shipper)cbbShipper.SelectedItem).ShipperID;
                newInv.StaffID = curUser.UserID;
                newInv.Status = "Pending";
                double total = 0;
                foreach (InvoiceDetail id in InvoiceDetails)
                {
                    total += id.SubTotal;
                }
                newInv.Total = total;
                InvoiceBLL.AddInvoice(newInv);
                InvoiceDetailBLL.AddInvoiceDetails(InvoiceDetails);
                System.Windows.Forms.MessageBox.Show("Successfully");
                if (AddFinshed != null)
                {
                    AddFinshed(newInv);
                }

            }
            catch (Exception g)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + g.Message);
            }
            finally
            {
                this.Close();
            }
        }

        private void txtCustomer_GotFocus(object sender, RoutedEventArgs e)
        {
            lblFilter.Content = "";
        }

        private void txtCustomer_LostFocus(object sender, RoutedEventArgs e)
        {
            lblFilter.Content = "ID filter";
        }

        private void txtCustomer_TextChanged(object sender, TextChangedEventArgs e)
        {
            string filter = "CustomerID like '%" + txtFilter.Text + "%'";
            bs.Filter = filter;
        }
    }
}
