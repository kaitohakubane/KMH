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
        bool isUpdate;
        public StaffWindow(bool Update)
        {
            InitializeComponent();
            isUpdate = Update;
            loadData();
            
        }
        public void loadData()
        {
            cbxRole.Items.Add("Admin");
            cbxRole.Items.Add("Stock Manager");
            cbxRole.Items.Add("Saler");
            if (isUpdate)
            {
                txtID.IsEnabled = false;
            }
        }
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (isUpdate)
            {
                lblName.Content = "Update Staff";
                
                try
                {
                    Staff sta = new Staff();
                    sta.StaffID = txtID.Text;
                    sta.StaffName = txtName.Text;
                    sta.StaffAge = int.Parse(txtAge.Text);
                    sta.StaffRole = cbxRole.SelectedIndex + 1;
                    sta.StaffSalary = float.Parse(txtSalary.Text);
                    //sta.StaffUserName = txtUsername.Text;
                    sta.StaffPassword = txtPassword.Text;
                    sta.isActive = true;
                    StaffBL.UpdateStaff(sta);
                    System.Windows.Forms.MessageBox.Show("Success");
                    this.Close();
                }
                catch (Exception h)
                {
                    System.Windows.Forms.MessageBox.Show("Error " + h.Message);
                }
            }
            else
            {
                lblName.Content = "Add Staff";
                try
                {
                    Staff sta = new Staff();
                    sta.StaffID = txtID.Text;
                    sta.StaffName = txtName.Text;
                    sta.StaffAge = int.Parse(txtAge.Text);
                    sta.StaffRole = cbxRole.SelectedIndex + 1;
                    sta.StaffSalary = float.Parse(txtSalary.Text);
                    //sta.StaffUserName = txtUsername.Text;
                    sta.StaffPassword = txtPassword.Text;
                    sta.isActive = true;
                    StaffBL.AddStaff(sta);
                    System.Windows.Forms.MessageBox.Show("Success");
                    this.Close();
                }
                catch (Exception h)
                {
                    System.Windows.Forms.MessageBox.Show("Error " + h.Message);
                }
            }
           
            
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }


    }
}