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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FastDeliveryGroup.Presentation.StaffForm
{
    /// <summary>
    /// Interaction logic for ScheduleManagement.xaml
    /// </summary>
    public partial class ScheduleManagement : System.Windows.Controls.UserControl
    {
        User curUser;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        public ScheduleManagement(User user)
        {
            InitializeComponent();
            curUser = user;
        }

        private void btnAddSchedule_Click(object sender, RoutedEventArgs e)
        {
            AddSchedule sche = new AddSchedule(curUser);
            sche.AddFinshed += new ActionCompleted(updateTable);
            sche.ShowDialog();
        }

        private void updateTable(Invoice a)
        {
            dt.Rows.Add(a.InvoiceID, a.CustomerID, a.ShipperID, a.ShipmentDate, a.Total, a.StaffID, a.Status, a.Description);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
            
        }
        private void LoadData()
        {
            dt = InvoiceBLL.GetAllInvoice();
            bs.DataSource = dt;
            dgdInvoice.ItemsSource = bs;

        }

        private void btnDeleteSchedule_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)dgdInvoice.SelectedItem;
            if (row == null)
            {
                Console.WriteLine("Please chose a row");
            }
            else
            {
                int id = int.Parse(row["InvoiceID"].ToString());
                InvoiceBLL.DeleteInvoice(id);
                LoadData();
            }
        }
    }
}
