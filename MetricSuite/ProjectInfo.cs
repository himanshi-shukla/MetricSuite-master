using MetricSuite.store_operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MetricSuite
{
    public partial class ProjectInfo : Form
    {

        TreeView treeViewInstance = new TreeView();
        Main_Form mf;
        DataStore ds;
        ToolStripMenuItem smiMenuStrip;
        public ProjectInfo()
        {
            InitializeComponent();
        }

        public ProjectInfo(Main_Form mfRef, TreeView treeViewInstanceRef, DataStore dsRef, ToolStripMenuItem smiMenuStripRef)
        {
            mf = mfRef;
            treeViewInstance = treeViewInstanceRef;
            ds = dsRef;
            smiMenuStrip = smiMenuStripRef;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            treeViewInstance.Nodes.Add(textBoxProjectName.Text);
            mf.Text = "CECS 543 Metrics Suite - " + textBoxProjectName.Text;
            ds.projectName = textBoxProjectName.Text;
            smiMenuStrip.Enabled = true;
            this.Close();
        }

        public void loadProjectInfo()
        {
            treeViewInstance.Nodes.Add(ds.projectName);
            mf.Text = "CECS 543 Metrics Suite - " + ds.projectName;
            smiMenuStrip.Enabled = true;
        }

        private void textBoxProjectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProjectInfo_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
