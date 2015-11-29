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
        public List<Shipper> Shippers = new List<Shipper>();
        public ScheduleManagement(User user)
        {
            InitializeComponent();
            curUser = user;
        }

        private void btnAddSchedule_Click(object sender, RoutedEventArgs e)
        {
            AddSchedule sche = new AddSchedule(curUser, Shippers);
            sche.AddFinshed += new ActionCompleted(AddNewRow);
            sche.ShowDialog();
        }
        private void AddNewRow(Invoice a)
        {
            dt.Rows.Add(a.InvoiceID, a.CustomerID, a.ShipperID, a.ShipmentDate, a.Total, a.StaffID, a.Status, a.Description);
        }

        private void updateTable(Invoice a)
        {
            dt.Rows.Add(a.InvoiceID, a.CustomerID, a.ShipperID, a.ShipmentDate, a.Total, a.StaffID, a.Status, a.Description);
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            Shippers = ShipperBLL.GetAllShipper();
            //lblUser.Content = curUser.FullName;

            dt = InvoiceBLL.GetAllInvoice();
            dt.PrimaryKey = new DataColumn[] { dt.Columns["InvoiceID"] };
            bs.DataSource = dt;
            dgdInvoice.ItemsSource = bs;

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

        private void btnEditSchedule_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (dgdInvoice.SelectedIndex >= 0)
                {
                    DataRow dr = dt.Rows[dgdInvoice.SelectedIndex];
                    Invoice inv = new Invoice();
                    inv.InvoiceID = (int)dr["InvoiceID"];
                    inv.CustomerID = dr["CustomerID"].ToString();
                    inv.Description = dr["Description"].ToString();
                    inv.ShipmentDate = (DateTime)dr["ShipmentDate"];
                    inv.ShipperID = (int)dr["ShipperID"];
                    inv.StaffID = (int)dr["StaffID"];
                    inv.Status = dr["Status"].ToString();
                    inv.Total = (double)dr["Total"];
                    EditSchedule es = new EditSchedule(inv, Shippers);
                    es.EditFinished += new ActionCompleted(EditCurRow);
                    es.ShowDialog();
                } }
            catch(Exception g)
            {
                System.Windows.Forms.MessageBox.Show(g.Message);
            }
        }
        private void EditCurRow(Invoice a)
        {
            DataRow dr = dt.Rows.Find(a.InvoiceID);
            dr["ShipperID"] = a.ShipperID;
            dr["ShipmentDate"] = a.ShipmentDate;
            dr["Description"] = a.Description;
            dr["Status"] = a.Status;

        }
    }
}
