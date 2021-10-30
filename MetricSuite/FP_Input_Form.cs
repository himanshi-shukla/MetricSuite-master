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
    public partial class FP_Input_Form : Form
    {


        TreeView treeViewInstance = new TreeView();
        TabControl tabControl;
        DataStore ds;
        public FP_Input_Form()
        {
            InitializeComponent();
        }

        public FP_Input_Form(TreeView treeViewInstanceRef, TabControl tabControlRef, DataStore dsRef)
        {
            treeViewInstance = treeViewInstanceRef;
            tabControl = tabControlRef;
            ds = dsRef;
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            treeViewInstance.Nodes[0].Nodes.Add(txtBoxFPInput.Text);
            tabControl.TabPages.Add(txtBoxFPInput.Text);
            int lastIndex = tabControl.TabPages.Count - 1;
            tabControl.SelectedIndex = lastIndex;

            Function_Point_Store fpStore = new Function_Point_Store();
            fpStore.fpName = txtBoxFPInput.Text;

            ComputeFP_Main frm = new ComputeFP_Main(fpStore, txtBoxFPInput.Text);
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabControl.TabPages[lastIndex].Controls.Add(frm);

            treeViewInstance.ExpandAll();

            ds.computeFP_Main_Array.Add(frm);
            
            this.Close();
        }

        public void loadFP_Input_Panels()
        {
            // Clear previous Forms after loading new data
           ds.computeFP_Main_Array = new List<ComputeFP_Main>();

            foreach (Function_Point_Store fpStore in ds.functionPointStores)
            {
                treeViewInstance.Nodes[0].Nodes.Add(fpStore.fpName);
                tabControl.TabPages.Add(fpStore.fpName);
                int lastIndex = tabControl.TabPages.Count - 1;
                //tabControl.SelectedIndex = lastIndex;

                //Function_Point_Store fpStore = new Function_Point_Store();
                //fpStore.fpName = txtBoxFPInput.Text;

                ComputeFP_Main frm = new ComputeFP_Main(fpStore, fpStore.fpName);
                frm.TopLevel = false;
                frm.Visible = true;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                tabControl.TabPages[lastIndex].Controls.Add(frm);

                frm.setDataFromSaving();

                // Save Form reference in Store for Storing again 
                ds.computeFP_Main_Array.Add(frm);

                treeViewInstance.ExpandAll();
            }

           

        }

        private void FP_Input_Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtBoxFPInput;
        }
    }
}
