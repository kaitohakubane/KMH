using FastDeliveryGroup.Entities;
using FastDeliveryGroup.Presentation.StaffForm;
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

namespace FastDeliveryGroup.Presentation.AdminForm
{
    /// <summary>
    /// Interaction logic for AdminForm.xaml
    /// </summary>
    public partial class AdminForm : Window
    {
        User curUser;
        public AdminForm(User u)
        {
            InitializeComponent();
            curUser = u;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            pnlUserControl.Children.Add(new StaffManagement(curUser));
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void lbxTab_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            pnlUserControl.Children.Clear();
            string option = ((ListBoxItem)lbxTab.SelectedItem).Content.ToString();
            switch (option)
            {
                case "Staff Management":
                    {
                        pnlUserControl.Children.Add(new StaffManagement(curUser));
                        break;
                    }
                case "Product Management":
                    {
                        pnlUserControl.Children.Add(new ProductManagement(curUser));
                        break;
                    }
                case "District Management":
                    {
                        pnlUserControl.Children.Add(new DistrictManagement(curUser));
                        break;
                    }
                case "Shipper Management":
                    {
                        pnlUserControl.Children.Add(new ShipperManagement(curUser));
                        break;
                    }
                case "Report":
                    {
                        pnlUserControl.Children.Add(new ReportManagement());
                        break;
                    }
            }
        }
    }
}
