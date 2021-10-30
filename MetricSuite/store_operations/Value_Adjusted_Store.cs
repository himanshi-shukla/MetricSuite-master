using System;
using System.Collections.Generic;
using System.Text;

namespace MetricSuite.store_operations
{
    [Serializable]
    public class Value_Adjustment_Store
    {
        public IDictionary<string, int> vasDictionary = new Dictionary<string, int>();


        public void addData(string labelPassed, int selectedIndexPassed)
        {
            vasDictionary.Add(labelPassed, selectedIndexPassed);
        }
    }
}
