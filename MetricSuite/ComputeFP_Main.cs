using MetricSuite.store_operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetricSuite
{
    public partial class ComputeFP_Main : Form
    {
        private Utils ut = new Utils();
        private string formName;
        private Value_Adjustment valueAdjustmentForm;
        public Function_Point_Store fpStore;
        public ComputeFP_Main(Function_Point_Store fpStoreRef, string formNameRef)
        {
            InitializeComponent();
            formName = formNameRef;
            fpStore = fpStoreRef;
            SetInitialData_ComputeFP_Main();
        }

        private void SetInitialData_ComputeFP_Main()
        {
            if(Language_Selection_Form.globalLanguageRadioButton!=null)
            {
                textBoxSelectedLanguage.Text = Language_Selection_Form.globalLanguageRadioButton.Text;
                textBoxSelectedLanguage.Tag = Language_Selection_Form.globalLanguageRadioButton.Tag;
            } else
            {
                textBoxSelectedLanguage.Text = "None";
                textBoxSelectedLanguage.Tag = new String("");
            }
        }


        private void Calculate_ComputedFP()
        {     /* 
               * Formula for FP = count total * [0.65 + 0.01 * sum(VAF)]
               */
            if (String.IsNullOrEmpty(textBoxValueAdjustment.Text))
            {

                textBoxComputedFP.Text = Math.Round((Int32.Parse(textBoxTotal.Text) * 0.65),2).ToString();

            } /*else if (String.IsNullOrEmpty(textBoxTotal.Text))
            {
                //textBoxComputedFP.Text = Int32.Parse(textBoxValueAdjustment.Text).ToString();

            } */else
            {
                textBoxComputedFP.Text = Math.Round((Int32.Parse(textBoxTotal.Text) * (0.65 + (0.01 * Int32.Parse(textBoxValueAdjustment.Text)))),2).ToString("#,##0.##");
            }
        }

        private void Calculate_Total()
        {

            var allTxtBoxOutput = ut.getControlBasedOnTag(this, "txtBoxOutput");

            int sum = 0;
            foreach (Control c in allTxtBoxOutput)
            {
                if (!String.IsNullOrEmpty(c.Text))
                {
                    sum += Int32.Parse(c.Text);
                }
               
            }


            textBoxTotal.Text = sum.ToString();
        }

        private void Function_CalculateInline(Panel p)
        {
            TextBox txtBoxInput = new TextBox();
            TextBox txtBoxOutput = new TextBox();

            foreach (Control c in p.Controls)
            {
                if ((string)c.Tag == "txtBoxInput")
                {
                    txtBoxInput = c as TextBox;
                } else if ((string)c.Tag == "txtBoxOutput")
                {
                    txtBoxOutput = c as TextBox;
                }

            }

            if (String.IsNullOrEmpty(txtBoxInput.Text))
            {
                txtBoxOutput.Text = null;
                return;
            }

            RadioButton selectedRadioBtn = p.Controls.OfType<RadioButton>()
                                     .FirstOrDefault(r => r.Checked);

            txtBoxOutput.Text = (Int32.Parse(txtBoxInput.Text) * Int32.Parse(selectedRadioBtn.Text)).ToString();

            Calculate_Total();
            Calculate_ComputedFP();
        }

        private void validateOnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void Common_Handler(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                //TextBox tempTextBox = sender as TextBox;
                //if (Convert.ToInt16(tempTextBox.Text) < 0)
                //{
                //    tempTextBox.Text = "0";
                //    return;
                //}
            }

            Control control = sender as Control;
            Function_CalculateInline(control.Parent as Panel);
        }

        private void textBoxValueAdjustment_TextChanged(object sender, EventArgs e)
        {
            Calculate_ComputedFP();
        }

        private void btnValueAdjustment_Click(object sender, EventArgs e)
        {
            // To preserve previous instance data
            if(valueAdjustmentForm==null)
            {
                valueAdjustmentForm = new Value_Adjustment(textBoxValueAdjustment, fpStore.vas);
            }
            valueAdjustmentForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Language_Selection_Form languageForm = new Language_Selection_Form(textBoxSelectedLanguage);
            languageForm.ShowDialog();
        }

        //compute language code size : FP * code size of selected language


        private void btnComputeCodeSize_Click(object sender, EventArgs e)
        {
            //textBoxCodeSize.Text = (Int32.Parse(textBoxComputedFP.Text) * Int32.Parse(Language_Selection_Form.selectedLanguage.Tag)).ToString();
           //textBoxCodeSize.Text =Math.Round(Double.Parse(textBoxComputedFP.Text) * Double.Parse(textBoxSelectedLanguage.Tag.ToString())).ToString("#,##0");
           textBoxCodeSize.Text = Math.Round(Double.Parse(textBoxComputedFP.Text) * Double.Parse(textBoxSelectedLanguage.Tag.ToString())).ToString();
        }



        public Function_Point_Store getDataForSaving()
        {
            // Clear all previous value of store before saving - AGAIN
            fpStore = new Function_Point_Store();
            fpStore.fpName = formName;
            fpStore.valueAdjustmentSum = textBoxValueAdjustment.Text;
            fpStore.selectedLanguageText = textBoxSelectedLanguage.Text;
            fpStore.selectedLanguageValue = textBoxSelectedLanguage.Tag.ToString();
            fpStore.codeComputedSize = textBoxCodeSize.Text;

            var allInputPanel = ut.getControlBasedOnTag(this, "inputPanel");

            foreach (Control panel in allInputPanel)
            {
                fpStore.questionsDictionary.Add(panel.Name, new FP_Row("Some Label", ut.getPanelInputText(panel).Text, ut.getSelectedRadioButton(panel).Text));
            }

            if(valueAdjustmentForm!=null)
            {
                fpStore.vas = valueAdjustmentForm.vas;
            }
            return fpStore;
        }

        public void setDataFromSaving()
        {
            var allInputPanel = ut.getControlBasedOnTag(this, "inputPanel");

            foreach (Control panel in allInputPanel)
            {
                FP_Row fp_row = fpStore.questionsDictionary[panel.Name];

                ut.getPanelInputText(panel).Text = fp_row.inputKey;

                ut.getRadioButtonBasedOnValue(panel, fp_row.selectedValue).Checked = true;
            }

            textBoxValueAdjustment.Text = fpStore.valueAdjustmentSum;
            textBoxSelectedLanguage.Text = fpStore.selectedLanguageText;
            textBoxSelectedLanguage.Tag = fpStore.selectedLanguageValue;
            textBoxCodeSize.Text = fpStore.codeComputedSize;
        }


        private void btnComputeFp_Click(object sender, EventArgs e)
        {
            textBoxComputedFP.Text = "XYZ";
        }

        private void updateComputeButtonState()
        {
            if (textBoxSelectedLanguage.Text == "None")
            {
                btnComputeCodeSize.Enabled = false;
            }
            else
            {
                btnComputeCodeSize.Enabled = true;
            }
        }
        private void textBoxSelectedLanguage_TextChanged(object sender, EventArgs e)
        {
            updateComputeButtonState();
        }

        
    }
}
