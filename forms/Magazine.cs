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
    public partial class Magazine : Form
    {
        string connectionString = @"Data Source=DESKTOP-1LFKS;Initial Catalog=snake;Integrated Security=True";
        public Magazine()
        {
            Money(connectionString, label9);
            InitializeComponent();
        }

        private void BuyBlue_Click(object sender, EventArgs e)
        {
            CheckColorBuyed(connectionString, "blue", BuyBlue);
        }

        private void BuyOrange_Click(object sender, EventArgs e)
        {
            CheckColorBuyed(connectionString, "orange", BuyOrange);
        }

        private void BuyRed_Click(object sender, EventArgs e)
        {
            CheckColorBuyed(connectionString, "red", BuyRed);
        }

        private void BuyYellow_Click(object sender, EventArgs e)
        {
            CheckColorBuyed(connectionString, "yellow", BuyYellow);
        }

        private void BuyPurple_Click(object sender, EventArgs e)
        {
            CheckColorBuyed(connectionString, "purple", BuyPurple);
        }

        private void BuyCyan_Click(object sender, EventArgs e)
        {
            CheckColorBuyed(connectionString, "cyan", BuyCyan);
        }

        private static void BuyColor(string connectionString, string color, Button button)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var path = "C:\\sessions\\snake_id.txt";
                connection.Open();
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        string query = $@"UPDATE Colors 
                                        SET {color} = 1
                                        WHERE id = '{line}'";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private static void CheckColorBuyed(string connectionString, string color, Button button)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var path = "C:\\sessions\\snake_id.txt";
                using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string query = $@"SELECT [{color}]
                                       FROM snake.dbo.[users] WHERE [id] = '{line}'";
                        SqlCommand command = new SqlCommand(query, connection);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            if (Convert.ToInt32(reader[$"{color}"]) == 1)
                            {
                                MessageBox.Show("Цвет уже куплен!");
                            }

                            else
                            {
                                MessageBox.Show($"Вы купили цвет {color}!Поздравляю!");
                                BuyColor(connectionString, color, button);
                            }
                        }
                    }
                }
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Snake_main s = new Snake_main();
            s.Show();
        }

        
        private static void Money(string connectionString, Label label)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
           {
               connection.Open();
               var path = "C:\\sessions\\snake_id.txt";
               using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
               {
                   string line;
                   while ((line = sr.ReadLine()) != null)
                   {
                       string query = $@"SELECT [money]
                                 FROM snake.dbo.[users] WHERE id = '{line}'";
                       SqlCommand command = new SqlCommand(query, connection);
                       var reader = command.ExecuteReader();
                       while (reader.Read())
                       {
                           if (reader["money"] == DBNull.Value)
                           {
                                label.Text = "0";
                           }    
                           else
                           {
                                label.Text = reader["money"].ToString();
                           }
                       }
                   }
               }
           }
        }
    }
}

