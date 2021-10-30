
namespace MetricSuite
{
    partial class SMI_Tab
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlSMI = new System.Windows.Forms.TabControl();
            this.SuspendLayout();
            // 
            // tabControlSMI
            // 
            this.tabControlSMI.Location = new System.Drawing.Point(127, 51);
            this.tabControlSMI.Name = "tabControlSMI";
            this.tabControlSMI.SelectedIndex = 0;
            this.tabControlSMI.Size = new System.Drawing.Size(702, 370);
            this.tabControlSMI.TabIndex = 0;
            // 
            // SMI_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 488);
            this.Controls.Add(this.tabControlSMI);
            this.Name = "SMI_Tab";
            this.Text = "SMI_Tab";
            this.Load += new System.EventHandler(this.SMI_Tab_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSMI;
    }
}