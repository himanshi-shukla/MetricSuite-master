
namespace MetricSuite
{
    partial class Main_Form
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.File = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripNewProject = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Edit = new System.Windows.Forms.ToolStripMenuItem();
            this.preference = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuLanguages = new System.Windows.Forms.ToolStripMenuItem();
            this.metrics = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFunctionPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEnterFpData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuUCP = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.projectTreeView = new System.Windows.Forms.TreeView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.File,
            this.Edit,
            this.preference,
            this.metrics,
            this.toolStripMenuItem4});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1673, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            this.File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNewProject,
            this.toolStripMenuOpenFile,
            this.toolStripMenuSaveFile,
            this.toolStripMenuExit});
            this.File.Name = "File";
            this.File.Size = new System.Drawing.Size(37, 20);
            this.File.Text = "File";
            // 
            // toolStripNewProject
            // 
            this.toolStripNewProject.Name = "toolStripNewProject";
            this.toolStripNewProject.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripNewProject.Size = new System.Drawing.Size(146, 22);
            this.toolStripNewProject.Text = "New";
            this.toolStripNewProject.Click += new System.EventHandler(this.toolStripNewProject_Click);
            // 
            // toolStripMenuOpenFile
            // 
            this.toolStripMenuOpenFile.Name = "toolStripMenuOpenFile";
            this.toolStripMenuOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripMenuOpenFile.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuOpenFile.Text = "Open";
            this.toolStripMenuOpenFile.Click += new System.EventHandler(this.toolStripMenuOpenFile_Click);
            // 
            // toolStripMenuSaveFile
            // 
            this.toolStripMenuSaveFile.Name = "toolStripMenuSaveFile";
            this.toolStripMenuSaveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuSaveFile.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuSaveFile.Text = "Save";
            this.toolStripMenuSaveFile.Click += new System.EventHandler(this.toolStripMenuSaveFile_Click);
            // 
            // toolStripMenuExit
            // 
            this.toolStripMenuExit.Name = "toolStripMenuExit";
            this.toolStripMenuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripMenuExit.Size = new System.Drawing.Size(146, 22);
            this.toolStripMenuExit.Text = "Exit";
            this.toolStripMenuExit.Click += new System.EventHandler(this.toolStripMenuExit_Click);
            // 
            // Edit
            // 
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(39, 20);
            this.Edit.Text = "Edit";
            // 
            // preference
            // 
            this.preference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuLanguages});
            this.preference.Name = "preference";
            this.preference.Size = new System.Drawing.Size(80, 20);
            this.preference.Text = "Preferences";
            // 
            // toolStripMenuLanguages
            // 
            this.toolStripMenuLanguages.Name = "toolStripMenuLanguages";
            this.toolStripMenuLanguages.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.toolStripMenuLanguages.Size = new System.Drawing.Size(171, 22);
            this.toolStripMenuLanguages.Text = "Languages";
            this.toolStripMenuLanguages.Click += new System.EventHandler(this.toolStripMenuLanguages_Click);
            // 
            // metrics
            // 
            this.metrics.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuFunctionPoint,
            this.toolStripMenuUCP,
            this.toolStripMenuSMI});
            this.metrics.Name = "metrics";
            this.metrics.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.metrics.Size = new System.Drawing.Size(58, 20);
            this.metrics.Text = "Metrics";
            // 
            // toolStripMenuFunctionPoint
            // 
            this.toolStripMenuFunctionPoint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEnterFpData});
            this.toolStripMenuFunctionPoint.Name = "toolStripMenuFunctionPoint";
            this.toolStripMenuFunctionPoint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.toolStripMenuFunctionPoint.Size = new System.Drawing.Size(197, 22);
            this.toolStripMenuFunctionPoint.Text = "Function Points";
            // 
            // toolStripEnterFpData
            // 
            this.toolStripEnterFpData.Name = "toolStripEnterFpData";
            this.toolStripEnterFpData.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.toolStripEnterFpData.Size = new System.Drawing.Size(219, 22);
            this.toolStripEnterFpData.Text = "Enter FP Data";
            this.toolStripEnterFpData.Click += new System.EventHandler(this.toolStripEnterFpData_Click);
            // 
            // toolStripMenuUCP
            // 
            this.toolStripMenuUCP.Name = "toolStripMenuUCP";
            this.toolStripMenuUCP.Size = new System.Drawing.Size(197, 22);
            this.toolStripMenuUCP.Text = "UCP";
            this.toolStripMenuUCP.Click += new System.EventHandler(this.toolStripMenuUCP_Click);
            // 
            // toolStripMenuSMI
            // 
            this.toolStripMenuSMI.Name = "toolStripMenuSMI";
            this.toolStripMenuSMI.Size = new System.Drawing.Size(197, 22);
            this.toolStripMenuSMI.Text = "SMI";
            this.toolStripMenuSMI.Click += new System.EventHandler(this.toolStripMenuSMI_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem4.Text = "Help";
            // 
            // projectTreeView
            // 
            this.projectTreeView.Location = new System.Drawing.Point(0, 67);
            this.projectTreeView.Name = "projectTreeView";
            this.projectTreeView.Size = new System.Drawing.Size(112, 683);
            this.projectTreeView.TabIndex = 1;
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(140, 67);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1499, 948);
            this.tabControl.TabIndex = 2;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 1027);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.projectTreeView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Form";
            this.Text = "CECS 543 Metrics Suite";
            this.Load += new System.EventHandler(this.Main_Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripMenuItem Edit;
        private System.Windows.Forms.ToolStripMenuItem preference;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripNewProject;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuOpenFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSaveFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFunctionPoint;
        private System.Windows.Forms.ToolStripMenuItem toolStripEnterFpData;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuSMI;
        private System.Windows.Forms.ToolStripMenuItem metrics;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuUCP;
        private System.Windows.Forms.TreeView projectTreeView;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuLanguages;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}