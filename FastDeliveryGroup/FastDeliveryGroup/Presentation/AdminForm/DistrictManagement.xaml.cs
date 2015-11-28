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

namespace FastDeliveryGroup.Presentation.StaffForm
{
    /// <summary>
    /// Interaction logic for DistrictManagement.xaml
    /// </summary>
    public partial class DistrictManagement : System.Windows.Controls.UserControl
    {
        User curUser;
        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        public DistrictManagement(User user)
        {
            InitializeComponent();
            curUser = user;
        }

        private void btnAddDistrict_Click(object sender, RoutedEventArgs e)
        {
            AddDistrict dis = new AddDistrict(curUser);
            dis.AddFinshed += new ActionComplete(updateTable);
            dis.ShowDialog();

        }
        private void LoadData()
        {
            dtgRoute.AutoGenerateColumns = false;
            dt = DistrictBLL.GetAllDistrict();
            bs.DataSource = dt;
            dtgRoute.ItemsSource = bs;
        }

      
        private void updateTable(District dis)
        {
            dt.Rows.Add(dis.DistrictID,dis.NameOfDistrict);
        }

         private void Grid_Loaded(object sender, RoutedEventArgs e)
        {//tat di mo lai
         // Dat break point o day de? no chay den dong` nay luon
         //    dtgRoute.AutoGenerateColumns = false;
         //    dt = DistrictBLL.GetAllDistrict();// neu thich thi kiem tra du lieu trong DataTable dt, hoi nay cai DataSet no tra ve 1 Table
         // thi thang dt nay no hung cai Table do, cung co 2 column ==> dung voi mong doi
         //   bs.DataSource = dt;
         //    dtgRoute.ItemsSource = bs;// chay xong dong nay thi ket thuc Loaded event...Het
         // no chay toi dong do, muon no chay qua thi nhan F10, neu trong dong do co 1 loi` goi ham  thi neu nhan F11 thi se chay vao ham do
         // vi du dong nay nhan F11
            LoadData();
        }

        private void btnDeleteDistrict_Click(object sender, RoutedEventArgs e)
        {
            DataRowView row = (DataRowView)dtgRoute.SelectedItem;
            if (row == null)
            {
                Console.WriteLine("Please chose a row");
            }
            else
            {
                int id = int.Parse(row["PlaceID"].ToString());
                DistrictBLL.DeleteDistrict(id);
                LoadData();
            }
        }
    }
}
