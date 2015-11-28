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
    /// Interaction logic for ShipperAdding.xaml
    /// </summary>
    /// 
    public delegate void Run(Shipper shipper);
    public partial class ShipperAdding : Window
    {
        public List<Shipper> ListShipper = new List<Shipper>();
        public event Run AddFinished;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        User curUser;
        public ShipperAdding(User u)
        {
            InitializeComponent();
            curUser = u;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Shipper shipper = new Shipper();
                shipper.Name = txtName.Text;
                shipper.PlaceID = int.Parse(txtPlaceID.Text);
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
