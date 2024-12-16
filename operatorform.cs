using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mchs_db_viewer_01
{
    public partial class operatorform : Form
    {
        public operatorform()
        {
            InitializeComponent();
        }
        private void operatorform_Load(object sender, EventArgs e)
        {
            this.statusListTableAdapter.Fill(this.mCHSDataSet.StatusList);
            this.regionsTableAdapter.Fill(this.mCHSDataSet.Regions);
            this.emergTypeListTableAdapter.Fill(this.mCHSDataSet.EmergTypeList);
            this.emergenciesTableAdapter.Fill(this.mCHSDataSet.Emergencies);

        }
        private void emergenciesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emergenciesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mCHSDataSet);
            this.emergenciesTableAdapter.Fill(this.mCHSDataSet.Emergencies);
        }
    }
}
