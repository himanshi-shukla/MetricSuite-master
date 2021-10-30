using System;
using System.Collections.Generic;
using System.Text;

namespace MetricSuite
{
    [Serializable]
    public class SMI_Data
    {
        public double smiValue { get; set; }
        public double moduleAdded { get; set; }
        public double moduleChanged { get; set; }
        public double moduleDeleted { get; set; }
        public double totalModule { get; set; }


        public SMI_Data()
        {

        }

        public SMI_Data(double v1, double v2, double v3, double v4, double v5)
        {
            //this.smiValue = v1;
            this.moduleAdded = v2;
            this.moduleChanged = v3;
            this.moduleDeleted = v4;
            this.totalModule = v5;
        }
    }
}
