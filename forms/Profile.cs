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
    public partial class Profile : Form
    {
        
        public Profile()
        {
            string connectionString = @"Data Source=DESKTOP-1LFKS;Initial Catalog=snake;Integrated Security=True";
            var path = "C:\\sessions\\snake_id.txt";
            InitializeComponent();
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    FillAll(connectionString, line, login, id, record);
                    var exs = File.Exists("C:\\sessions\\snake_session.txt");
                    if (exs == true)
                    {
                        session.Text = "True";
                        delete.Enabled = true; 
                        delete.Show();
                        checkBox.Show();
                    }

                    else
                    {
                        session.Text = "False";
                    }
                }
            }
        }

        public static void FillAll(string connectionString, string id, Label login, Label id_l, Label record)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $@"SELECT [login], [record]
                                FROM snake.dbo.[users] WHERE id = '{id}'";
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    login.Text = reader["login"].ToString();
                    id_l.Text = id;
                    record.Text = reader["record"].ToString();
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Snake_main sm = new Snake_main();
            sm.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                try
                {
                    var path = "C:\\sessions\\snake_session.txt";
                    File.Delete(path);
                    MessageBox.Show("Сессия удалена!");
                    delete.Hide();
                    delete.Enabled = false;
                    checkBox.Hide();
                }

                catch
                {
                    MessageBox.Show("Ошибка");
                }
                
            }
        }
    }
}
