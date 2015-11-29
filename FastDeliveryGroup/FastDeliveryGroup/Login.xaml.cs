using FastDeliveryGroup.BussinessLogicLayer;
using FastDeliveryGroup.Entities;
using FastDeliveryGroup.Presentation.AdminForm;
using FastDeliveryGroup.Presentation.StaffForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FastDeliveryGroup
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        User CurUser;
        public Login()
        {
            InitializeComponent();
            
        }

        private void ShowStaffForm()
        {

            StaffForm sf = new StaffForm(CurUser);
            //Application.Current.Run(sf);
            //Application.
            sf.Show();
        }
        private void ShowAdminForm()
        {
            AdminForm af = new AdminForm(CurUser);
            af.Show();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try {
                string username = txtUserName.Text;
                User user = UserBLL.GetUserByUName(username);
                if (user != null && user.Password.Equals(txtPassword.Text))
                {
                    if (!user.Role)
                    {
                        CurUser = user;
                        StaffForm sf = new StaffForm(user);
                        sf.Show();
                        this.Close();
                        //      Application.Current.
                    }
                    else if (user.Role)
                    {
                        CurUser = user;
                        AdminForm af = new AdminForm(user);
                        af.Show();
                        this.Close();
                    }
                }
                else
                {
                    lblMessage.Visibility = Visibility.Visible;
                    lblMessage.IsEnabled = true;
                    lblMessage.Content = "Username/Password is wrong";
                } }
            catch(Exception g)
            {
                System.Windows.Forms.MessageBox.Show(g.Message);
            }
        }

        private void txtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblMessage.Visibility = Visibility.Hidden;

        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            lblMessage.Visibility = Visibility.Hidden;
        }
    }
}
