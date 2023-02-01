using SNAKE.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNAKE.forms
{
    public partial class SignIn : Form
    {
        string connectionString = @"Data Source=DESKTOP-1LFKS;Initial Catalog=snake;Integrated Security=True";
        public SignIn()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void done_Click(object sender, EventArgs e)
        {
            GetPassLog(connectionString, login.Text, password.Text, this, label1, s_check);
        }

        private static void GetPassLog(string connectionString, string login, string password, SignIn signIn, Label label, CheckBox check)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $@"SELECT COUNT(*) 
                                  FROM snake.dbo.[users] WHERE login = '{login}' AND password = '{password}'";
                SqlCommand command = new SqlCommand(query, connection);
                var reader = Convert.ToInt32(command.ExecuteScalar());
                if (reader == 1)
                {
                    if (check.Checked == true)
                    {
                        try
                        {
                            File.WriteAllText("C:\\sessions\\snake_session.txt", $"{login} {password}");
                        }

                        catch
                        {
                            Directory.CreateDirectory("C:\\sessions");
                            File.WriteAllText("C:\\sessions\\snake_session.txt", $"{login} {password}");
                        }
                    }
                    MessageBox.Show("Вы вошли в аккаунт!");
                    GetId(connectionString, login, password);
                    Snake_main snake = new Snake_main();
                    snake.Show();
                    signIn.Hide();
                }

                else
                {
                    label.Text = "Логин или пороль не верны";
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start st = new Start();
            st.Show();
        }

        private static void GetId(string connectionString, string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $@"SELECT [id] 
                                FROM snake.dbo.[users] WHERE login = '{login}' AND password = '{password}'";
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    try
                    {
                        File.WriteAllText("C:\\sessions\\snake_id.txt", $"{reader["id"].ToString()}");
                    }

                    catch
                    {
                        Directory.CreateDirectory("C:\\sessions");
                        File.WriteAllText("C:\\sessions\\snake_id.txt", $"{reader["id"].ToString()}");
                    }

                }
            }
        }
    }
}
