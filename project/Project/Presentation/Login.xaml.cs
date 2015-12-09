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
            btnLogin.IsEnabled = false;   
            
        }
        public void ShowMainForm(int power,Staff curStaff)
        {
            MainWindow frm = new MainWindow(curStaff,power);
            frm.Show();
            //this.Visibility = Visibility.Hidden;
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string StaffID = txtUsername.Text;
                Staff user = StaffBL.GefbyID(StaffID);
                
                if (user != null && user.StaffPassword.Equals(txtPassword.Password))
                {
                    //System.Windows.Forms.MessageBox.Show("Login Successfull!");
                    if (user.StaffRole == "Admin") 
                    {
                        ShowMainForm(1, user);
                    }
                    if (user.StaffRole == "Stock Manager")
                    {
                        ShowMainForm(2, user);
                    }
                    if (user.StaffRole == "Saler")
                    {
                        ShowMainForm(3, user);
                    }
                    
                    this.Close();
                }
                else
                {
                    
                    if (user == null)
                    {
                        System.Windows.Forms.MessageBox.Show("Username not exist!");
                        txtUsername.Focus();
                    }
                    if (user != null && !user.StaffPassword.Equals(txtPassword.Password))
                    {
                        System.Windows.Forms.MessageBox.Show("Wrong password");
                        txtPassword.Focus();
                    }
                }
            }
            catch (Exception g)
            {

                System.Windows.Forms.MessageBox.Show(g.Message);;
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtUsername_TextChanged(object sender, TextChangedEventArgs e)
        {            
            if (txtUsername.Text == "")
            {
                btnLogin.IsEnabled = false;
                lblUsername.Visibility = Visibility.Visible;
                lblUsername.IsEnabled = true;
            }
            else
            {
                lblUsername.Visibility = Visibility.Hidden;
                btnLogin.IsEnabled = true;
            }
        }
    }
}
