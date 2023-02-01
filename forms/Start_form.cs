using SNAKE.forms;
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

namespace SNAKE
{
    public partial class Start : Form
    {
        string connectionString = @"Data Source=DESKTOP-1LFKS;Initial Catalog=snake;Integrated Security=True";
        public Start()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();

        }

        private void Sign_In_Click(object sender, EventArgs e)
        {
            var path = "C:\\sessions\\snake_session.txt";
            var exist = File.Exists(path);
            if (exist)
            {
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] t_line = line.Split(" ");
                        GetPassLog(connectionString,t_line[0], t_line[1], this);
                    }
                }
            }

            else
            {
                this.Hide();
                SignIn sign = new SignIn();
                sign.Show();
            }
        }

        private static void GetPassLog(string connectionString, string login, string password, Start st)
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
                    GetId(connectionString, login, password);
                    MessageBox.Show("Вы вошли в аккаунт!");
                    Snake_main snake = new Snake_main();
                    snake.Show();
                    st.Hide();
                }

                else
                {
                    SignIn sign = new SignIn();
                    sign.Show();
                    st.Hide();
                }
            }
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
                    File.WriteAllText("C:\\sessions\\snake_id.txt", $"{reader["id"].ToString()}");
                }
            }
        }
        private void exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
