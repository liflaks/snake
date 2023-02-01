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
    public partial class Registration : Form
    {
        string connectionString = @"Data Source=DESKTOP-1LFKS;Initial Catalog=snake;Integrated Security=True";
        public Registration()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void done_Click(object sender, EventArgs e)
        {
            GetPassLog(connectionString, login.Text, password.Text, s_check, password_re.Text);
        }

        private static void GetPassLog(string connectionString, string login, string password, CheckBox check, string password_re)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = $@"SELECT COUNT(*) 
                                  FROM snake.dbo.[users] WHERE login = '{login}'";
                SqlCommand command = new SqlCommand(query, connection);
                var reader = Convert.ToInt32(command.ExecuteScalar());
                if (reader == 0)
                {
                    AddLogPass(connectionString, login, password, check, password_re);
                }

                else
                {
                    MessageBox.Show("Аккаунт с таким логином уже существует");
                }
            }
        }

        private static void AddLogPass(string connectionString, string login, string password, CheckBox check, string password_re)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Random rnd = new Random();
                Guid myuuid = Guid.NewGuid();
                string id = myuuid.ToString();
                int counter_nums = 0;
                int counter_let_caps = 0;
                int counter_let_low = 0;
                char[] a = password.ToCharArray();
                char[] nums = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
                char[] letters_caps = new char[26] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R',
                     'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
                char[] letters_low = new char[26] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r',
                    's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
                if (password.Length < 6)
                {
                    MessageBox.Show("В вашем пороле мало букв и цифр нужно минимум 6");
                }
                for (int i = 0; i < password.Length; i++)
                {
                    foreach (char str in nums)
                    {
                        if (str == a[i])
                        {
                            counter_nums++;
                        }
                    }
                    foreach (char str in letters_caps)
                    {
                        if (str == a[i])
                        {
                            counter_let_caps++;
                        }
                    }
                    foreach (char str in letters_low)
                    {
                        if (str == a[i])
                        {
                            counter_let_low++;
                        }
                    }
                }
                if (counter_let_caps < 1 || counter_let_low < 1 || counter_nums < 1)
                {
                    MessageBox.Show("У вас должнобыть минимум 1 строчная буква, 1 заглавная буква и 1 цифра", "Ошибка! Пороль не криптостойкий",
                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else if (counter_let_caps >= 1 && counter_let_low >= 1 && counter_nums >= 1 && password.Length >= 6)
                {
                    if (password == password_re)
                    {
                        string query = $@"INSERT INTO [users] (login, password, id) 
                                  VALUES ('{login}', '{password}', '{id}')";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                        try
                        {
                            File.WriteAllText("C:\\sessions\\snake_id.txt", $"{id}");
                        }

                        catch
                        {
                            Directory.CreateDirectory("C:\\sessions");
                            File.WriteAllText("C:\\sessions\\snake_id.txt", $"{id}");
                        }
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
                    }

                    else
                    {
                        MessageBox.Show("Повторённый пороль не совпадает с исходныи");
                    }
                    MessageBox.Show("Вы зарегистрированы!");
                    AddMoneyFirst(connectionString, 0);
                    AddRecord(connectionString, 0);
                    Registration reg = new Registration();
                    reg.Hide();
                    Snake_main snake = new Snake_main();
                    snake.Show();
                }
            }
        }

        private static void AddMoneyFirst(string connectionString, int money)
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
                        string query = $@"UPDATE users 
                                        SET money = {money}
                                        WHERE id = '{line}'";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private static void AddRecord(string connectionString, int record)
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
                        string query = $@"UPDATE users 
                                        SET record = {record}
                                        WHERE id = '{line}'";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            Start st = new Start();
            this.Hide();
            st.Show();
        }
    }
}
