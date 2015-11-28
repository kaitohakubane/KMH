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
    /// Interaction logic for AddDistrict.xaml
    /// </summary>
    /// 
    public delegate void ActionComplete(District dis);
    public partial class AddDistrict : Window
    {
        public List<District> District = new List<District>();
        public event ActionComplete AddFinshed;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        User curUser;
        public AddDistrict(User u)
        {
            InitializeComponent();
            curUser = u;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                District dis = new District();
                dis.NameOfDistrict = txtNameOfDistrict.Text;
                DistrictBLL.AddDistrict(dis);
                System.Windows.Forms.MessageBox.Show("Successfully");
                if (AddFinshed != null)
                {
                    AddFinshed(dis);
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
