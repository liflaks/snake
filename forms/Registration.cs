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
    public partial class Registration : Form
    {
        string connectionString = @"Data Source=DESKTOP-1LFKS;Initial Catalog=snake;Integrated Security=True";
        public Registration()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.Show();
        }

        private void done_Click(object sender, EventArgs e)
        {
            GetPassLog(connectionString, login.Text, password.Text);
        }

        private static void GetPassLog(string connectionString, string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $@"SELECT login 
                                  FROM snake.dbo.[users]"; 
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    MessageBox.Show(reader.GetValue(0).ToString());
                    if ((string)reader.GetValue(0) != login)
                    {
                        AddLogPass(connectionString, login, password);
                        MessageBox.Show("Вы зарегистрированы!");
                    }
                }
            }
        }

        private static void AddLogPass(string connectionString, string login, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Random rnd = new Random();
                string[] eng_v = new string[] { "A", "a", "B", "b", "C", "c", "D", "d", "E", "e", "F", "f", "G", "g", "H", "h", "I", "i", "J", "j", "K", "k", "L", "l", "M", "m", "N", "n", "O", "o", "P", "p", "Q", "q", "R", "r", "S", "s", "T", "t", "U", "u", "V", "v", "W", "w", "X", "x", "Y", "y", "Z", "z" };
                int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
                string id = eng_v[rnd.Next(0, 52)] + eng_v[rnd.Next(0, 52)] + eng_v[rnd.Next(0, 52)] + eng_v[rnd.Next(0, 52)] + nums[rnd.Next(0, 10)] + nums[rnd.Next(0, 10)] + rnd.Next(0, 52);
                string query = $@"INSERT INTO [users] (login, password, id) 
                                  VALUES ('{login}', '{password}', '{id}')";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
