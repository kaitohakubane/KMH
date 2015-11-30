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
        public ButtonForm(string Order)
        {
            InitializeComponent();
            lblName.Content = "Order";
        }
        private void LoadAddForm(string Order)
        {
            if (Order.Equals("Staff"))
            {
                StaffWindow frm = new StaffWindow();
                frm.ShowDialog();
            }
            if (Order.Equals("Product"))
            {
                ProductWindow frm1 = new ProductWindow();
                frm1.ShowDialog();
            }

            if (Order.Equals("Bill"))
            {
                BillWindow frm2 = new BillWindow();
                frm2.ShowDialog();
            }

            if (Order.Equals("Customer"))
            {
                CustomerWindow frm3 = new CustomerWindow();
                frm3.ShowDialog();
            }
            //Mày thiếu 2 form này
            //if (Order.Equals("Discount"))
            //{
            //    DiscountWindow frm4 = new DiscountWindow();
            //    frm4.ShowDialog();
            //}
            //if (Order.Equals("Supplier"))
            //{
            //    SupplierWindow frm5 = new SupplierWindow();
            //    frm5.ShowDialog();
            //}

        }
        //private void LoadListForm(string Order)
        //{
        //    ListForm frm = new ListForm(Order);
        //    frm.ShowDialog();
        //}

        //private void btnAdd_Click(object sender, RoutedEventArgs e)
        //{
        //    LoadAddForm(lblName.Content);
        //}

        //private void btnList_Click(object sender, RoutedEventArgs e)
        //{
        //    LoadListForm(lblName.Content);
        //}


    }
}
