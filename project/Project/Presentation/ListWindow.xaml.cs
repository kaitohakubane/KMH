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
using Project.Bussiness_Layer;

namespace Project.Presentation
{
    /// <summary>
    /// Interaction logic for ListForm.xaml
    /// </summary>
    public partial class ListWindow : Window
    {
        string choice;
        DataTable dt = new DataTable();
        
        public ListWindow(string Order)
        {
            InitializeComponent();
            lblName2.Content = Order;
            choice = Order;
            //Cai loadData này mà k chạy thì ra tạo sự kiện LOADED cho cái Grid quăng cái loadData này vô
            loadData();
        }
        private void loadData()
        {
            if (choice.Equals("Staff"))
            {
                lblName.Content = "Search by Staff's name";
                dt = StaffBL.DisplayAllStaff();
                //Chỗ này cần gán datatable vào cái grid. Tao tìm mạng được cái này. Mày chạy test thử. K dc thì tìm cách load lên cho t
                dataGrid.ItemsSource = dt.DefaultView;
                dataGrid.AutoGenerateColumns = true;
            }
            if (choice.Equals("Supplier"))
            {

            }
            if (choice.Equals("Bill"))
            {

            }
            // Còn mấy cái mày làm như trên giúp tao cái
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView row = (DataRowView)dataGrid.SelectedItem;
                if (row == null)
                    // cái này chạy test thử. Đéo hiểu sao bên thằng tùng lại dùng Console.Writeline
                    System.Windows.Forms.MessageBox.Show("Please select a Row");
                else
                {                    
                    if (choice.Equals("Staff"))
                    {
                        dataGrid.Items.RemoveAt(dataGrid.SelectedIndex);
                    }
                    //Làm các if cho mấy cái loại khác như cái load phía trên. Gọi hàm truyền tham số cho phù hợp
                }                     
            }
            catch (Exception g)
            {
                System.Windows.Forms.MessageBox.Show(g.Message);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            dt = SearchData();
            dataGrid.ItemsSource = dt.DefaultView;
            dataGrid.AutoGenerateColumns = true;
        }
        private DataTable SearchData()
        {
            DataTable tmp=new DataTable();
            if (choice.Equals("Staff"))
            {
                tmp = StaffBL.SearchStaff(txtSearch.Text);
                if (txtSearch.Text == "")
                    tmp = StaffBL.DisplayAllStaff();
            }
                //Cái này m` viết đễ sẵn mai t viết method. Nguyên tắc SearchStaff, SearchCustomer, SearchSupplier....
                
            if (choice.Equals("Custommer"))
            {

            }
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