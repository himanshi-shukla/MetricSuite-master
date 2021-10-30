using System;
using System.Collections.Generic;
using System.Text;

namespace MetricSuite
{
    public class UCP_ComboBox_Type
    {
        public double startValue;
        public double endlValue;
        public double intervalValue;

        public UCP_ComboBox_Type(double startValue, double endlValue, double intervalValue)
        {
            this.startValue = startValue;
            this.endlValue = endlValue;
            this.intervalValue = intervalValue;
        }
    }
}
