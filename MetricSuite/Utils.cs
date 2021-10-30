using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MetricSuite
{
    public class Utils
    {

        public IEnumerable<Control> getControlBasedOnTag(Control control, string selectedTag)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => getControlBasedOnTag(ctrl, selectedTag))
                                      .Concat(controls)
                                      .Where(c => (string)c.Tag == selectedTag);
        }

        public RadioButton getSelectedRadioButton(Control p)
        {
            RadioButton selectedRadioBtn = p.Controls.OfType<RadioButton>()
                                     .FirstOrDefault(r => r.Checked);

            return selectedRadioBtn;
        }

        public RadioButton getRadioButtonBasedOnValue(Control p, string selectedVal)
        {
            RadioButton selectedRadioBtn = p.Controls.OfType<RadioButton>()
                                     .FirstOrDefault(r => r.Text == selectedVal);

            return selectedRadioBtn;
        }

        public TextBox getPanelInputText(Control p)
        {
            TextBox tb = this.getControlBasedOnTag(p, "txtBoxInput").First() as TextBox;

            return tb;
        }

        public IEnumerable<Control> getAllComboBox(Control control)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => getAllComboBox(ctrl))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == typeof(ComboBox));
        }
    }
}
