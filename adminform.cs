using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mchs_db_viewer_01
{
    public partial class adminform : Form
    {

        public adminform()
        {
            InitializeComponent();
        }

        private void adminform_Load(object sender, EventArgs e)
        {
            this.emergTypeListTableAdapter.Fill(this.mCHSDataSet.EmergTypeList);
            this.positionListTableAdapter.Fill(this.mCHSDataSet.PositionList);
            this.statusListTableAdapter.Fill(this.mCHSDataSet.StatusList);
            this.regionsTableAdapter.Fill(this.mCHSDataSet.Regions);
            this.userDataTableAdapter.Fill(this.mCHSDataSet.UserData);
            this.emergenciesTableAdapter.Fill(this.mCHSDataSet.Emergencies);

        }

        private void emergenciesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.emergenciesTableAdapter.Update(this.mCHSDataSet.Emergencies);
            this.tableAdapterManager.UpdateAll(this.mCHSDataSet);
            this.emergenciesTableAdapter.Fill(this.mCHSDataSet.Emergencies);
        }
        private void UserDataSaveButton_Click(object sender, EventArgs e)
        {
            this.userDataTableAdapter.Update(this.mCHSDataSet.UserData);
            this.tableAdapterManager.UpdateAll(this.mCHSDataSet);
            this.emergenciesTableAdapter.Fill(this.mCHSDataSet.Emergencies);
        }
        private void PositionTableSaveButton_Click(object sender, EventArgs e)
        {
            this.positionListTableAdapter.Update(this.mCHSDataSet.PositionList);
            this.tableAdapterManager.UpdateAll(this.mCHSDataSet);
            this.positionListTableAdapter.Fill(this.mCHSDataSet.PositionList);
        }
        private void RegioListSaveButton_Click(object sender, EventArgs e)
        {
            this.regionsTableAdapter.Update(this.mCHSDataSet.Regions);
            this.tableAdapterManager.UpdateAll(this.mCHSDataSet);
            this.regionsTableAdapter.Fill(this.mCHSDataSet.Regions);
        }
        private void EmTypeSaveButton_Click(object sender, EventArgs e)
        {
            this.emergTypeListTableAdapter.Update(this.mCHSDataSet.EmergTypeList);
            this.tableAdapterManager.UpdateAll(this.mCHSDataSet);
            this.emergTypeListTableAdapter.Fill(this.mCHSDataSet.EmergTypeList);
        }
        private void StatusListSaveButton_Click(object sender, EventArgs e)
        {
            this.statusListTableAdapter.Update(this.mCHSDataSet.StatusList);
            this.tableAdapterManager.UpdateAll(this.mCHSDataSet);
            this.statusListTableAdapter.Fill(this.mCHSDataSet.StatusList);
        }


        //private void UserDataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    //this.userDataBindingSource.EndEdit();
        //    ////this.tableAdapterManager.Update(this.mCHSDataSet);
        //    //this.userDataTableAdapter.Update(this.mCHSDataSet.UserData);
        //    //this.tableAdapterManager.UpdateAll(this.mCHSDataSet);
        //}

        
    }
}
