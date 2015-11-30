using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Project.Entity;
using Project.Bussiness_Layer;
namespace Project
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }
        public void ShowMainForm(int power,Staff curStaff)
        {
            MainWindow frm = new MainWindow(curStaff);
            frm.Power = power;
            frm.Show();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsername.Text;
            Staff user = StaffBL.GefbyUserName(username);
            if (user != null && user.StaffPassword.Equals(txtPassword.Password))
            {
                System.Windows.Forms.MessageBox.Show("Test");
                ShowMainForm(user.StaffRole, user);
                this.Close();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("lỗi");
                //Mày tạo message hay xử lý khi sai password ở đây
                //Cần thì làm try catch nguyên cái đăng nhập này
            }

        }
    }
}
