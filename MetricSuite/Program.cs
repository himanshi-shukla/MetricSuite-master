using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetricSuite
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ComputeFP_Main());
            ////Application.Run(new Language_Selection_Form());

            //Application.Run(new Value_Adjustment());
            Application.Run(new Main_Form());
            //Application.Run(new SMI_Form());
            //Application.Run(new Form_UCP_Main());



        }
    }
}
