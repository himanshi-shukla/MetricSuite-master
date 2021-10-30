
namespace MetricSuite
{
    partial class SMI_Form
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
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnComputeIndex = new System.Windows.Forms.Button();
            this.dataGridView_SMI = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SMI)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(294, 454);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(75, 23);
            this.btnAddRow.TabIndex = 0;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnComputeIndex
            // 
            this.btnComputeIndex.Location = new System.Drawing.Point(457, 454);
            this.btnComputeIndex.Name = "btnComputeIndex";
            this.btnComputeIndex.Size = new System.Drawing.Size(137, 23);
            this.btnComputeIndex.TabIndex = 2;
            this.btnComputeIndex.Text = "Compute Index";
            this.btnComputeIndex.UseVisualStyleBackColor = true;
            this.btnComputeIndex.Click += new System.EventHandler(this.btnComputeIndex_Click);
            // 
            // dataGridView_SMI
            // 
            this.dataGridView_SMI.AllowUserToAddRows = false;
            this.dataGridView_SMI.AllowUserToDeleteRows = false;
            this.dataGridView_SMI.AllowUserToResizeColumns = false;
            this.dataGridView_SMI.AllowUserToResizeRows = false;
            this.dataGridView_SMI.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_SMI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SMI.Location = new System.Drawing.Point(174, 143);
            this.dataGridView_SMI.Name = "dataGridView_SMI";
            this.dataGridView_SMI.RowTemplate.Height = 25;
            this.dataGridView_SMI.Size = new System.Drawing.Size(540, 266);
            this.dataGridView_SMI.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(364, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Software Maturity Index";
            // 
            // SMI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_SMI);
            this.Controls.Add(this.btnComputeIndex);
            this.Controls.Add(this.btnAddRow);
            this.Name = "SMI_Form";
            this.Text = "SMI_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SMI_Form_FormClosing);
            this.Load += new System.EventHandler(this.SMI_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SMI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.Button btnComputeIndex;
        private System.Windows.Forms.DataGridView dataGridView_SMI;
        private System.Windows.Forms.Label label1;
    }
}