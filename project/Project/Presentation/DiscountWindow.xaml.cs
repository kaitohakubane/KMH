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
        bool isUpdate; int DisID; DateTime DisEnd;
        public DiscountWindow(bool Update,int ID,DateTime End)
        {
            InitializeComponent();
            isUpdate = Update;
            lblName.Content = "Add Discount";
            DisID = ID;
            DisEnd = End;
            if (Update)
            {
                dpStart.IsEnabled = false;
                txtRate.IsEnabled = false;
            }
        }        

        public bool isValid()
        {
            int n;
            if (txtRate.Text.Trim() == "")
            {
                System.Windows.Forms.MessageBox.Show("Rate is not null");
                txtRate.Focus();
                return false;
            }
            if (!int.TryParse(txtRate.Text, out n))
            {
                System.Windows.Forms.MessageBox.Show("Rate must be number and not contain spaces!");
                txtRate.Focus();
                return false;
            }

            if (int.Parse(txtRate.Text) <= 0 || int.Parse(txtRate.Text) > 100)
            {
                System.Windows.Forms.MessageBox.Show("0<Rate<100");
                txtRate.Focus();
                return false;
            }
            DateTime m;
            if(!DateTime.TryParse(dpStart.Text,out m))
            {
                System.Windows.Forms.MessageBox.Show("Invalid date formate");
                return false;
            }
            if (m < DateTime.Today)
            {
                System.Windows.Forms.MessageBox.Show("Date must be at least this day");
                return false;
            }
            DateTime k;
            if (!DateTime.TryParse(dpEnd.Text, out k))
            {
                System.Windows.Forms.MessageBox.Show("Invalid date formate");
                return false;
            }
            if (k < DateTime.Today)
            {
                System.Windows.Forms.MessageBox.Show("Date must be at least this day");
                return false;
            }
            if (k <= m) {
                System.Windows.Forms.MessageBox.Show("Invalid order of day");
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
                    lblName.Content = "Update Discount";
                    try
                    {
                        Discount dis = new Discount();
                        dis.CodeID = DisID;
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
                       
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
    }
}
