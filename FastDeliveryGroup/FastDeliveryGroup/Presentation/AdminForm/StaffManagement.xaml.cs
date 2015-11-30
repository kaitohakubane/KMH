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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FastDeliveryGroup.Presentation.AdminForm
{
    /// <summary>
    /// Interaction logic for StaffManagement.xaml
    /// </summary>
    public partial class StaffManagement :System.Windows.Controls.UserControl
    {
        User curUser;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        public StaffManagement(User user)
        {
            InitializeComponent();
            curUser = user;
        }

        private void btnAddStaff_Click(object sender, RoutedEventArgs e)
        {
            AddStaff asf = new AddStaff(curUser);
            asf.AddFinshed += new Action(updateTable);
            asf.ShowDialog();
        }
        private void updateTable(User u)
        {
            dt.Rows.Add(u.FullName,u.UserID,u.UserName,u.Password,u.Role,u.Phone);
        }
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            LoadData();

        }
        private void LoadData()
        {
            dtgStaff.AutoGenerateColumns = false;
            dt = UserBLL.GetAllUser();
            bs.DataSource = dt;
            dtgStaff.ItemsSource = bs;
            dt.PrimaryKey = new DataColumn[] { dt.Columns["UserID"] };
        }

        private void btnDeleteStaff_Click(object sender, RoutedEventArgs e)
        {
            try {
                DataRowView row = (DataRowView)dtgStaff.SelectedItem;
                if (row == null)
                {
                    Console.WriteLine("Please chose a row");
                }
                else
                {
                    int id = int.Parse(row["UserID"].ToString());
                    
                   
                    
                    if (id != curUser.UserID)
                    {
                        UserBLL.DeleteStaff(id);
                        dt.Rows.Remove(dt.Rows.Find(id));
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Can not remove current account!!!");
                    }
                }
            }catch(Exception g)
            {
                System.Windows.Forms.MessageBox.Show(g.Message);
            }
        }
    }
}
