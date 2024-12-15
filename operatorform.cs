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

        private void emergenciesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emergenciesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mCHSDataSet);

        }

        private void operatorform_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mCHSDataSet.StatusList". При необходимости она может быть перемещена или удалена.
            this.statusListTableAdapter.Fill(this.mCHSDataSet.StatusList);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mCHSDataSet.Regions". При необходимости она может быть перемещена или удалена.
            this.regionsTableAdapter.Fill(this.mCHSDataSet.Regions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mCHSDataSet.EmergTypeList". При необходимости она может быть перемещена или удалена.
            this.emergTypeListTableAdapter.Fill(this.mCHSDataSet.EmergTypeList);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mCHSDataSet.Emergencies". При необходимости она может быть перемещена или удалена.
            this.emergenciesTableAdapter.Fill(this.mCHSDataSet.Emergencies);

        }
    }
}
