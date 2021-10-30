using MetricSuite.store_operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetricSuite
{
    public partial class Value_Adjustment : Form
    {
        public Value_Adjustment_Store vas = new Value_Adjustment_Store();
        private int totalValueAdjusted = 0;
        Utils ut = new Utils();

        TextBox textBoxValueAdjustment = new TextBox();
        public Value_Adjustment()
        {
            InitializeComponent();
            SetInitialValues();
        }

        public Value_Adjustment(TextBox txtBoxRef, Value_Adjustment_Store vasRef)
        {
            textBoxValueAdjustment = txtBoxRef;
            vas = vasRef;
            InitializeComponent();
            SetInitialValues();
        }

       

        private void SetInitialValues()
        {
            //var allCombobox = ut.getAllComboBox(this);

            //foreach (ComboBox combobox in allCombobox)
            //{
            //    combobox.SelectedIndex = 1;
            //}
            var panels = this.Controls.OfType<Panel>();
            foreach (Panel panel in panels)
            {
                ComboBox cb = panel.Controls.OfType<ComboBox>().First();
                //vas.addData(panel.Name, cb.SelectedIndex);

                if(vas!=null)
                {
                    cb.SelectedIndex = vas.vasDictionary[panel.Name];
                } else
                {
                    cb.SelectedIndex = 1;
                }
               
            }

        }


        private void btnDone_Click(object sender, EventArgs e)
        {
            var allCombobox = ut.getAllComboBox(this);

            totalValueAdjusted = 0;
            foreach (ComboBox combobox in allCombobox)
            {
                totalValueAdjusted += combobox.SelectedIndex;
            }

            label3.Text = totalValueAdjusted.ToString();
            textBoxValueAdjustment.Text = totalValueAdjusted.ToString();
            this.populateVasObject();
            this.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void populateVasObject()
        {
            vas = new Value_Adjustment_Store();
            var panels = this.Controls.OfType<Panel>();
            foreach (Panel panel in panels)
            {
                ComboBox cb = panel.Controls.OfType<ComboBox>().First();
                vas.addData(panel.Name, cb.SelectedIndex);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Value_Adjustment_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
