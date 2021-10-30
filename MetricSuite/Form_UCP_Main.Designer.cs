
namespace MetricSuite
{
    partial class Form_UCP_Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnEFC = new System.Windows.Forms.Button();
            this.btnUUCW = new System.Windows.Forms.Button();
            this.btnUAW = new System.Windows.Forms.Button();
            this.productivityFactor = new System.Windows.Forms.TextBox();
            this.PF = new System.Windows.Forms.Label();
            this.loc_pm = new System.Windows.Forms.Label();
            this.txtLocPerPM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLocPerUCP = new System.Windows.Forms.TextBox();
            this.totalUCP = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.pm = new System.Windows.Forms.Label();
            this.eLOC = new System.Windows.Forms.Label();
            this.txtEstimatedHours = new System.Windows.Forms.TextBox();
            this.txtEsimatedLOC = new System.Windows.Forms.TextBox();
            this.txtEstimatedPM = new System.Windows.Forms.TextBox();
            this.CalculateTFC = new System.Windows.Forms.TextBox();
            this.calculatedEFC = new System.Windows.Forms.TextBox();
            this.calculatedUUCP = new System.Windows.Forms.TextBox();
            this.caclculatedUAW = new System.Windows.Forms.TextBox();
            this.calculatedUUCW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Location = new System.Drawing.Point(12, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Enter TFC data";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEFC
            // 
            this.btnEFC.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEFC.Location = new System.Drawing.Point(12, 95);
            this.btnEFC.Name = "btnEFC";
            this.btnEFC.Size = new System.Drawing.Size(143, 43);
            this.btnEFC.TabIndex = 1;
            this.btnEFC.Text = "Enter EFC Data";
            this.btnEFC.UseVisualStyleBackColor = false;
            this.btnEFC.Click += new System.EventHandler(this.btnEFC_Click);
            // 
            // btnUUCW
            // 
            this.btnUUCW.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUUCW.Location = new System.Drawing.Point(13, 214);
            this.btnUUCW.Name = "btnUUCW";
            this.btnUUCW.Size = new System.Drawing.Size(142, 39);
            this.btnUUCW.TabIndex = 2;
            this.btnUUCW.Text = "Enter UUCW details";
            this.btnUUCW.UseVisualStyleBackColor = false;
            this.btnUUCW.Click += new System.EventHandler(this.btnUUCW_Click);
            // 
            // btnUAW
            // 
            this.btnUAW.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUAW.Location = new System.Drawing.Point(13, 156);
            this.btnUAW.Name = "btnUAW";
            this.btnUAW.Size = new System.Drawing.Size(142, 40);
            this.btnUAW.TabIndex = 3;
            this.btnUAW.Text = "Enter UAW details";
            this.btnUAW.UseVisualStyleBackColor = false;
            this.btnUAW.Click += new System.EventHandler(this.btnUAW_Click);
            // 
            // productivityFactor
            // 
            this.productivityFactor.Location = new System.Drawing.Point(235, 360);
            this.productivityFactor.Name = "productivityFactor";
            this.productivityFactor.Size = new System.Drawing.Size(106, 23);
            this.productivityFactor.TabIndex = 7;
            this.productivityFactor.Text = "20";
            this.productivityFactor.TextChanged += new System.EventHandler(this.productivityFactor_TextChanged);
            // 
            // PF
            // 
            this.PF.AutoSize = true;
            this.PF.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PF.Location = new System.Drawing.Point(22, 360);
            this.PF.Name = "PF";
            this.PF.Size = new System.Drawing.Size(195, 20);
            this.PF.TabIndex = 8;
            this.PF.Text = "Enter the productivity Factor";
            this.PF.Click += new System.EventHandler(this.label1_Click);
            // 
            // loc_pm
            // 
            this.loc_pm.AutoSize = true;
            this.loc_pm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loc_pm.Location = new System.Drawing.Point(22, 404);
            this.loc_pm.Name = "loc_pm";
            this.loc_pm.Size = new System.Drawing.Size(125, 20);
            this.loc_pm.TabIndex = 9;
            this.loc_pm.Text = "Enter the LOC/PM";
            // 
            // txtLocPerPM
            // 
            this.txtLocPerPM.Location = new System.Drawing.Point(235, 405);
            this.txtLocPerPM.Name = "txtLocPerPM";
            this.txtLocPerPM.Size = new System.Drawing.Size(106, 23);
            this.txtLocPerPM.TabIndex = 10;
            this.txtLocPerPM.Text = "700";
            this.txtLocPerPM.TextChanged += new System.EventHandler(this.txtLocPerPM_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Enter the LOC/UCP";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtLocPerUCP
            // 
            this.txtLocPerUCP.Location = new System.Drawing.Point(235, 447);
            this.txtLocPerUCP.Name = "txtLocPerUCP";
            this.txtLocPerUCP.Size = new System.Drawing.Size(106, 23);
            this.txtLocPerUCP.TabIndex = 12;
            this.txtLocPerUCP.Text = "100";
            this.txtLocPerUCP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // totalUCP
            // 
            this.totalUCP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.totalUCP.Location = new System.Drawing.Point(235, 492);
            this.totalUCP.Name = "totalUCP";
            this.totalUCP.ReadOnly = true;
            this.totalUCP.Size = new System.Drawing.Size(106, 27);
            this.totalUCP.TabIndex = 13;
            this.totalUCP.Text = "0";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total.Location = new System.Drawing.Point(22, 495);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(73, 20);
            this.total.TabIndex = 14;
            this.total.Text = "Total UCP";
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hours.Location = new System.Drawing.Point(22, 535);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(118, 20);
            this.hours.TabIndex = 15;
            this.hours.Text = "Estimated Hours";
            // 
            // pm
            // 
            this.pm.AutoSize = true;
            this.pm.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pm.Location = new System.Drawing.Point(22, 619);
            this.pm.Name = "pm";
            this.pm.Size = new System.Drawing.Size(100, 20);
            this.pm.TabIndex = 16;
            this.pm.Text = "Estimated PM";
            // 
            // eLOC
            // 
            this.eLOC.AutoSize = true;
            this.eLOC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eLOC.Location = new System.Drawing.Point(22, 575);
            this.eLOC.Name = "eLOC";
            this.eLOC.Size = new System.Drawing.Size(105, 20);
            this.eLOC.TabIndex = 17;
            this.eLOC.Text = "Estimated LOC";
            // 
            // txtEstimatedHours
            // 
            this.txtEstimatedHours.Location = new System.Drawing.Point(235, 532);
            this.txtEstimatedHours.Name = "txtEstimatedHours";
            this.txtEstimatedHours.ReadOnly = true;
            this.txtEstimatedHours.Size = new System.Drawing.Size(106, 23);
            this.txtEstimatedHours.TabIndex = 18;
            this.txtEstimatedHours.Text = "0";
            // 
            // txtEsimatedLOC
            // 
            this.txtEsimatedLOC.Location = new System.Drawing.Point(235, 572);
            this.txtEsimatedLOC.Name = "txtEsimatedLOC";
            this.txtEsimatedLOC.ReadOnly = true;
            this.txtEsimatedLOC.Size = new System.Drawing.Size(106, 23);
            this.txtEsimatedLOC.TabIndex = 19;
            this.txtEsimatedLOC.Text = "0";
            // 
            // txtEstimatedPM
            // 
            this.txtEstimatedPM.Location = new System.Drawing.Point(235, 616);
            this.txtEstimatedPM.Name = "txtEstimatedPM";
            this.txtEstimatedPM.ReadOnly = true;
            this.txtEstimatedPM.Size = new System.Drawing.Size(106, 23);
            this.txtEstimatedPM.TabIndex = 20;
            this.txtEstimatedPM.Text = "0";
            // 
            // CalculateTFC
            // 
            this.CalculateTFC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CalculateTFC.Location = new System.Drawing.Point(353, 45);
            this.CalculateTFC.Name = "CalculateTFC";
            this.CalculateTFC.ReadOnly = true;
            this.CalculateTFC.Size = new System.Drawing.Size(167, 27);
            this.CalculateTFC.TabIndex = 21;
            this.CalculateTFC.Text = "0";
            // 
            // calculatedEFC
            // 
            this.calculatedEFC.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculatedEFC.Location = new System.Drawing.Point(353, 102);
            this.calculatedEFC.Name = "calculatedEFC";
            this.calculatedEFC.ReadOnly = true;
            this.calculatedEFC.Size = new System.Drawing.Size(167, 27);
            this.calculatedEFC.TabIndex = 22;
            this.calculatedEFC.Text = "0";
            // 
            // calculatedUUCP
            // 
            this.calculatedUUCP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculatedUUCP.Location = new System.Drawing.Point(353, 281);
            this.calculatedUUCP.Name = "calculatedUUCP";
            this.calculatedUUCP.ReadOnly = true;
            this.calculatedUUCP.Size = new System.Drawing.Size(167, 27);
            this.calculatedUUCP.TabIndex = 23;
            this.calculatedUUCP.Text = "0";
            // 
            // caclculatedUAW
            // 
            this.caclculatedUAW.Location = new System.Drawing.Point(353, 156);
            this.caclculatedUAW.Name = "caclculatedUAW";
            this.caclculatedUAW.ReadOnly = true;
            this.caclculatedUAW.Size = new System.Drawing.Size(167, 23);
            this.caclculatedUAW.TabIndex = 24;
            this.caclculatedUAW.Text = "0";
            // 
            // calculatedUUCW
            // 
            this.calculatedUUCW.Location = new System.Drawing.Point(353, 214);
            this.calculatedUUCW.Name = "calculatedUUCW";
            this.calculatedUUCW.ReadOnly = true;
            this.calculatedUUCW.Size = new System.Drawing.Size(167, 23);
            this.calculatedUUCW.TabIndex = 25;
            this.calculatedUUCW.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "UUCP";
            // 
            // Form_UCP_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 675);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.calculatedUUCW);
            this.Controls.Add(this.caclculatedUAW);
            this.Controls.Add(this.calculatedUUCP);
            this.Controls.Add(this.calculatedEFC);
            this.Controls.Add(this.CalculateTFC);
            this.Controls.Add(this.txtEstimatedPM);
            this.Controls.Add(this.txtEsimatedLOC);
            this.Controls.Add(this.txtEstimatedHours);
            this.Controls.Add(this.eLOC);
            this.Controls.Add(this.pm);
            this.Controls.Add(this.hours);
            this.Controls.Add(this.total);
            this.Controls.Add(this.totalUCP);
            this.Controls.Add(this.txtLocPerUCP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLocPerPM);
            this.Controls.Add(this.loc_pm);
            this.Controls.Add(this.PF);
            this.Controls.Add(this.productivityFactor);
            this.Controls.Add(this.btnUAW);
            this.Controls.Add(this.btnUUCW);
            this.Controls.Add(this.btnEFC);
            this.Controls.Add(this.button1);
            this.Name = "Form_UCP_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_UCP_Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_UCP_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEFC;
        private System.Windows.Forms.Button btnUUCW;
        private System.Windows.Forms.Button btnUAW;
        private System.Windows.Forms.TextBox productivityFactor;
        private System.Windows.Forms.Label PF;
        private System.Windows.Forms.Label loc_pm;
        private System.Windows.Forms.TextBox txtLocPerPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLocPerUCP;
        private System.Windows.Forms.TextBox totalUCP;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.Label pm;
        private System.Windows.Forms.Label eLOC;
        private System.Windows.Forms.TextBox txtEstimatedHours;
        private System.Windows.Forms.TextBox txtEsimatedLOC;
        private System.Windows.Forms.TextBox txtEstimatedPM;
        private System.Windows.Forms.TextBox CalculateTFC;
        private System.Windows.Forms.TextBox calculatedEFC;
        private System.Windows.Forms.TextBox calculatedUUCP;
        private System.Windows.Forms.TextBox caclculatedUAW;
        private System.Windows.Forms.TextBox calculatedUUCW;
        private System.Windows.Forms.Label label2;
    }
}