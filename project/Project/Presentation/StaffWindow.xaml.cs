﻿using Project.Bussiness_Layer;
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
            cbxRole.Items.Add("Manager");
            cbxRole.Items.Add("Stock Manager");
            cbxRole.Items.Add("Saler");
            if (isUpdate)
            {
                lblName.Content = "Update Staff";
                txtID.IsEnabled = false;
            }
            cbxRole.SelectedIndex = 0;
        }
        public bool isValid()
        {
            int n=0;
            long m=0;
            if (txtID.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("ID is not null");
                txtID.Focus();
                return false;
            }
            if (txtID.Text.Trim().Replace(" ","").Length < 6)
            {
                System.Windows.Forms.MessageBox.Show("ID must be over 5 character!");
                txtID.Focus();
                return false;
            }
            if (txtName.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Name is not null");
                txtName.Focus();
                return false;
            }
            if (txtAge.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Age is not null");
                txtID.Focus();
                txtAge.Focus();
                return false;
            }
            if (!int.TryParse(txtAge.Text, out n))
            {
                System.Windows.Forms.MessageBox.Show("Age must be number and not contain spaces!");
                txtAge.Focus();
                return false;
            }
            
            if (int.Parse(txtAge.Text) <= 0 || int.Parse(txtAge.Text)>=100)
            {
                System.Windows.Forms.MessageBox.Show("0<Age<100");
                txtAge.Focus();
                return false;
            }
            if (txtSalary.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Salary is not null");
                txtSalary.Focus();
                return false;
            }
            if (!long.TryParse(txtSalary.Text, out m))
            {
                System.Windows.Forms.MessageBox.Show("Salary must be number and not contain spaces!");
                txtSalary.Focus();
                return false;
            }
            
            if (long.Parse(txtSalary.Text) <= 0)
            {
                System.Windows.Forms.MessageBox.Show("Salary>0");
                txtSalary.Focus();
                return false;
            }
            if (txtPassword.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Password is not null");
                txtPassword.Focus();
                return false;
            }
            if (txtPasswordConfirm.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Password is not null");
                txtPassword.Focus();
                return false;
            }
            if(!txtPassword.Text.Equals(txtPasswordConfirm.Text))
            {
                System.Windows.Forms.MessageBox.Show("Password is not match!");
                txtPasswordConfirm.Text = "";
                txtPasswordConfirm.Focus();
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
                    try
                    {
                        Staff sta = new Staff();
                        //if(StaffBL.GefbyID(txt))
                        sta.StaffID = txtID.Text.Trim().Replace(" ","");
                        sta.StaffName = txtName.Text.Trim();
                        sta.StaffAge = int.Parse(txtAge.Text);
                        sta.StaffRole = cbxRole.SelectedItem.ToString();
                        sta.StaffSalary = float.Parse(txtSalary.Text);
                        sta.StaffPassword = txtPassword.Text.Trim();
                        sta.isActive = true;
                        StaffBL.UpdateStaff(sta);
                        System.Windows.Forms.MessageBox.Show("Success");
                        this.Close();
                    }
                    catch (Exception )
                    {
                        System.Windows.Forms.MessageBox.Show("ID is exist!");
                    }
                }
                else
                {
                    try
                    {
                        Staff sta = new Staff();
                        sta.StaffID = txtID.Text.Trim().Replace(" ","");
                        sta.StaffName = txtName.Text.Trim();
                        sta.StaffAge = int.Parse(txtAge.Text);
                        sta.StaffRole = cbxRole.SelectedItem.ToString();
                        sta.StaffSalary = float.Parse(txtSalary.Text);
                        sta.StaffPassword = txtPassword.Text.Trim();
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