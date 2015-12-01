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
    /// Interaction logic for ButtonForm.xaml
    /// </summary>
    public partial class ButtonForm : Window
    {
        public ButtonForm(string Order)
        {
            InitializeComponent();
            lblName.Content = "Order";
        }
        private void LoadAddForm(string Order)
        {
            if(Order.Equals("Staff"))
            {
                StaffControl frm = new StaffControl();
                frm.ShowDialog();
            }
            if(Order.Equals("Product")){
                ProductControl frm1 = new ProductControl();
                frm1.ShowDialog();
                }

            //if (Order.Equals("Bill"))
            //{
            //    BillControl frm2 = new BillControl();
            //    frm2.ShowDialog();
            //}

            //if (Order.Equals("Customer"))
            //{
            //    CustomerControl frm3 = new CustomerControl();
            //    frm3.ShowDialog();
            //}
            // Mày thiếu 2 form này
            //if (Order.Equals("Discount")){
            //    DiscountControl frm4 = new DiscountControl();
            //    frm4.ShowDialog();
            //}
            //if (Order.Equals("Supplier"))
            //{
            //    SupplierControl frm5 = new SupplierControl();
            //    frm5.ShowDialog();
            //}

        }
        private void LoadListForm(string Order)
        {
            ListForm frm = new ListForm(Order);
            frm.ShowDialog();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            LoadAddForm(lblName.Content);
        }

        private void btnList_Click(object sender, RoutedEventArgs e)
        {
            LoadListForm(lblName.Content);
        }


    }
}
