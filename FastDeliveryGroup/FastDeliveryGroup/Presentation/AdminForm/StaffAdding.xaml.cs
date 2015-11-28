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

namespace FastDeliveryGroup.Presentation.AdminForm
{
    /// <summary>
    /// Interaction logic for AddStaff.xaml
    /// </summary>
    /// 
    public delegate void Action(User user);
    public partial class AddStaff : Window
    {
        public List<User> User = new List<User>();
        public event Action AddFinshed;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        List<object> obja = new List<object>();
        User curUser;
        public AddStaff(User user)
        {
            InitializeComponent();
            curUser = user;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                User u = new User();
                u.FullName = txtFullName.Text;
                u.UserName = txtUserName.Text;
                u.Password = txtPassWord.Text;
                u.Role = Boolean.Parse(txtRole.Text);
                u.Phone = txtPhone.Text;
                UserBLL.AddUser(u);
                System.Windows.Forms.MessageBox.Show("Successfully");
                if (AddFinshed != null)
                {
                    AddFinshed(u);
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
