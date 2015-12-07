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
   
    public partial class StaffWindow : Window
    {
        bool isUpdate;
        public StaffWindow(bool Update)
        {
            InitializeComponent();
            isUpdate = Update;
            lblName.Content = "Add Staff";
            loadData();
            
        }
        public void loadData()
        {
            cbxRole.Items.Add("Admin");
            cbxRole.Items.Add("Stock Manager");
            cbxRole.Items.Add("Saler");
            if (isUpdate)
            {
                lblName.Content = "Update Staff";
                txtID.IsEnabled = false;
            }
        }
        public bool isValid()
        {
            if (txtID.Text.Length < 2)
            {
                System.Windows.Forms.MessageBox.Show("ID is not null");
                return false;
            }
            if (txtName.Text.Length < 1)
            {
                System.Windows.Forms.MessageBox.Show("Name is not null");
                return false;
            }
            if (txtAge.Text.Length < 1)
            {
                System.Windows.Forms.MessageBox.Show("Age is not null");
                return false;
            }
            if (int.Parse(txtAge.Text) < 0)
            {
                System.Windows.Forms.MessageBox.Show("Age>0");
                return false;
            }
            if (long.Parse(txtSalary.Text) < 0)
            {
                System.Windows.Forms.MessageBox.Show("Salary>0");
                return false;
            }
            
            return true;
        }
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (isValid())
            {
                if (isUpdate)
                {
                    // Dong nay` bịnh quá              
                    try
                    {
                        Staff sta = new Staff();
                        sta.StaffID = txtID.Text;
                        sta.StaffName = txtName.Text;
                        sta.StaffAge = int.Parse(txtAge.Text);
                        sta.StaffRole = cbxRole.SelectedItem.ToString();
                        sta.StaffSalary = float.Parse(txtSalary.Text);
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
                    try
                    {
                        Staff sta = new Staff();
                        sta.StaffID = txtID.Text;
                        sta.StaffName = txtName.Text;
                        sta.StaffAge = int.Parse(txtAge.Text);
                        sta.StaffRole = cbxRole.SelectedItem.ToString();
                        sta.StaffSalary = float.Parse(txtSalary.Text);
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
            
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}