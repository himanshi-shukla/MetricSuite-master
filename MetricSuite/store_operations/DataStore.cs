using System;
using System.Collections.Generic;
using System.Text;

namespace MetricSuite.store_operations
{
    [Serializable]
    public class DataStore
    {
        public string projectName;
        public List<Function_Point_Store> functionPointStores = new List<Function_Point_Store>();
        public List<SMI_Data> smiDataListGlobal = new List<SMI_Data>();

        [NonSerialized]
        public List<ComputeFP_Main> computeFP_Main_Array = new List<ComputeFP_Main>();
    }
}
