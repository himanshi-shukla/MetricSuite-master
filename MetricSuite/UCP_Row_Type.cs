using System;
using System.Collections.Generic;
using System.Text;

namespace MetricSuite
{
    public class UCP_Row_Type
    {
        public string label1Text;
        public string label2Text;
        public UCP_ComboBox_Type cmb1;
        public UCP_ComboBox_Type cmb2;

        public UCP_Row_Type(string label1Text, string label2Text, UCP_ComboBox_Type cmb1, UCP_ComboBox_Type cmb2)
        {
            this.label1Text = label1Text;
            this.label2Text = label2Text;
            this.cmb1 = cmb1;
            this.cmb2 = cmb2;
        }
    }
}
