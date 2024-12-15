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

namespace mchs_db_viewer_01
{
    public partial class viewerform : Form
    {
        string connectionString = @"Data Source=DESKTOP-Q8UCL02\SQLEXPRESS;Initial Catalog=MCHS;Integrated Security=True;TrustServerCertificate=True";

        public viewerform()
        {
            InitializeComponent();
        }

        private void viewerform_Load(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM EmergencyTableView";
                    string query2 = "SELECT * FROM UserDataTableView";

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();

                        dataAdapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }

                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query2, connection))
                    {
                        DataTable dataTable = new DataTable();

                        dataAdapter.Fill(dataTable);

                        dataGridView2.DataSource = dataTable;
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