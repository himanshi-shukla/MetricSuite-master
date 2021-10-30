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
    public partial class Language_Selection_Form : Form
    {
        public static RadioButton globalLanguageRadioButton;

        private TextBox txtBoxSelectedLanguage;
        
        public Language_Selection_Form()
        {
            InitializeComponent();
            SetInitialValues();
        }

        public Language_Selection_Form(TextBox txtBoxSelectedLanguageRef)
        {
            txtBoxSelectedLanguage = txtBoxSelectedLanguageRef;
            InitializeComponent();
            //SetInitialValues(); // Don't set for Instance object
        }

        private void SetInitialValues()
        {

            if (globalLanguageRadioButton == null)
            {
                globalLanguageRadioButton = new RadioButton();
            }
            //if (selectedIndex != null)
            //{
            //    RadioButton defaultRadio = this.languagePanel.Controls[Language_Selection_Form.selectedIndex] as RadioButton;
            //    defaultRadio.Checked = true;
            //}
            //globalLanguageRadioButton = defaultRadio;
        }

        private void btnDone_Click(object sender, EventArgs e)

        {
            RadioButton selectedLanguageRadio = languagePanel.Controls.OfType<RadioButton>()
                                    .FirstOrDefault(r => r.Checked);

            if(txtBoxSelectedLanguage==null) // Opened for common
            {
                globalLanguageRadioButton = selectedLanguageRadio;
            } else // Opened from instance to update, NOT global
            {
                txtBoxSelectedLanguage.Text = selectedLanguageRadio.Text;
                txtBoxSelectedLanguage.Tag = selectedLanguageRadio.Tag;
            }
            
            this.Hide();
        }
    }
}
