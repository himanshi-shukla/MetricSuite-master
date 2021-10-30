using System;
using System.Collections.Generic;
using System.Text;

namespace MetricSuite.store_operations
{
    [Serializable]
    public class Function_Point_Store
    {
        public string fpName;
        public IDictionary<string, FP_Row> questionsDictionary = new Dictionary<string, FP_Row>();
        public string valueAdjustmentSum;
        public string selectedLanguageText;
        public string selectedLanguageValue;
        public string codeComputedSize;
        public Value_Adjustment_Store vas;
    }
}
