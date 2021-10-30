using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MetricSuite
{
    public partial class SMI_Tab : Form
    {
        public SMI_Tab()
        {
            InitializeComponent();
        }

        private void SMI_Tab_Load(object sender, EventArgs e)
        {

            tabControlSMI.TabPages.Add("SMI Tab Item");
            //tabControlSMI.Controls.Add(new SMI_Form());
            SMI_Form smiForm = new SMI_Form();
            smiForm.TopLevel = false;
            tabControlSMI.TabPages[0].Controls.Add(smiForm);

        }
    }
}
