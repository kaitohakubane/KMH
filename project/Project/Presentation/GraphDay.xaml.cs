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
            showChart();
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
            int k = 0;
            k = int.Parse(dt.Rows[0][1].ToString());
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                MyValue.Add(new KeyValuePair<string, int>(DateTime.Parse(dt.Rows[i][0].ToString()).ToShortDateString(), int.Parse(dt.Rows[i][1].ToString())));
            }
            ColumnChart1.DataContext = MyValue;
        }
        private void btnView_Click(object sender, RoutedEventArgs e)
        {
            showChart2();
        }
    }
}
