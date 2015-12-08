using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using System.Globalization;
namespace Project.Presentation
{
    /// <summary>
    /// Interaction logic for GraphDay.xaml
    /// </summary>
    public partial class GraphDay : Window
    {
         
        DataTable dt = new DataTable();
        public GraphDay()
        {
            InitializeComponent();
            dpDateStart.Text = DateTime.Today.ToString();
            dpDateEnd.Text = DateTime.Today.ToString();
            dpYearChoose.Text = DateTime.Today.ToString();
            showChart();
            ColumnChart1.Visibility = Visibility.Hidden;
        }  
        private void showChart()
        {
            List<KeyValuePair<string, int>> MyValue = new List<KeyValuePair<string, int>>();        
            MyValue.Add(new KeyValuePair<string, int>("Day", 0));
            ColumnChart1.DataContext = MyValue;
        }
        public void showChart2()
        {
            List<KeyValuePair<string, int>> MyValue = new List<KeyValuePair<string, int>>(); 
            DateTime d1 = DateTime.Parse(dpDateStart.Text);
            DateTime d2 = DateTime.Parse(dpDateEnd.Text);   
            dt = BillBL.PrintDay(d1, d2);
            int k = dt.Rows.Count;
            for (int i = 0; i < k; i++)
            {
                MyValue.Add(new KeyValuePair<string, int>(DateTime.Parse(dt.Rows[i][0].ToString()).ToShortDateString(), int.Parse(dt.Rows[i][1].ToString())));
            }
            ColumnChart1.DataContext = MyValue;

        }
        public void showChart3()
        {
            List<KeyValuePair<int, int>> MyValue = new List<KeyValuePair<int, int>>();
            DateTime d1 = DateTime.Parse(dpYearChoose.Text);
            dt = BillBL.ReportMonth(d1.Year);
            int k = dt.Rows.Count;
            for (int i = 0; i < k; i++)
            {
                MyValue.Add(new KeyValuePair<int, int>(int.Parse(dt.Rows[i][0].ToString()), int.Parse(dt.Rows[i][1].ToString())));
            }
            ColumnChart1.DataContext = MyValue;
        }

        public void showChart4()
        {
            List<KeyValuePair<int, int>> MyValue = new List<KeyValuePair<int, int>>();
            dt = BillBL.ReportYear();
            int k = dt.Rows.Count;
            if (k > 10)
            {
                System.Windows.Forms.MessageBox.Show("Data is not more than 10 years!");
                for (int i = 0; i < 10; i++)
                {
                    MyValue.Add(new KeyValuePair<int, int>(int.Parse(dt.Rows[i][0].ToString()), int.Parse(dt.Rows[i][1].ToString())));
                }
                ColumnChart1.DataContext = MyValue;
                
            }
            else
            {
                for (int i = 0; i < k; i++)
                {
                    MyValue.Add(new KeyValuePair<int, int>(int.Parse(dt.Rows[i][0].ToString()), int.Parse(dt.Rows[i][1].ToString())));
                }
                ColumnChart1.DataContext = MyValue;
            }
        }
        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            ColumnChart1.Visibility = Visibility.Visible;
            showChart2();
        }

        private void btnReportMonths_Click(object sender, RoutedEventArgs e)
        {
            ColumnChart1.Visibility = Visibility.Visible;
            showChart3();
        }

        private void btnReportYear_Click(object sender, RoutedEventArgs e)
        {
            ColumnChart1.Visibility = Visibility.Visible;
            showChart4();
        }
    }
}
