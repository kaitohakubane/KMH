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
    /// Interaction logic for StaffForm.xaml
    /// </summary>
    public partial class StaffForm : Window
    {
        User curUser;
        public StaffForm(User u)
        {
            InitializeComponent();
            curUser = u;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            //  pnlScheduleManagement.Children.Add(new ScheduleManagement(curUser));
               pnlScheduleManagement.Children.Add(new DistrictManagement(curUser));
            //  pnlScheduleManagement.Children.Add(new CustomerManagement(curUser));
          //   pnlScheduleManagement.Children.Add(new ShipperManagement(curUser));
         //pnlScheduleManagement.Children.Add(new ProductManagement(curUser));
        }
    }
}
