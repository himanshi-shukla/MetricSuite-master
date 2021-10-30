using System;
using System.Collections.Generic;
using System.Text;

namespace MetricSuite.store_operations
{
    [Serializable]
    public class FP_Row
    {
        public string label;
        public string inputKey;
        public string selectedValue;
        public FP_Row(string labelPassed, string inputKeyPassed, string selectedValuePassed)
        {
            label = labelPassed;
            inputKey = inputKeyPassed;
            selectedValue = selectedValuePassed;
        }
    }
}
