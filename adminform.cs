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
    public partial class adminform : Form
    {
        public adminform()
        {
            InitializeComponent();
        }

        private void emergenciesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.emergenciesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mCHSDataSet);

        }

        private void adminform_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mCHSDataSet.Emergencies". При необходимости она может быть перемещена или удалена.
            this.emergenciesTableAdapter.Fill(this.mCHSDataSet.Emergencies);

        }
    }
}
