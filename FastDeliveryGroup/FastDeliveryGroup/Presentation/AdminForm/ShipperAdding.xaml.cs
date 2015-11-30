using FastDeliveryGroup.BussinessLogicLayer;
using FastDeliveryGroup.DataAccessLayer;
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
    /// Interaction logic for ShipperAdding.xaml
    /// </summary>
    /// 
    public delegate void Run(Shipper shipper);
    public partial class ShipperAdding : Window
    {
        public List<District> places = new List<District>();
        public event Run AddFinished;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        User curUser;
        public ShipperAdding(User u, List<District> dt)
        {
            InitializeComponent();
            curUser = u;
            this.places = dt;
            cbbPlace.DisplayMemberPath = "NameOfDistrict";
            foreach (District dist in places)
            {
                cbbPlace.Items.Add(dist);
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Shipper shipper = new Shipper();
                int nextIden = ShipperBLL.GetCurrentIden() + 1;
                shipper.ShipperID = nextIden;
                shipper.Name = txtName.Text;
                int PlaceID = ((District)cbbPlace.SelectedItem).DistrictID;
                shipper.PlaceID = PlaceID;
                shipper.Phone = txtPhone.Text;
                ShipperBLL.AddShipper(shipper);
                System.Windows.Forms.MessageBox.Show("Successfully");
                if (AddFinished != null)
                {
                    AddFinished(shipper);
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

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
