using FastDeliveryGroup.BussinessLogicLayer;
using FastDeliveryGroup.Entities;
using FastDeliveryGroup.Presentation.AdminForm;
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
    /// Interaction logic for ShipperManagement.xaml
    /// </summary>
    public partial class ShipperManagement : System.Windows.Controls.UserControl
    {
        User curUser;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        List<District> places = new List<District>();
        public ShipperManagement(User u)
        {
            InitializeComponent();
            curUser = u;
        }

        private void btnAddShipper_Click(object sender, RoutedEventArgs e)
        {
            ShipperAdding Ads = new ShipperAdding(curUser, places);
            Ads.AddFinished += new Run(UpdateTable);
            Ads.ShowDialog();
        }
        public void UpdateTable(Shipper shipper)
        {
            dt.Rows.Add(shipper.ShipperID, shipper.Name, shipper.PlaceID, shipper.Phone, true);

        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();
           
        }
        private void LoadData()
        {
            dtgShipper.AutoGenerateColumns = false;
            dt = ShipperBLL.GetAllDTShipper();
            places = DistrictBLL.GetAllDistrict();
            bs.DataSource = dt;
            dtgShipper.ItemsSource = bs;
        }

        private void btnDeleteShipper_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)dtgShipper.SelectedItem;
            if (row == null)
            {
                Console.WriteLine("Please chose a row");
            }
            else
            {
                int id = int.Parse(row["ShipperID"].ToString());
                ShipperBLL.DeleteShipper(id);
                LoadData();
            }
        }
    }
}
