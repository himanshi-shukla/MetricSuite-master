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
    public partial class SMI_Form : Form
    {
        List<SMI_Data> smi_data_list = new List<SMI_Data>();
        DataStore ds;
        public SMI_Form()
        {
            InitializeComponent();
        }

        public SMI_Form(DataStore dsRef)
        {
            InitializeComponent();
            ds = dsRef;
            smi_data_list = ds.smiDataListGlobal;
            if(smi_data_list==null)
            {
                smi_data_list = new List<SMI_Data>();
            }
        }

        private void setOrUpdateDataSource()
        {
            //this.dataGridView1.Refresh();
            //this.dataGridView1.Invalidate();

            if(smi_data_list!=null)
            {
                dataGridView_SMI.DataSource = null;
                dataGridView_SMI.DataSource = smi_data_list;
            }
        }

        void configureColumns()
        {
            //dataGridView_SMI.Columns.Clear();
            //dataGridView_SMI.Columns.Add("col1","SMI");
            //dataGridView_SMI.Columns.Add("col2", "Modules Added");
            //dataGridView_SMI.Columns.Add("col3", "Modules Changed");
            //dataGridView_SMI.Columns.Add("col4", "Modules Deleted");
            //dataGridView_SMI.Columns.Add("col5", "Total Modules");

            dataGridView_SMI.Columns[0].HeaderCell.Value = "SMI";
            dataGridView_SMI.Columns[1].HeaderCell.Value = "Modules Added";
            dataGridView_SMI.Columns[2].HeaderCell.Value = "Modules Changed";
            dataGridView_SMI.Columns[3].HeaderCell.Value = "Modules Deleted";
            dataGridView_SMI.Columns[4].HeaderCell.Value = "Total Modules";


            dataGridView_SMI.Columns[0].ReadOnly = true;
        }

        void configureOrRefreshDataGrid()
        {
            setOrUpdateDataSource();
            configureColumns();
        }

        private void SMI_Form_Load(object sender, EventArgs e)
        {
            if(smi_data_list==null || smi_data_list.Count==0)
            {
                smi_data_list.Add(new SMI_Data());
            }

            //smi_data_list.Add(new SMI_Data(1, 2, 3, 4, 5));

            configureOrRefreshDataGrid();
        }

        private void btnAddRow_Click(object sender, EventArgs e)
        {
           
            //smi_data_list.Add(new SMI_Data(1, 11, 33, 44, 55));
            smi_data_list.Add(new SMI_Data());
            configureOrRefreshDataGrid();
        }

        private void btnComputeIndex_Click(object sender, EventArgs e)
        {
            SMI_Data prev_row = new SMI_Data();
            foreach (SMI_Data row in smi_data_list)
            {
                row.totalModule = row.moduleAdded - row.moduleDeleted;
                if(prev_row.totalModule>0)
                {
                    row.totalModule += prev_row.totalModule;
                }

                double res = (row.totalModule - (row.moduleAdded + row.moduleChanged + row.moduleDeleted)) / row.totalModule;
                if (double.IsFinite(res))
                {
                    row.smiValue = res;
                }
                prev_row = row;
            }

            configureOrRefreshDataGrid();
        }

        private void SMI_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && this.ds!=null)
            {
                e.Cancel = true;
                this.ds.smiDataListGlobal = smi_data_list;
                Hide();
            }
        }

    }
}
