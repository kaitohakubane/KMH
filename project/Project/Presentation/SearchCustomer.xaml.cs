using Project.Bussiness_Layer;
using Project.Entity;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for SearchCustomer.xaml
    /// </summary>
    public partial class SearchCustomer : Window
    {
        public event Action<int> ouCusID;
        public event Action<string> ouCusName;
        DataTable dt = new DataTable();
        Customer a = null;
        
        public SearchCustomer()
        {
            InitializeComponent();
            loaddata();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)dataGrid.SelectedItem;
            if (row == null)
                System.Windows.Forms.MessageBox.Show("Please select a Row");
            else
            {
                if (ouCusID != null)
                    ouCusID(int.Parse(row[0].ToString()));
                if (ouCusName != null)
                    ouCusName(row[1].ToString());
            }
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            StaffWindow frm = new StaffWindow(false);
            frm.ShowDialog();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void loaddata()
        {
            dt = CustomerBL.DisplayAllCus();
            dataGrid.ItemsSource = dt.DefaultView;
            dataGrid.AutoGenerateColumns = true;
            dataGrid.IsReadOnly= true;
        }
        public DataTable SearchData()
        {
            DataTable tmp = new DataTable();
            tmp = CustomerBL.SearchCustomer(txtSearch.Text);
            if (txtSearch.Text == "")
               tmp = CustomerBL.DisplayAllCus();
            return tmp;
        }
        private void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            dt = SearchData();
            dataGrid.ItemsSource = dt.DefaultView;
            dataGrid.AutoGenerateColumns = true;
        }
    }
}
