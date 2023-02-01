using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNAKE.forms
{
    public partial class Leaderboard : Form
    {
        string connectionString = @"Data Source=DESKTOP-1LFKS;Initial Catalog=snake;Integrated Security=True";
        public Leaderboard()
        {
            UpdateTop(connectionString, top1, top2, top3, top4, top5, top6, top7, top8, top9, top10);
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Snake_main sm = new Snake_main();
            this.Hide();
            sm.Show();
        }

        private static void UpdateTop(string connectionString, Label top1, Label top2, Label top3, Label top4, Label top5, Label top6, Label top7, Label top8, Label top9, Label top10)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Label[] labels = new Label[10] {top1, top2, top3, top4, top5, top6, top7, top8, top9, top10};
                string query = $@"SELECT TOP (10) [record], [login]
                                          FROM [snake].[dbo].[users]
                                          ORDER BY record DESC";
                SqlCommand command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    for (int i = 0;i != labels.Length;i++)
                    {
                        labels[i].Text = reader["login"].ToString() + " " + reader["record"].ToString();
                    }
                }
                    
            }
        }
    }
}
