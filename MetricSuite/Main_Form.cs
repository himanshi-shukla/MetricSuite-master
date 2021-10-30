using MetricSuite.store_operations;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace MetricSuite
{
    public partial class Main_Form : Form
    {
        // Should be common and singleton instance
        private Language_Selection_Form languageSelectionForm;
        public DataStore dataStoreGlobal = new DataStore();
        SMI_Form smiForm;
        public Main_Form()
        {
            InitializeComponent();
        }

        void callbackOperations()
        {
            toolStripMenuSMI.Enabled = true;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            toolStripMenuSMI.Enabled = false;
        }

        // New Project
        private void toolStripNewProject_Click(object sender, EventArgs e)
        {
            ProjectInfo projectInfoForm = new ProjectInfo(this, projectTreeView, dataStoreGlobal, toolStripMenuSMI);
            projectInfoForm.ShowDialog();
        }

        // Enter FP Data
        private void toolStripEnterFpData_Click(object sender, EventArgs e)
        {
            FP_Input_Form fpInputForm = new FP_Input_Form(projectTreeView, tabControl,dataStoreGlobal);
            fpInputForm.ShowDialog();
        }

        // Language Selection
        private void toolStripMenuLanguages_Click(object sender, EventArgs e)
        {
            if(languageSelectionForm==null)
            {
                languageSelectionForm = new Language_Selection_Form();
            }
            languageSelectionForm.ShowDialog();
        }

        // File Open
        private void toolStripMenuOpenFile_Click(object sender, EventArgs e)
        {
            FileOperations fp = new FileOperations();
            dataStoreGlobal = fp.readFromFile();
            Debug.WriteLine(dataStoreGlobal);

            // Hydrate
            // Left Tree 
            ProjectInfo projectInfoForm = new ProjectInfo(this, projectTreeView, dataStoreGlobal,toolStripMenuSMI);
            projectInfoForm.loadProjectInfo();

            // Main Compute Panel in Loop
            FP_Input_Form fpInputForm = new FP_Input_Form(projectTreeView, tabControl, dataStoreGlobal);
            fpInputForm.loadFP_Input_Panels();

            smiForm = new SMI_Form(dataStoreGlobal);

            // Main Compute Load data
        }

        // File Save
        private void toolStripMenuSaveFile_Click(object sender, EventArgs e)
        {
            
            FileOperations fileOperations = new FileOperations();

            // Empty previous store -> Forms, not project name
            dataStoreGlobal.functionPointStores.Clear();

            foreach (ComputeFP_Main computeFPMain in dataStoreGlobal.computeFP_Main_Array)
            {
                dataStoreGlobal.functionPointStores.Add(computeFPMain.getDataForSaving());
            }

            fileOperations.writeToFile(dataStoreGlobal);
        }

        // Exit
        private void toolStripMenuExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void toolStripMenuSMI_Click(object sender, EventArgs e)
        {
            //smiForm = new SMI_Form();
            if(smiForm==null)
            {
                smiForm = new SMI_Form(dataStoreGlobal);
            } 
            smiForm.ShowDialog();

            //SMI_Tab smiTab = new SMI_Tab();
            //smiTab.ShowDialog();
        }

        private void toolStripMenuUCP_Click(object sender, EventArgs e)
        {
            Form_UCP_Main form_UCP_Main = new Form_UCP_Main();
            form_UCP_Main.Show();
        }
    }
}
