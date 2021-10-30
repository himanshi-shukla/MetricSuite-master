
namespace MetricSuite
{
    partial class FP_Input_Form
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
            this.btnOkay = new System.Windows.Forms.Button();
            this.txtBoxFPInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnOkay
            // 
            this.btnOkay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnOkay.Location = new System.Drawing.Point(460, 108);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(75, 37);
            this.btnOkay.TabIndex = 0;
            this.btnOkay.Text = "OK";
            this.btnOkay.UseVisualStyleBackColor = false;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // txtBoxFPInput
            // 
            this.txtBoxFPInput.Location = new System.Drawing.Point(202, 116);
            this.txtBoxFPInput.Name = "txtBoxFPInput";
            this.txtBoxFPInput.Size = new System.Drawing.Size(225, 23);
            this.txtBoxFPInput.TabIndex = 1;
            // 
            // FP_Input_Form
            // 
            this.AcceptButton = this.btnOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 248);
            this.Controls.Add(this.txtBoxFPInput);
            this.Controls.Add(this.btnOkay);
            this.Name = "FP_Input_Form";
            this.Text = "FP Input Form";
            this.Load += new System.EventHandler(this.FP_Input_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.TextBox txtBoxFPInput;
    }
}