using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MetricSuite
{
    public partial class Form_UCP_Main : Form
    {
        public Form_UCP_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] titleArr = { "Technical Factor", "Description", "Weight", "Perceived Complexity", "Calculated Factor" };
            UCP_Type tcfType = new UCP_Type(titleArr, new UCP_ComboBox_Type(0, 5, 0.5), new UCP_ComboBox_Type(0, 5, 1));
            tcfType.addRows("T1", "Distributed System");
            tcfType.addRows("T2", "Performance");
            tcfType.addRows("T3", "End User Efficiency");
            tcfType.addRows("T4", "Complex internal Processing");
            tcfType.addRows("T5", "Reusability");
            tcfType.addRows("T6", "Easy to install");
            tcfType.addRows("T7", "Easy to use");
            tcfType.addRows("T8", "Portable");
            tcfType.addRows("T9", "Easy to change");
            tcfType.addRows("T10", "Concurrent");
            tcfType.addRows("T11", "Special security features");
            tcfType.addRows("T12", "Provides direct access for third parties");
            tcfType.addRows("T13", "Special user training facilities are required");

            Form_UCP frmUCP = new Form_UCP(tcfType);

            frmUCP.ShowDialog();
            CalculateTFC.Text = (0.6 + (0.01 * frmUCP.finalOutputVal)).ToString();
            updateCalculatedFields();
        }

        private void btnEFC_Click(object sender, EventArgs e)
        {
            string[] titleArr = { "Environmental Factor", "Description", "Weight", "Perceived Impact", "Calculated Factor" };
            UCP_Type tcfType = new UCP_Type(titleArr, new UCP_ComboBox_Type(0, 5, 0.5), new UCP_ComboBox_Type(0, 5, 1));
            tcfType.addRows("T1", "Familiarity with UML");
            tcfType.addRows("T2", "Application Experience");
            tcfType.addRows("T3", "Object Oriented Experience");
            tcfType.addRows("T4", "Lead analyst capability");
            tcfType.addRows("T5", "Motivation");
            tcfType.addRows("T6", "Stable Requirements");
            tcfType.addRows("T7", "Part-time workers");
            tcfType.addRows("T8", "Difficult Programming language");

            Form_UCP frmUCP = new Form_UCP(tcfType);

            frmUCP.ShowDialog();
            calculatedEFC.Text = (1.4 + (0.03 * frmUCP.finalOutputVal)).ToString();
            updateCalculatedFields();
        }

        void updateCalculatedFields()
        {
            if(productivityFactor.Text=="" || txtLocPerPM.Text=="" || txtLocPerUCP.Text=="" )
            {
                return;
            }

            double calculatedVal = double.Parse(caclculatedUAW.Text) + double.Parse(calculatedUUCW.Text);
            calculatedUUCP.Text = calculatedVal.ToString();
            double caculcuatedUCPVal = double.Parse(CalculateTFC.Text) * double.Parse(calculatedEFC.Text) * calculatedVal * double.Parse(productivityFactor.Text);
            totalUCP.Text = caculcuatedUCPVal.ToString();
            txtEstimatedHours.Text = (caculcuatedUCPVal * double.Parse(productivityFactor.Text)).ToString();
            txtEsimatedLOC.Text = (caculcuatedUCPVal * double.Parse(txtLocPerUCP.Text)).ToString();
            txtEstimatedPM.Text = (double.Parse(txtEsimatedLOC.Text)/double.Parse(txtLocPerPM.Text)).ToString();
        }

        //UAW
        private void btnUAW_Click(object sender, EventArgs e)
        {
            string[] titleArr = { "Actor Type", "Description", "Weight", "Number of Actors", "Result" };
            UCP_Type tcfType = new UCP_Type(titleArr, new UCP_ComboBox_Type(0, 5, 0.5), new UCP_ComboBox_Type(1,100, 1));
            tcfType.addRows("Simple", "The Actor represents another system with a defined API");
            tcfType.addRows("Average", "The Actor represents another system interacting through a protocol, like TCP/IP");
            tcfType.addRows("Complex", "The Actor is a person interacting via an interface");
            Form_UCP frmUCP = new Form_UCP(tcfType);
            frmUCP.ShowDialog();
            caclculatedUAW.Text =  frmUCP.finalOutputVal.ToString();
            updateCalculatedFields();
        }

        //UUCW
        private void btnUUCW_Click(object sender, EventArgs e)
        {
            string[] titleArr = { "Use Case Type", "Description", "Weight", "Number of Use Cases", "Result" };
            UCP_Type tcfType = new UCP_Type(titleArr, new UCP_ComboBox_Type(0, 5, 0.5), new UCP_ComboBox_Type(1, 100, 1));
            tcfType.addRows("Simple", "A simple user interface and touches only a single database entity; its success scenario has 3 steps or less; its implementation involves less than 5 classes.");
            tcfType.addRows("Average", "More interface design and touches 2 or more database entities; between 4 to 7 steps; its implementation involves between 5 to 10 classes.");
            tcfType.addRows("Complex", "Involves a complex user interface or processing and touches 3 or more database entities; over seven steps; its implementation involves more than 10 classes.");
            Form_UCP frmUCP = new Form_UCP(tcfType);
            frmUCP.ShowDialog();
            calculatedUUCW.Text = frmUCP.finalOutputVal.ToString();
            updateCalculatedFields();
        }

        private void Form_UCP_Main_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            updateCalculatedFields();
        }

        private void productivityFactor_TextChanged(object sender, EventArgs e)
        {
            updateCalculatedFields();
        }

        private void txtLocPerPM_TextChanged(object sender, EventArgs e)
        {

            updateCalculatedFields();
        }
    }
}
