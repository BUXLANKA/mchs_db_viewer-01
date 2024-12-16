using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mchs_db_viewer_01.DataContol;

namespace mchs_db_viewer_01
{
    public partial class viewerform : Form
    {
        DataController db = new DataController();

        public viewerform()
        {
            InitializeComponent();
        }

        private void viewerform_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = db.GetConnectionString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM EmergencyTableView";

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();

                        dataAdapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}