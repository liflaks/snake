using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;
using SNAKE.classes;

namespace SNAKE.forms
{
    public partial class Snake_main : Form
    {
        List<Rectanglee> Snake = new List<Rectanglee>();
        List<char> PreviousMovements = new List<char>();
        char Direction = 'D';
        string connectionString = @"Data Source=DESKTOP-1LFKS;Initial Catalog=snake;Integrated Security=True";
        bool GameOver = true;
        Rectanglee food = new Rectanglee();
        static Random random = new Random();
        static int randomFoodX = random.Next(0, 18);
        static int randomFoodY = random.Next(0, 17);
        static int money;
        int score;
        private int highScore;

        public Snake_main()
        {
            InitializeComponent();
            timer.Interval = 150;
        }
        private void BeginGame()
        {
            //сброс переменных
            startButton.Enabled = false;
            comboBox.Enabled = false;
            exit.Enabled = false;
            profile.Enabled = false;
            GameOver = false;
            GameOverPic.Visible = false;
            score = 0;
            CurrentScore.Text = score.ToString();
            UpdateLabel(connectionString, highScore, HighScore);
            Snake.Clear();
            randomFoodX = random.Next(0, 18);
            randomFoodY = random.Next(0, 17);

            //рестарт игры
            timer.Start();
            Rectanglee head = new Rectanglee { X = 0, Y = 0 };
            Snake.Add(head);
            Direction = 'D';
        }
        private void Snake_main_Paint(object sender, PaintEventArgs e)
        {
            moveSnake();
            Graphics graphics = e.Graphics;
            if (!GameOver) //если GamOver false запустить игру
            {
                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                    {
                        graphics.FillRectangle(Brushes.DarkGreen,
                            Snake[i].X * 25, Snake[i].Y * 25, 25, 25);
                    }

                    else
                        graphics.FillRectangle(Brushes.Green,
                            Snake[i].X * 25, Snake[i].Y * 25, 25, 25);
                }
                graphics.FillRectangle(Brushes.White,
                    randomFoodX * 25, randomFoodY * 25, 25, 25);
            }
        }
        private void BeginButtonClicked(object sender, EventArgs e)
        {
            check();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Refresh();

            if (Snake[0].X >= 26 && Direction == 'R' || Snake[0].X < 0 && Direction == 'L'
                || Snake[0].Y >= 25 && Direction == 'D' || Snake[0].Y < 0 && Direction == 'U')
            {
                die();
            }
        }
        private void Snake_main_KeyDown(object sender, KeyEventArgs e)
        {
            //защита от двухстороннего движения
            if (e.KeyCode == Keys.Down && Direction != 'U')
            {
                Direction = 'D';
            }

            if (e.KeyCode == Keys.Up && Direction != 'D')
            {
                Direction = 'U';
            }

            if (e.KeyCode == Keys.Left && Direction != 'R')
            {
                Direction = 'L';
            }

            if (e.KeyCode == Keys.Right && Direction != 'L')
            {
                Direction = 'R';
            }

            if (e.KeyCode == Keys.Enter && startButton.Enabled == true) //запуск игры с enter
            {
                check();
            }
        }
        private void moveSnake()
        {
            for (int i = Snake.Count - 1; i >= 0; i--) //цикл по всему телу
            {
                if (i == 0)//голова змеи
                {
                    if (Direction == 'U')//вверх
                        Snake[i].Y--;

                    if (Direction == 'D')//вниз
                        Snake[i].Y++;

                    if (Direction == 'R')//направо
                        Snake[i].X++;

                    if (Direction == 'L')//влево
                        Snake[i].X--;

                    for (int j = 1; j < Snake.Count; j++)//столкновение с телом
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            die();
                        }
                    }

                    if (Snake[i].X == randomFoodX && Snake[i].Y == randomFoodY)
                    {
                        eat();
                    }
                }

                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;

                }
            }
        }
        private void check()
        {
            if(comboBox.SelectedIndex == 0)//лёгкая сложность
                {
                timer.Interval = 200;
                BeginGame();
            }

            if (comboBox.SelectedIndex == 1)//средняя сложность
            {
                timer.Interval = 100;
                BeginGame();
            }

            if (comboBox.SelectedIndex == 2)//сложная сложность
            {
                timer.Interval = 50;
                BeginGame();
            }

            if (comboBox.SelectedIndex == 3)//жесть сложность
            {
                timer.Interval = 35;
                BeginGame();
            }

            else if (comboBox.Text == "")
            {
                MessageBox.Show("Выберите сложность", "Сложность не выбрана!",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void eat()
        {
            score++;
            CurrentScore.Text = (score * 10).ToString();//обновляю рекорд
            Rectanglee Body = new Rectanglee
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };
            Snake.Add(Body); //добавляю новую часть тела
            //перемещаю новую еду
            randomFoodX = random.Next(0, 18);
            randomFoodY = random.Next(0, 17);

        }
        private void die()
        {
            int ysore;
            int.TryParse(HighScore.Text, out ysore);
            if (score * 10 > ysore)
            {
                highScore = score * 10;
            }
            money = score * 10;
            AddMoney(connectionString, money); // добавляю деньги
            CheckRecord(connectionString, highScore); //проверяю рекорд и обновляю его

            //сбрасываю все переменные
            startButton.Enabled = true;
            GameOverPic.Visible = true;
            exit.Enabled = true;
            profile.Enabled = true;
            comboBox.Enabled = true;
            timer.Stop();
            GameOver = true;
            SystemSounds.Beep.Play();
        }

        private void Leaderboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leaderboard ld = new Leaderboard();
            ld.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profile profile = new Profile();
            profile.Show();
        }

        private static void AddMoney(string connectionString, int money)
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
                                        SET money += {money}
                                        WHERE id = '{line}'";
                        SqlCommand command = new SqlCommand(query, connection);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private static void CheckRecord(string connectionString, int record)
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
                        string query = $@"SELECT [record]
                                  FROM snake.dbo.[users] WHERE id = '{line}'";
                        SqlCommand command = new SqlCommand(query, connection);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            if (Convert.ToInt32(reader["record"]) < record)
                            {
                                AddRecord(connectionString, record);
                            }
                        }
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

        private static void UpdateLabel(string connectionString, int record, Label record_l)
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
                        string query = $@"SELECT [record]
                                  FROM snake.dbo.[users] WHERE id = '{line}'";
                        SqlCommand command = new SqlCommand(query, connection);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            record_l.Text = reader["record"].ToString();
                        }
                    }
                }
            }
        }

        private static string CheckColor(string connectionString)
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
                        string query = $@"SELECT [color]
                                       FROM snake.dbo.[users] WHERE [id] = '{line}'";
                        SqlCommand command = new SqlCommand(query, connection);
                        var reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            return Convert.ToString(reader["color"]);
                        }
                    }
                }
            }
            return "DarkGreen";
        }
    }
}
