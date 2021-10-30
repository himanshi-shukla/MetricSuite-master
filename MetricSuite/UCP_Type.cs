using System;
using System.Collections.Generic;
using System.Text;

namespace MetricSuite
{
    public class UCP_Type
    {
        public string[] titleArr = { };
        public UCP_ComboBox_Type cmb1;
        public UCP_ComboBox_Type cmb2;
        public List<UCP_Row_Type> ucpRows= new List<UCP_Row_Type>();

        public UCP_Type(string[] titleArr, UCP_ComboBox_Type cmb1, UCP_ComboBox_Type cmb2)
        {
            this.titleArr = titleArr;
            this.cmb1 = cmb1;
            this.cmb2 = cmb2;
        }

        public void addRows(string l1, string l2)
        {
            ucpRows.Add(new UCP_Row_Type(l1, l2, this.cmb1, this.cmb2));
        }
        //public string labelOutputText;

    }
}
