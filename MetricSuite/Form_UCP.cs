using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MetricSuite
{
    public partial class Form_UCP : Form
    {
        private UCP_Type ucpType; //  = new UCP_Type();
        private Utils ut = new Utils();
        private int xAxisBase = 100;
        private int yAxisCurrent = 50;
        private int nextRowDiff = 50;
        public double finalOutputVal = 0;

        public Form_UCP()
        {
            InitializeComponent();
        }

        public Form_UCP(UCP_Type tcfType)
        {
            this.ucpType = tcfType;
            InitializeComponent();
        }

        void addComboBoxRange(ComboBox cb, double start, double end, double interval=1)
        {
            for (double i = start; i <= end; i=i+interval)
            {
                cb.Items.Add(i);
            }
        }
        void createRow(UCP_Row_Type ucpRow)
        {
            Panel panel = new Panel();
            //panelContainer.Control
            panelContainer.Controls.Add(panel);
            panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel.Location = new System.Drawing.Point(xAxisBase, yAxisCurrent+ nextRowDiff); // Same Left, but new Row

            panel.Size = new System.Drawing.Size(1015, nextRowDiff);


            int currentXAxis = 10;
            int controlYAxis = 10;
            for (int i = 1; i <= 2; i++)
            {
                Label lb = new Label();
                //this.Controls.Add(lb);
                panel.Controls.Add(lb);
                // lb.Text = String.Concat("Hello world row --- " + i.ToString());
                lb.Text = i==1 ? ucpRow.label1Text : ucpRow.label2Text;

                //lb.Location = new System.Drawing.Point(currentXAxis, currentY);
                lb.Location = new System.Drawing.Point(currentXAxis, controlYAxis);
                currentXAxis += 200;
                lb.MaximumSize = new Size(180, 0);
                lb.AutoSize = true;
                panel.Size = new System.Drawing.Size(1015, lb.PreferredHeight+30);
                yAxisCurrent += lb.PreferredHeight+30;
            }


            ComboBox cmbWeight = new ComboBox();
                addComboBoxRange(cmbWeight, ucpRow.cmb1.startValue, ucpRow.cmb1.endlValue, ucpRow.cmb1.intervalValue);
            cmbWeight.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWeight.SelectedIndex = 1;
            cmbWeight.Tag = "INPUT_CMB";
            cmbWeight.SelectedIndexChanged += new EventHandler(inputCmb_SelectedIndexChanged_Handler);
                panel.Controls.Add(cmbWeight);
            cmbWeight.Location = new System.Drawing.Point(currentXAxis, controlYAxis);

            currentXAxis += 200;

            ComboBox cmbComplexity = new ComboBox();
            addComboBoxRange(cmbComplexity, ucpRow.cmb2.startValue, ucpRow.cmb2.endlValue, ucpRow.cmb2.intervalValue);
            cmbComplexity.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbComplexity.SelectedIndex = 1;
            cmbComplexity.Tag = "INPUT_CMB";
            cmbComplexity.SelectedIndexChanged += new EventHandler(inputCmb_SelectedIndexChanged_Handler);
            panel.Controls.Add(cmbComplexity);
            cmbComplexity.Location = new System.Drawing.Point(currentXAxis, controlYAxis);

            currentXAxis += 200;


            Label lbOutput = new Label();
            panel.Controls.Add(lbOutput);
            lbOutput.Tag = "OUTPUT_LABEL";
            lbOutput.Location = new System.Drawing.Point(currentXAxis, controlYAxis);
            currentXAxis += 200;
            lbOutput.AutoSize = true;

            double val = double.Parse(cmbWeight.SelectedItem.ToString()) * double.Parse(cmbComplexity.SelectedItem.ToString());
            lbOutput.Text = val.ToString();
        }

        Double getTotalCalculatedFactor()
        {
            var allCalculatedLabel = ut.getControlBasedOnTag(this, "OUTPUT_LABEL");

            Double sum = 0;
            foreach (Label c in allCalculatedLabel)
            {
                    sum += Double.Parse(c.Text);

            }

            return sum;
        }

        void createTitles(UCP_Type ucpType)
        {
            int currentXAxis = xAxisBase+30;
            for (int i = 1; i <= ucpType.titleArr.Length; i++)
            {
                Label lb = new Label();
                this.Controls.Add(lb);

                lb.Text = ucpType.titleArr[i-1];

                lb.Location = new System.Drawing.Point(currentXAxis, 20);
                currentXAxis += 200;
                lb.AutoSize = true;
            }
        }

        void createDynamicControls()
        {
            createTitles(ucpType);

            ucpType.ucpRows.ForEach(row =>
            {
                createRow(row);
                // yAxisCurrent += nextRowDiff + 20;
            });
        }

        private void Form_UCP_Load(object sender, EventArgs e)
        {
            createDynamicControls();
            finalOutputVal = getTotalCalculatedFactor();
            labelFinalOutput.Text = finalOutputVal.ToString();
        }

        private void comboBoxCommonHanlder_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox original = sender as ComboBox;
            label1.Text = original.SelectedItem.ToString();
            finalOutputVal = getTotalCalculatedFactor();
            labelFinalOutput.Text = finalOutputVal.ToString();
        }

        private void inputCmb_SelectedIndexChanged_Handler(object sender, EventArgs e)
        {
            Control original = sender as Control;
            Panel parentPanel = original.Parent as Panel;

            double v1 = 0;
            double v2 = 0;
            double finalVal = 1;
            Label lbOutput = new Label();

            foreach (Control c in parentPanel.Controls)
            {
                if ((string)c.Tag == "INPUT_CMB")
                {
                    ComboBox cmb = c as ComboBox;
                    finalVal*= Double.Parse(cmb.SelectedItem.ToString());
                }

                if ((string)c.Tag == "OUTPUT_LABEL")
                {
                    lbOutput = c as Label;
                }
            }

            lbOutput.Text = finalVal.ToString();

            finalOutputVal = getTotalCalculatedFactor();
            labelFinalOutput.Text = finalOutputVal.ToString();
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
