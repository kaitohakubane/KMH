using Project.Bussiness_Layer;
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
    /// Interaction logic for NotificationWindow.xaml
    /// </summary>
    public partial class NotificationWindow : Window
    {
        DataTable dt = new DataTable();
        public NotificationWindow()
        {
            InitializeComponent();
            loaddata();
        }
        public void loaddata()
        {
            dt = ProductBL.Notification();
            if (dt.Rows.Count < 1)
                this.Close();
            dtTable.ItemsSource = dt.DefaultView;
            dtTable.AutoGenerateColumns = true;
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
