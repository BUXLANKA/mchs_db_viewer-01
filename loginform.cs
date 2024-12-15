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
using mchs_db_viewer_01.DataContol;

namespace mchs_db_viewer_01
{
    public partial class loginform : Form
    {
        DataController db = new DataController();

        adminform AdminWindow = new adminform();
        operatorform OperatorWindow = new operatorform();
        viewerform ViewerWindow = new viewerform();

        public loginform()
        {
            InitializeComponent();
        }

        private bool CheckLoginPassword(string login, string password)
        {
            string connectionStr = @"Data Source=DESKTOP-Q8UCL02\SQLEXPRESS;Initial Catalog=MCHS;Integrated Security=True;TrustServerCertificate=True";
            string q = "select count(1) from UserData where Login=@login and Password=@password";

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                try
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(q, connection))
                    {
                        cmd.Parameters.AddWithValue("@login", login);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count == 1)
                        {
                            //MessageBox.Show($"Hello {login}!");
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль");
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                    throw;
                }
            }
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            bool valid = false;

            string login = loginTextbox.Text;
            string password = passwordTextbox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show($"Не все поля заполнены!");
            }
            else
            {
                valid = CheckLoginPassword(login, password);

                if (valid)
                {
                    string connectionString = db.GetConnectionString();

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            string query = "SELECT PositionID FROM UserData WHERE Login = @login";
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.Parameters.AddWithValue("@login", login);

                                int result = Convert.ToInt32(command.ExecuteScalar());

                                if (result == 8 || result == 9 || result == 11 || result == 15 || result == 16)
                                {
                                    AdminWindow.ShowDialog();
                                    this.Close();
                                }
                                else if(result == 7)
                                {
                                    OperatorWindow.ShowDialog();
                                    this.Close();
                                }
                                else
                                {
                                    ViewerWindow.ShowDialog();
                                    this.Close();
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при подключении к базе данных: {ex.Message}");
                        }
                    }
                }
            }

            loginTextbox.Clear();
            passwordTextbox.Clear();
        }
    }
}