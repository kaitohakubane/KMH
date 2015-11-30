using Project.Bussiness_Layer;
using Project.Entity;
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

namespace Project.Presentation
{
    /// <summary>
    /// Interaction logic for StaffWindow.xaml
    /// </summary>
    /// 
    public delegate void HD(Staff sta);
    public partial class StaffWindow : Window
    {
        public event HD Finish;
        public StaffWindow()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Staff sta = new Staff();
                sta.StaffName = txtName.Text;
                sta.StaffAge = int.Parse(txtAge.Text);
                sta.StaffRole = int.Parse(txtRole.Text);
                sta.StaffSalary = float.Parse(txtSalary.Text);
                sta.StaffUserName = txtUsername.Text;
                sta.StaffPassword = txtPassword.Text;
                sta.isActive = true;
                StaffBL.AddStaff(sta);
                System.Windows.Forms.MessageBox.Show("Success");
                if (Finish != null)
                {
                    Finish(sta);
                }
            }
            catch (Exception h)
            {
                System.Windows.Forms.MessageBox.Show("Error " + h.Message);
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