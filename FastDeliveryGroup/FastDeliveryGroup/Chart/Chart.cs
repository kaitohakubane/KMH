using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.ChartDetail
{
    public class Chart
    {
        private readonly List<MyChartSeries> _Chart = new List<MyChartSeries>();
        public List<MyChartSeries> Charts
        {
            get
            {
                return _Chart;
            }
        }

        public Chart()
        {
        }

        public void AddtoChart(MyChartSeries t)
        {
            _Chart.Add(t);
        }

        public Chart(MyChartSeries t)
        {
            _Chart.Add(t);
        }

    }
}
