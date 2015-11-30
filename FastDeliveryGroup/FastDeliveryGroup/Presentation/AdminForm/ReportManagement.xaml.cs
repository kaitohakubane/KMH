using FastDeliveryGroup.BussinessLogicLayer;
using FastDeliveryGroup.ChartDetail;
using FastDeliveryGroup.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FastDeliveryGroup.Presentation.AdminForm
{
    /// <summary>
    /// Interaction logic for ReportManagement.xaml
    /// </summary>
    public partial class ReportManagement : UserControl
    {
        public ReportManagement()
        {
            InitializeComponent();
        }

        private void cbbChoice_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string text = ((ComboBoxItem)cbbChoice.SelectedItem).Content.ToString();
            DataContext = null;
            switch (text)
            {
                case "Revenue/Day":
                    {
                        cccMainChart.Visibility = Visibility.Hidden;
                        DateTime dp = new DateTime(DateTime.Now.Ticks);
                        dpDate.SelectedDate = new DateTime(dp.Year, dp.Month, dp.Day);
                        cbbMonth.Visibility = Visibility.Hidden;
                        cbbYear.Visibility = Visibility.Hidden;
                        dpDate.Visibility = Visibility.Visible;
                        sccMainChart.Visibility = Visibility.Visible;
                        break;
                    }
                default:
                    {
                        sccMainChart.Visibility = Visibility.Hidden;
                        cbbMonth.SelectedIndex = 0;
                        cbbYear.SelectedIndex = 0;
                        dpDate.Visibility = Visibility.Hidden;
                        cbbMonth.Visibility = Visibility.Visible;
                        cbbYear.Visibility = Visibility.Visible;
                        cccMainChart.Visibility = Visibility.Visible;
                        break;
                    }
            }
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                switch (cbbChoice.Text)
                {
                    case "Revenue/Day":
                        {
                            csMyStackChartSeries.SeriesTitle = "Revenue of " + dpDate.Text;
                            DateTime date = (DateTime)dpDate.SelectedDate;
                            DataTable dt = InvoiceBLL.GetInvoiceByDay(date);
                            Chart c = new Chart();
                            foreach (DataRow dr in dt.Rows)
                            {
                                MyChartSeries mcs = new MyChartSeries();
                                mcs.Name = "Schedule " + dr["InvoiceID"].ToString();
                                mcs.Count = float.Parse(dr["Total"].ToString());
                                c.AddtoChart(mcs);
                            }
                            DataContext = c;
                            break;
                        }
                    default:
                        {
                            int month = int.Parse(cbbMonth.Text);
                            int year = int.Parse(cbbYear.Text); 
                            csMyChartSeries.SeriesTitle = "Number of schedule in " +
                                CultureInfo.CurrentCulture.DateTimeFormat.MonthNames.GetValue(month - 1).ToString();

                            Chart c = new Chart();
                            if (cbbChoice.Text == "Schedule/Month")
                            {
                                DataTable dt = InvoiceBLL.GetScheduleByMonth(month, year);
                                foreach (DataRow dr in dt.Rows)
                                {
                                    MyChartSeries mcs = new MyChartSeries();
                                    mcs.Name = dr["CustomerID"].ToString();
                                    mcs.Count = int.Parse(dr["NumberOfSchedule"].ToString());
                                    c.AddtoChart(mcs);
                                }
                            }
                            else if (cbbChoice.Text == "Shipper/Month")
                            {
                                DataTable dt = InvoiceBLL.GetShipperByMonth(month, year);
                                List<Shipper> shippers = new List<Shipper>();
                                shippers = ShipperBLL.GetAllShipper();
                                foreach (DataRow dr in dt.Rows)
                                {
                                    MyChartSeries mcs = new MyChartSeries();
                                    int ShipperID = int.Parse(dr["ShipperID"].ToString());
                                    string SName = ((Shipper)shippers.Where(q => q.ShipperID == ShipperID).FirstOrDefault()).Name;
                                    mcs.Name = SName;
                                    mcs.Count = int.Parse(dr["NumberOfSchedule"].ToString());
                                    c.AddtoChart(mcs);
                                }
                            }
                            DataContext = c;
                            break;
                        }
                }
            }
            catch (Exception g)
            {
                System.Windows.Forms.MessageBox.Show(g.Message);
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            this.updateCbbYear();

        }

        private void updateCbbYear()
        {
            int year = DateTime.Now.Year;
            for (int i = 2000; i <= year; i++)
            {
                cbbYear.Items.Add(i);
            }
        }

    }
}
