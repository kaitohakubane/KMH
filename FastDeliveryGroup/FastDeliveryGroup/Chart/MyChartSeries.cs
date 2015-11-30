using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FastDeliveryGroup.ChartDetail
{
    public class MyChartSeries 
    {
        private string _name ;
        private float _count = 0;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public float Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }

        }

    }
}
