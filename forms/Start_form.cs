using SNAKE.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNAKE
{
    public partial class Start : Form
    {
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
            this.Hide();
            SignIn sign = new SignIn();
            sign.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Snake_main snake = new Snake_main();
            snake.Show();
        }
    }
}
