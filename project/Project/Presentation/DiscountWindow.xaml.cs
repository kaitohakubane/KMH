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
    /// Interaction logic for DiscountWindow.xaml
    /// </summary>
    public partial class DiscountWindow : Window
    {
        bool isUpdate;
        public DiscountWindow(bool Update)
        {
            InitializeComponent();
            isUpdate = Update;
            lblName.Content = "Add Discount";            
        }        

        public bool isValid()
        {
            return true;
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if (isUpdate)
            {
                lblName.Content = "Update Discount";
                try
                {
                    Discount dis = new Discount();                   
                    dis.Rate = int.Parse(txtRate.Text);
                    dis.DateStart = (DateTime)dpStart.SelectedDate;
                    dis.DateEnd = (DateTime)dpEnd.SelectedDate;
                    DiscountBL.UpdateDiscount(dis);
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
                    Discount dis = new Discount();
                    dis.Rate = int.Parse(txtRate.Text);
                    dis.DateStart = DateTime.Parse(dpStart.Text.ToString());
                    dis.DateEnd = (DateTime)dpEnd.SelectedDate;
                    DiscountBL.AddDiscount(dis);
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
