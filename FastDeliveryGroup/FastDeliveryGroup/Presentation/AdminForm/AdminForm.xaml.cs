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
           pngText.Children.Add(new StaffManagement(curUser));
        }

    }
}
