using FastDeliveryGroup.BussinessLogicLayer;
using FastDeliveryGroup.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FastDeliveryGroup.Presentation.StaffForm
{
    /// <summary>
    /// Interaction logic for EditSchedule.xaml
    /// </summary>
    public partial class EditSchedule : Window
    {
        Invoice inv;
        public event ActionCompleted EditFinished;
        public List<Shipper> Shippers;
        public EditSchedule(Invoice inv, List<Shipper> sp)
        {
            InitializeComponent();
            this.inv = inv;
            this.Shippers = sp;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {


                cbbShipper.DisplayMemberPath = "Name";
                cbbShipper.ItemsSource = Shippers;
                cbbShipper.Text = Shippers.Find(q => q.ShipperID == inv.ShipperID).Name;
                txtDescription.Text = inv.Description;
                cbbStatus.Text = inv.Status;
                dpDeliTime.Text = inv.ShipmentDate.ToShortDateString();
                lblTotal.Content = inv.Total.ToString("C00");
            }
            catch (Exception g)
            {
                System.Windows.Forms.MessageBox.Show(g.Message);
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                inv.ShipperID = ((Shipper)cbbShipper.SelectedItem).ShipperID;
                inv.Description = txtDescription.Text;
                inv.ShipmentDate = (DateTime)dpDeliTime.SelectedDate;
                inv.Status = cbbStatus.Text;
                InvoiceBLL.UpdateInvoiceByID(inv);
                System.Windows.Forms.MessageBox.Show("Updated Successfully!!!");
                if (EditFinished != null)
                {
                    EditFinished(inv);
                }
                this.Close();
            }
            catch (Exception g)
            {
                System.Windows.Forms.MessageBox.Show(g.Message);
            }
        }

    }
}
